using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connStr = @"Data Source=DESKTOP-O6O2RKO;" +
                "Initial catalog=User_db;" +
                "Integrated Security=True;";

        int x = 0;
        int y = 5;

        private void Form1_Load(object sender, EventArgs e)
        {           


            using (DbConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                List<Birthday> list = new List<Birthday>();

                list = conn.GetAll<Birthday>().ToList();

                for (int i = 0; i < list.Count; i++)
                {
                    BirthdayControl birthdayControl = new BirthdayControl(list[i].Name, list[i].Dateofbirth);
                    birthdayControl.Location = new Point(x, y);
                    y += birthdayControl.Height + 5;

                    birthdaysPanel.Controls.Add(birthdayControl);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            using(DbConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                
                Birthday birthday = new Birthday(nameTB.Text, birthdayPicker.Value);

                conn.Insert(birthday);
                

                BirthdayControl birthdayControl = new BirthdayControl(birthday.Name, birthday.Dateofbirth);
                birthdayControl.Location = new Point(x, y);
                y += birthdayControl.Height + 5;

                birthdaysPanel.Controls.Add(birthdayControl);
            }
        }
    }
}
