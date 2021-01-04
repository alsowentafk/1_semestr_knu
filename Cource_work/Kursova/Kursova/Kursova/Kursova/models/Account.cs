using Kursova.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova.Model
{
    [DataContract]
    public class Account
    {                
        [DataMember]
        public double balance { get; set; }
        [DataMember]
        public Deposit deposit { get; set; }

        [DataMember]
        public List<Operation> lastOperations { get; set; }

        public void minusMoney(double sumOperation)
        {
            if (balance < sumOperation)
            {
                MessageBox.Show("Недостатньо коштів на рахунку", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                balance -= sumOperation; 
            }
        }

        public void plusMoney(double sumOperation)
        {
            balance += sumOperation;
        }

        public Account(double balance, Deposit deposit, List<Operation> lastOperations)
        {            
            this.balance = balance;
            this.deposit = deposit ?? throw new ArgumentNullException(nameof(deposit));
            this.lastOperations = lastOperations ?? throw new ArgumentNullException(nameof(lastOperations));
        }
    }
}
