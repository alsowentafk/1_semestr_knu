using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.models
{
    [DataContract]
    public class Operation
    {
        [DataMember]
        public DateTime time;
        [DataMember]
        public string sum { get; set; }

        public Operation(DateTime time, string sum)
        {
            this.time = time;
            this.sum = sum;
        }
    }
}
