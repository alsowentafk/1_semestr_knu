using Kursova.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova.Repository
{
    public static class Serealizator
    {
        private const string filename = "dataBase.xml";
        private static DataContractSerializer dcs = new DataContractSerializer(typeof(Dictionary<uint, Client>));
        private static void showMes(String str)
        {
            MessageBox.Show(str, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static Dictionary<uint, Client> desearealizable()
        {
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    Dictionary<uint, Client> db = (Dictionary<uint, Client>)dcs.ReadObject(fs);
                    db.Values.ToList().ForEach(a => a.account.deposit.augmentMoney());
                    return db;
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                showMes("Файл не знайдено!");
                return null;
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                showMes("Файл пустий або пошкоджений");
                return null;
            }

        }

        public static void serealizable(Dictionary<uint, Client> db)
        {           
           try
           {
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                      dcs.WriteObject(fs, db);
                }
           }                       
            catch (System.Runtime.Serialization.SerializationException)
            {
                showMes("Неможливо записати у файл");
            }
        }
    }
}
