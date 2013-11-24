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
    public partial class EventGuest : Form
    {
        public String eventName;

        public EventGuest(String eventName)
        {
            InitializeComponent();
            this.eventName = eventName;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PresentsListGuest presentsListGuest = new PresentsListGuest(eventName);
            this.Hide();

            presentsListGuest.Owner = this;
            presentsListGuest.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuestsListGuest guestsListGuest = new GuestsListGuest(eventName);
            this.Hide();

            guestsListGuest.Owner = this;
            guestsListGuest.Show();
        }
    }
}
