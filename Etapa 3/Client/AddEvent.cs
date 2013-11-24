using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Messenger
{
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Client.currentUser);
            Client.addEvent(textBox1.Text, Client.currentUser, textBox3.Text, textBox4.Text, 1);
            EventAdmin eventAdmin = new EventAdmin(textBox1.Text);

            eventAdmin.Owner = this.Owner;
            this.Hide();
            eventAdmin.Show();
        }
    }
}
