using kursova;
using Kursova;
using Kursova.models;
using Kursova.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<uint, Client> clientsDictionary = Serealizator.desearealizable();            
            if (tb1.Text == "")
            {
                MessageBox.Show("Заповніть поле з паролем!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb1.Text == "0000")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
                return;
            }
            Client client = null;
            try
            {
               client = clientsDictionary[Convert.ToUInt32(tb1.Text)];
            }
            catch
            {
                MessageBox.Show("Такого пін коду не знайдено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb1.Text = "";
                return;
            }                
            User user = new User(clientsDictionary,client, Convert.ToUInt32(tb1.Text));
            user.Show();
            this.Hide();         
        }

        private void Tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tb1.PasswordChar = '\0';
            }
            else
            {
                tb1.PasswordChar = '*';
            }
        }
    }
}
