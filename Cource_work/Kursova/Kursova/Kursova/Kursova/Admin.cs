using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using Kursova.Model;
using Kursova.models;
using kursova;
using Kursova.Repository;
using Microsoft.VisualBasic;

namespace Kursova
{
    public partial class Admin : Form
    {
        Dictionary<uint, Client> clientsDictionary = new Dictionary<uint, Client>();
        public Admin()
        {
            InitializeComponent();
        }

        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void режимКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }
        public void clearTb(TextBox tb)
        {
            tb.Text = "";
        }

        private uint ToUInt(String str)
        {
            return Convert.ToUInt32(str);
        }

        public void showMes(String str)
        {
            MessageBox.Show(str, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }    
        
        public bool tryToUint(string str)
        {
            try
            {
                Convert.ToUInt32(str);
                return true;
            }
            catch (Exception)
            {
                showMes("Некоректне введення");
                return false;
            }
        }

       /* public bool tryToDouble(string str)
        {
            try
            {
                Convert.ToDouble(str);
                return true;
            }
            catch (Exception)
            {
                showMes("Некоректне введення");
                return false;
            }
        }*/
        private void refreshDatagrid(List<Operation> operationList)
        {
            if (operationList.Count == 0)
            {
                showMes("Список операцій пустий пустий");
                return;
            }
            dataGridView1.RowCount = operationList.Count;
            int i = 0;
            foreach (Operation a in operationList)
            {
                dataGridView1[0, i].Value = a.time.ToString();
                dataGridView1[1, i].Value = a.sum.ToString();
                i++;
            }
        }

        private void refreshCbEditClient()
        {
            cbEditClient.Items.Clear();
            cbEditClient.Items.AddRange(clientsDictionary.Values.Select(a => a.pasport.ToString()).ToArray());
            cbEditClient.SelectedItem = null;
            cbEditClient.Text = "";
            cbEditClient.Update();
        }

        private void clearAllFields()
        {
            tbEditName.Text = "";
            tbEditPrizv.Text = "";
            tbEditSurname.Text = "";
            tbEditPasport.Text = "";
            tbEditPinKod.Text = "";
            label7.Text = "";
            label13.Text = "";
            label15.Text = "";
            refreshDatagrid(new List<Operation>() { new Operation(default(DateTime), "") });
            refreshCbEditClient();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            this.Width = 866;
            this.Height = 426;
            clientsDictionary = Serealizator.desearealizable();
            if (clientsDictionary == null)
            {
                clientsDictionary = new Dictionary<uint, Client>();
            }
            tSS2.Text = "Прочитано клієнтів з файлу";
        }       
                     
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (tabControl1.SelectedIndex == 0)
            {
                
                this.Width = 866;
                this.Height = 426;
                cbEditClient.SelectedItem = null;
            }
            else
            {
                clearAllFields();
                this.Width = 1302;
                this.Height = 880;
                cbEditClient.Items.Clear();
                if (clientsDictionary == null)
                {
                    showMes("Список пустий");
                    return;
                }
                refreshCbEditClient();
                refreshDatagrid(new List<Operation>() { new Operation(default(DateTime), "") });           
            }
        }      
      
