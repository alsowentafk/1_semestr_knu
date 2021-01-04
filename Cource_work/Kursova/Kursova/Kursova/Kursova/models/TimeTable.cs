using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Kursova.models;

namespace Kursova.models
{
    [DataContract]
    class TimeTable
    {
        [DataMember]
        Dictionary<string,Route> stops { get; set; }
        [DataMember]
        Dictionary<string, Route> timetable { get; set; }
        public TimeTable(Dictionary<string,Route> Stops, Dictionary<string, Route> Timetable)
        {
            this.stops = Stops;
            this.timetable = Timetable;         
        }
    }
}
