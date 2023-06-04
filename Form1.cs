using System;
using System.Drawing;
using System.Windows.Forms;

namespace BirthdayApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        //string connStr = @"Data Source=DESKTOP-O6O2RKO;" +
        //        "Initial catalog=User_db;" +
        //        "Integrated Security=True;";

        int x = 0;
        int y = 5;

        private void Form1_Load(object sender, EventArgs e)
        {


            //using (DbConnection conn = new SqlConnection(connStr))
            //{
            //    conn.Open();

            //    List<Birthday> list = new List<Birthday>();

            //    list = conn.GetAll<Birthday>().ToList();

            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        BirthdayControl birthdayControl = new BirthdayControl(list[i].Name, list[i].Dateofbirth);
            //        birthdayControl.Location = new Point(x, y);
            //        y += birthdayControl.Height + 5;

            //        birthdaysPanel.Controls.Add(birthdayControl);
            //    }
            //}

            using (MyApplicationContext context = new MyApplicationContext())
            {

                foreach (Contact item in context.Contacts)
                {
                    BirthdayControl birthdayControl = new BirthdayControl(item.Name, item.Number, item.Birthday);
                    birthdayControl.Location = new Point(x, y);
                    y += birthdayControl.Height + 5;

                    birthdaysPanel.Controls.Add(birthdayControl);
                }

            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            //using(DbConnection conn = new SqlConnection(connStr))
            //{
            //    conn.Open();

            //    Birthday birthday = new Birthday(nameTB.Text, birthdayPicker.Value);

            //    conn.Insert(birthday);


            //    BirthdayControl birthdayControl = new BirthdayControl(birthday.Name, birthday.Dateofbirth);
            //    birthdayControl.Location = new Point(x, y);
            //    y += birthdayControl.Height + 5;

            //    birthdaysPanel.Controls.Add(birthdayControl);
            //}

            using (MyApplicationContext context = new MyApplicationContext())
            {
                context.Contacts.Add(new Contact(0, nameTB.Text, numberTB.Text, birthdayPicker.Value));
                context.SaveChanges();

                BirthdayControl birthdayControl = new BirthdayControl(nameTB.Text, numberTB.Text, birthdayPicker.Value);
                birthdayControl.Location = new Point(x, y);
                y += birthdayControl.Height + 5;

                birthdaysPanel.Controls.Add(birthdayControl);
            }
        }
    }
}
