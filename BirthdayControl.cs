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

        public BirthdayControl(string name, DateTime birthday):this()
        {
            nameL.Text = name;
            
            birthdayL.Text = birthday.ToString("dd-MM-yyyy");

        }
    }
}
