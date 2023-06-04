using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayApp
{
    public partial class BirthdayControl : UserControl
    {
        public BirthdayControl()
        {
            InitializeComponent();
        }

        public BirthdayControl(string name, string number, DateTime birthday):this()
        {
            nameL.Text = name;
            numberL.Text = number;
            
            birthdayL.Text = birthday.ToString("dd-MM-yyyy");

        }
    }
}
