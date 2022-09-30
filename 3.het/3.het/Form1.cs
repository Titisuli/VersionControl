using _3.het.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.het
{
    public partial class Form1 : Form
    {
        BindingList<User> user = new BindingList<User>(); 
        public Form1()
        {
            InitializeComponent();
            lbLastName.Text = Resource.LastName;
            lbFirstName.Text = Resource.FirstName;
            btnadd.Text = Resource.Add;

            listUsers.DataSource = user;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
            };
            user.Add(u);
        }
    }
}
