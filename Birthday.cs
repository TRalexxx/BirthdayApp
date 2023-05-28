using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp
{
    internal class Birthday
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dateofbirth { get; set; }

        public Birthday()
        {
            Id = 0;
            Name = string.Empty;
            Dateofbirth = DateTime.MinValue;
        }

        public Birthday(string name, DateTime birthday) : base()
        {
            
            Name = name;
            Dateofbirth = birthday;
        }
    }
}
