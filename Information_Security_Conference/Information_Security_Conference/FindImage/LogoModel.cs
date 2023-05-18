using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_Security_Conference.FindImage
{
    public class LogoModel
    {
        public LogoModel(int id, string name, string events, DateTime date, string path)
        {
            ID = id;
            Name = name;
            Event = events;
            Date = date;
            Path = path;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Event { get; set; }
        public DateTime Date { get; set; }
        public string Path { get; set; }
    }
}