        private void Button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                showMes("Оберіть тип клієнта!");
                return;
            }
            if (comboBox1.SelectedItem.ToString() == "Фізична особа" && (tbAddName.Text == "" || tbAddPrizv.Text == "" || tbAddSurname.Text == "" || tbAddPasport.Text == "" || tbAddPinKod.Text == ""))
            {
                    showMes("Не всі рядки заповнено!");
                    return;
            }
            if (comboBox1.SelectedItem.ToString() == "Юридична особа" && (tbAddName.Text == "" || tbAddPrizv.Text == "" || tbAddPinKod.Text == ""))
            {
                showMes("Не всі рядки заповнено!");
                return;
            }
            if (comboBox1.SelectedItem.ToString() == "Фізична особа" && (!tryToUint(tbAddPasport.Text) || !tryToUint(tbAddPinKod.Text)))
            {
                showMes("Некоректно введенні данні!");
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "Юридична особа" && (!tryToUint(tbAddPrizv.Text) || !tryToUint(tbAddPinKod.Text)))
            {
                showMes("Некоректно введенні данні!");
                return;
            }
            Client client = null;
            if (comboBox1.SelectedItem.ToString() == "Фізична особа")
            {
                if (clientsDictionary != null)
                {

                    if (!clientsDictionary.Values.All(a => a.pasport != ToUInt(tbAddPasport.Text)))
                    {
                        showMes("Такий клієнт вже існує");
                        return;
                    }

                    if (!clientsDictionary.Keys.All(a => a != ToUInt(tbAddPinKod.Text)) || tbAddPinKod.Text == "0000")
                    {
                        showMes("Такий пін Код вже існує");
                        return;
                    }
                }
                 client = new Client(tbAddName.Text, tbAddPrizv.Text, tbAddSurname.Text, ToUInt(tbAddPasport.Text), new Account(0, new Deposit("", 0, 0, default(DateTime), default(TimeSpan)), new List<Operation>()));
            }
            else
            {
                if (clientsDictionary != null)
                {

                    if (!clientsDictionary.Values.All(a => a.pasport != ToUInt(tbAddPrizv.Text)))
                    {
                        showMes("Такий клієнт вже існує");
                        return;
                    }

                    if (!clientsDictionary.Keys.All(a => a != ToUInt(tbAddPinKod.Text)))
                    {
                        showMes("Такий пін Код вже існує");
                        return;
                    }
                }
                client = new Client(tbAddName.Text,null, null, ToUInt(tbAddPrizv.Text), new Account(0, new Deposit("", 0, 0, default(DateTime), default(TimeSpan)), new List<Operation>()));
            }
            clientsDictionary.Add(ToUInt(tbAddPinKod.Text), client);
            Serealizator.serealizable(clientsDictionary);
            clearTb(tbAddName); clearTb(tbAddPrizv); clearTb(tbAddSurname); clearTb(tbAddPasport); clearTb(tbAddPinKod);
            tSS2.Text = "Додано клієнта і записано у файл";
        }

        public void findClient(Client client)
        {           
            tbEditName.Text = client.name;
            tbEditPrizv.Text = client.prizv;
            tbEditSurname.Text = client.surname;
            tbEditPasport.Text = client.pasport.ToString();
            tbEditPinKod.Text = clientsDictionary.FirstOrDefault(x => x.Value == client).Key.ToString();
            label7.Text = "Баланс " + client.account.balance.ToString();
            cbEditDeposit.Text = client.account.deposit.type;
            if (client.account.deposit.type == "Універсальний")
            {
                btEditClientMinusMoneyDeposit.Enabled = true;
                btEditClientPlusMoneyDeposit.Enabled = true;
            }
            else if (client.account.deposit.type == "Накопичувальний")
            {
                btEditClientMinusMoneyDeposit.Enabled = false;
                btEditClientPlusMoneyDeposit.Enabled = true;
            }
            else
            {
                btEditClientMinusMoneyDeposit.Enabled = false;
                btEditClientPlusMoneyDeposit.Enabled = false;
            }
            if (client.account.deposit.type == "")
            {
                cbEditDeposit.Enabled = true;
                btEditClientDeposit.Visible = true;
            }
            label13.Text = "Баланс " + client.account.deposit.balance.ToString();
            label15.Text = "Дата вкладу " + client.account.deposit.dateOfDeposit.ToString();
            if (client.account.lastOperations.Count == 0)
            {
                refreshDatagrid(new List<Operation>() { new Operation(default(DateTime), "") });
            }
            refreshDatagrid(client.account.lastOperations);
            tSS.Text = "Обрано " + tbEditPasport.Text.ToString();
        }
        private void CbEditClient_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (cbEditClient.SelectedItem == null)
            {
                return;
            }
            if (cbEditClient.Items.Count == 0)
            {
                showMes("Список клієнтів пустий");
                return;
            }
            Client client = clientsDictionary.Values.ToList().Find(a => a.pasport == ToUInt(cbEditClient.SelectedItem.ToString()));
            findClient(client);
            if (client.prizv == null)
            {
                tbEditSurname.Visible = false;
                tbEditPrizv.Visible = false;
                label3.Visible = false;
                label1.Visible = false;
                label6.Text = "id";
            }
            else
            {
                tbEditSurname.Visible = true;
                tbEditPrizv.Visible = true;
                label3.Visible = true;
                label1.Visible = true;
                label6.Text = "Номер паспорту";
            }
  
        }
        private void BtEditFindClient_Click(object sender, EventArgs e)
        {
            string str = Interaction.InputBox("Введіть номер паспорта клієнта?", "", "");
            if(!tryToUint(str))
            {
                return;
            }
            uint pasport = ToUInt(str);
            Client client = clientsDictionary.Values.ToList().Find(a => a.pasport == pasport);

            findClient(client);

        }

        private void BtEditClient_Click(object sender, EventArgs e)
        {
            Client client = clientsDictionary.Values.ToList().Find(a => a.pasport == ToUInt(cbEditClient.SelectedItem.ToString()));
            if (client.prizv != null)
            {
                if (tbEditName.Text == "" || tbEditPrizv.Text == "" || tbEditSurname.Text == "" || tbEditPasport.Text == "" || tbEditPinKod.Text == "")
                {
                    showMes("Не всі рядки заповнено!");
                    return;
                }              
                client.name = tbEditName.Text;
                client.prizv = tbEditPrizv.Text;
                client.surname = tbEditSurname.Text;
                client.pasport = ToUInt(tbEditPasport.Text);
            }
            else
            {
                if (tbEditName.Text == "" || tbEditPasport.Text == "" || tbEditPinKod.Text == "")
                {
                    showMes("Не всі рядки заповнено!");
                    return;
                }
                client.name = tbEditName.Text;
                client.prizv = null;
                client.surname = null;
                client.pasport = ToUInt(tbEditPasport.Text);
            }
            if (!tryToUint(tbEditPasport.Text) || !tryToUint(tbEditPinKod.Text))
            {
                  return;
            }

            if (cbEditClient.SelectedItem == null)
            {
                return;
            }
            if (cbEditClient.Items.Count == 0)
            {
                showMes("Список клієнтів пустий");
                return;
            }
                  
            uint key = clientsDictionary.FirstOrDefault(x => x.Value == client).Key;
            clientsDictionary.Remove(key);
            clientsDictionary.Add(ToUInt(tbEditPinKod.Text), client);
            Serealizator.serealizable(clientsDictionary);
            clearAllFields();
            refreshCbEditClient();
            tSS.Text = "Віредаговано";
        }

        private void BtEditClientMinusMoney_Click(object sender, EventArgs e)
        {
            if (cbEditClient.SelectedItem == null)
            {
                showMes("Оберіть клієнта");
                return;
            }
            if (cbEditClient.Items.Count == 0)
            {
                showMes("Список клієнтів пустий");
                return;
            }
            Client client = clientsDictionary.Values.ToList().Find(a => a.pasport == ToUInt(cbEditClient.SelectedItem.ToString()));
            uint key = clientsDictionary.FirstOrDefault(x => x.Value == client).Key;
            string suma = Interaction.InputBox("Введіть cуму", "", "");
            if (!tryToUint(suma))
            {
                return;
            }

            if (Convert.ToDouble(suma) == 0)
            {
                showMes("Не може бути 0");
                return;
            }
            if (client.account.balance.Equals(0) || ToUInt(suma) > client.account.balance)
            {
                showMes("Недостатньо коштів на рахунку");
                return;
            }
            else
            {
                client.account.minusMoney(Convert.ToDouble(suma));
                client.account.lastOperations.Add(new Operation(DateTime.Now,("-"+suma + " UAH")));
                clientsDictionary[key] = client;
                Serealizator.serealizable(clientsDictionary);
                label7.Text = "Баланс " + client.account.balance.ToString();
                refreshDatagrid(client.account.lastOperations);
                tSS.Text = "Знято" + suma + " UAH";
            }
        }

        private void BtEditClientPlusMoney_Click(object sender, EventArgs e)
        {
            if (cbEditClient.SelectedItem == null)
            {
                showMes("Оберіть клієнта");
                return;
            }
            if (cbEditClient.Items.Count == 0)
            {
                showMes("Список клієнтів пустий");
                return;
            }
            Client client = clientsDictionary.Values.ToList().Find(a => a.pasport == ToUInt(cbEditClient.SelectedItem.ToString()));
            uint key = clientsDictionary.FirstOrDefault(x => x.Value == client).Key;
            string suma = Interaction.InputBox("Введіть cуму", "", "");
            if (!tryToUint(suma))
            {
                return;
            }
            if (Convert.ToDouble(suma) == 0)
            {
                showMes("Не може бути 0");
                return;
            }
            client.account.plusMoney(Convert.ToDouble(suma));
             client.account.lastOperations.Add(new Operation(DateTime.Now, ("+"+suma + " UAH")));
             clientsDictionary[key] = client;
             Serealizator.serealizable(clientsDictionary);
             label7.Text = "Баланс " + client.account.balance.ToString();
             refreshDatagrid(client.account.lastOperations);
             tSS.Text = "Внесено на баланс" + suma + " UAH";            
        }

        private void CbEditDeposit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEditDeposit.Text == "Універсальний")
            {
                btEditClientMinusMoneyDeposit.Enabled = true;
                btEditClientPlusMoneyDeposit.Enabled = true;
            }
            else if (cbEditDeposit.Text == "Накопичувальний")
            {
                btEditClientMinusMoneyDeposit.Enabled = false;
                btEditClientPlusMoneyDeposit.Enabled = true;
            }
            else
            {
                btEditClientMinusMoneyDeposit.Enabled = false;
                btEditClientPlusMoneyDeposit.Enabled = false;
            }
               
        }

        private void BtEditClientDeposit_Click(object sender, EventArgs e)
        {
            if (cbEditClient.SelectedItem == null)
            {
                showMes("Оберіть клієнта");
                return;
            }
            if (cbEditClient.Items.Count == 0)
            {
                showMes("Список клієнтів пустий");
                return;
            }
            Client client = clientsDictionary.Values.ToList().Find(a => a.pasport == ToUInt(cbEditClient.SelectedItem.ToString()));
            uint key = clientsDictionary.FirstOrDefault(x => x.Value == client).Key;
            if (cbEditDeposit.Text == "")
            {
                showMes("Оберіть тип депозиту!");
                return;
            }
            client.account.deposit.type = cbEditDeposit.Text;
            client.account.deposit.initStavka(cbEditDeposit.Text);
            client.account.deposit.dateOfDeposit = DateTime.Now;
          
            string interval = Interaction.InputBox("Введіть кількість місяців: на скільки ви хочете покласти: ", "", "");         
            if (!tryToUint(interval))
            {
                return;
            }
            if (Convert.ToDouble(interval) == 0)
            {
                showMes("Не може бути 0");
                return;
            }
            TimeSpan interv = new TimeSpan((int)(ToUInt(interval)*31),0,0,0);
            client.account.deposit.interval = interv;
            string suma = Interaction.InputBox("Введіть cуму яку ви хочете покласти: ", "", "");
            if (!tryToUint(suma))
            {
                return;
            }
            if (Convert.ToDouble(suma) == 0)
            {
                showMes("Не може бути 0");
                return;
            }
            client.account.deposit.balance = Convert.ToDouble(suma);
            client.account.lastOperations.Add(new Operation(DateTime.Now, ("(Депозит) +" + suma + " UAH")));
            clientsDictionary[key] = client;
            Serealizator.serealizable(clientsDictionary);
            label13.Text = "Баланс " + client.account.deposit.balance.ToString();
            refreshDatagrid(client.account.lastOperations);
            tSS.Text = "Внесено на депозит" + suma + " UAH";
            label15.Text = client.account.deposit.dateOfDeposit.ToString();
            btEditClientDeposit.Visible = false;
            cbEditDeposit.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cbEditClient.SelectedItem == null)
            {
                showMes("Оберіть клієнта");
                return;
            }
            if (cbEditClient.Items.Count == 0)
            {
                showMes("Список клієнтів пустий");
                return;
            }
            Client client = clientsDictionary.Values.ToList().Find(a => a.pasport == ToUInt(cbEditClient.SelectedItem.ToString()));
            uint key = clientsDictionary.FirstOrDefault(x => x.Value == client).Key;           
            clientsDictionary.Remove(key);
            Serealizator.serealizable(clientsDictionary);
            clearAllFields();
            refreshCbEditClient();
            tSS.Text = "Видалено";
        }

        private void BtEditClientMinusMoneyDeposit_Click(object sender, EventArgs e)
        {
            if (cbEditClient.SelectedItem == null)
            {
                showMes("Оберіть клієнта");
                return;
            }
            if (cbEditClient.Items.Count == 0)
            {
                showMes("Список клієнтів пустий");
                return;
            }
            Client client = clientsDictionary.Values.ToList().Find(a => a.pasport == ToUInt(cbEditClient.SelectedItem.ToString()));
            uint key = clientsDictionary.FirstOrDefault(x => x.Value == client).Key;
            string suma = Interaction.InputBox("Введіть cуму : ", "", "");
            if (!tryToUint(suma))
            {
                return;
            }
            if (Convert.ToDouble(suma) > client.account.balance)
            {
                showMes("недостатньо коштів на депозиті");
                return;
            }
            if (Convert.ToDouble(suma) == 0)
            {
                showMes("Не може бути 0");
                return;
            }
            client.account.deposit.minusMoney(Convert.ToDouble(suma));
            client.account.lastOperations.Add(new Operation(DateTime.Now, ("(Депозит) -" + suma + " UAH")));
            clientsDictionary[key] = client;
            Serealizator.serealizable(clientsDictionary);
            label13.Text = "Баланс " + client.account.deposit.balance.ToString();
            refreshDatagrid(client.account.lastOperations);
            tSS.Text = "Знято з депозиту на депозит " + suma + " UAH";
        }

        private void BtEditClientPlusMoneyDeposit_Click(object sender, EventArgs e)
        {
            if (cbEditClient.SelectedItem == null)
            {
                showMes("Оберіть клієнта");
                return;
            }
            if (cbEditClient.Items.Count == 0)
            {
                showMes("Список клієнтів пустий");
                return;
            }
            Client client = clientsDictionary.Values.ToList().Find(a => a.pasport == ToUInt(cbEditClient.SelectedItem.ToString()));
            uint key = clientsDictionary.FirstOrDefault(x => x.Value == client).Key;
            string suma = Interaction.InputBox("Введіть cуму : ", "", "");
            if (!tryToUint(suma))
            {
                return;
            }

            if (Convert.ToDouble(suma) == 0)
            {
                showMes("Не може бути 0");
                return;
            }
            client.account.deposit.plusMoney(Convert.ToDouble(suma));
            client.account.lastOperations.Add(new Operation(DateTime.Now, ("(Депозит) +" + suma + " UAH")));
            clientsDictionary[key] = client;
            Serealizator.serealizable(clientsDictionary);
            label13.Text = "Баланс " + client.account.deposit.balance.ToString();
            refreshDatagrid(client.account.lastOperations);
            tSS.Text = "Внесено на депозит " + suma + " UAH";
        }

        private void TbAddPasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TbAddPinKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TbEditPasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TbEditPinKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Фізична особа")
            {
                label10.Visible = true;
                label4.Visible = true;
                tbAddSurname.Visible = true;
                tbAddPasport.Visible = true;
                label12.Text = "Прізвище";
            }
            else if(comboBox1.SelectedItem.ToString() == "Юридична особа")
            {
                label10.Visible = false;
                label4.Visible = false;
                tbAddSurname.Visible = false;
                tbAddPasport.Visible = false;
                label12.Text = "id";
            }
        }
    }
    
}

