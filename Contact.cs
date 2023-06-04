using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTime Birthday { get; set; }

        public Contact()
        {
            Id = 0;
            Name = string.Empty;
            Number = string.Empty;
            Birthday = DateTime.MinValue;
        }

        public Contact(int id, string name, string number, DateTime date)
        {
            Id = id;
            Name = name;
            Number = number;
            Birthday = date;
        }
    }
}
