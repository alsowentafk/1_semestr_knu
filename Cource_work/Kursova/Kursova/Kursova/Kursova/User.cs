using Kursova.Model;
using Kursova.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Kursova;
using System.Runtime.Serialization.Json;
using Kursova.Repository;

namespace kursova
{
    public partial class User : Form
    {
        Dictionary<uint, Client> clientsDictionary;
        Client client;
        uint key;
        public User(Dictionary<uint, Client> dictionary, Client client, uint key)
        {
            clientsDictionary = dictionary;
            this.client = client;
            this.key = key;
            InitializeComponent();
            if (client.prizv == null)
            {
                tbEditPrizv.Visible = false;
                tbEditSurname.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                label6.Text = "id";
            }
            else
            {
                tbEditPrizv.Visible =true;
                tbEditSurname.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
                label6.Text = "Номер паспорту";
            }
        }      
        private uint ToUInt(String str)
        {
            return Convert.ToUInt32(str);
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
        public void showMes(String str)
        {
            MessageBox.Show(str, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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

        private void User_Load(object sender, EventArgs e)
        {
            tbEditName.Text = client.name;
            tbEditPrizv.Text = client.prizv;
            tbEditSurname.Text = client.surname;
            tbEditPasport.Text = client.pasport.ToString();
            tbEditPinKod.Text = clientsDictionary.FirstOrDefault(x => x.Value == client).Key.ToString();
            label7.Text = "Баланс " + client.account.balance.ToString();
            label8.Text = client.account.deposit.type;
           
            label13.Text = "Баланс " + client.account.deposit.balance.ToString();
            label4.Text = "Дата вкладу " + client.account.deposit.dateOfDeposit.ToString();
            if (client.account.lastOperations.Count == 0)
            {
                refreshDatagrid(new List<Operation>() { new Operation(default(DateTime), "") });
            }
            refreshDatagrid(client.account.lastOperations);
            tSS2.Text = "Обрано " + tbEditPasport.Text.ToString();
        }

        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void повернутисьДоLogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
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
                client.account.lastOperations.Add(new Operation(DateTime.Now, ("-" + suma + " UAH")));
                clientsDictionary[key] = client;
                Serealizator.serealizable(clientsDictionary);
                label7.Text = "Баланс " + client.account.balance.ToString();
                refreshDatagrid(client.account.lastOperations);
                tSS2.Text = "Знято" + suma + " UAH";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
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
            client.account.lastOperations.Add(new Operation(DateTime.Now, ("+" + suma + " UAH")));
            clientsDictionary[key] = client;
            Serealizator.serealizable(clientsDictionary);
            label7.Text = "Баланс " + client.account.balance.ToString();
            refreshDatagrid(client.account.lastOperations);
            tSS2.Text = "Внесено на баланс" + suma + " UAH";
        }
    }
}
