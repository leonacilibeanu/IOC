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
    public partial class EventAdmin : Form
    {
        public GuestsList guestsList;
        public PresentsList presentsList;
        public String eventName;

        public EventAdmin()
        {
            InitializeComponent();
        }

        public EventAdmin(String eventName)
        {
            this.eventName = eventName;
            InitializeComponent();
        }

        private void EventAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client.currentEvent = this.eventName;
            guestsList = new GuestsList(this.eventName);
            guestsList.Owner = this;
            this.Hide();
            guestsList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presentsList = new PresentsList();
            presentsList.Owner = this;
            this.Hide();
            presentsList.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
