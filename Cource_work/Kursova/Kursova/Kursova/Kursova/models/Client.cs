using Kursova.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.models
{
    [DataContract]
    public class Client
    {        
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string prizv { get; set; }
        [DataMember]
        public string surname { get; set; }
        [DataMember]
        public uint pasport { get; set; }

        [DataMember]
        public Account account { get; set; }
        public Client(string name, string prizv, string surname, uint pasport, Account account)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.prizv = prizv ;
            this.surname = surname;
            this.pasport = pasport;
            this.account = account ?? throw new ArgumentNullException(nameof(account));
        }
    }
}
