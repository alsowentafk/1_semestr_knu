using Kursova.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova.models
{
    [DataContract]
    public class Deposit
    {
        
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public double balance { get; set; }
        [DataMember]
        public double stavka { get; set; }
        [DataMember]
        public DateTime dateOfDeposit { get; set; }
        [DataMember]
        public TimeSpan interval { get; set; }

        public void initStavka(string str)
        {
            stavka = str == "Накопичувальний" ? 12.5 : 0;
            stavka = str == "Ощадний" ? 12.75 : 0;
            stavka = str == "Універсальний" ? 12 : 0;
        }

        public void minusMoney(double sumOperation)
        {
            if(type != "Універсальний")
            {
                MessageBox.Show("Вам недоступна ця операція", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (balance < sumOperation)
            {
                MessageBox.Show("Недостатньо коштів на рахунку", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                balance -= sumOperation;
            }
        }

        public void plusMoney(double sumOperation)
        {
            if (type == "Ощадний")
            {
                MessageBox.Show("Вам недоступна ця операція", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            balance += sumOperation;
        }
        public void augmentMoney()
        {
            if ((DateTime.Now - dateOfDeposit).Equals(interval))
            {
                balance *= stavka;
            }
            else return;
        }

        public Deposit(string type, double balance, double stavka, DateTime dateOfDeposit, TimeSpan interval)
        {
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.balance = balance;
            this.stavka = stavka;
            this.dateOfDeposit = dateOfDeposit;
            this.interval = interval;
        }
    }
}
