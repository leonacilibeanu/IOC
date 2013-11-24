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
    public partial class GuestsListGuest : Form
    {
        public String eventName;
        public bool itemDoubleClicked = false;

        private void mouseDoubleClickedEvent(object sender, MouseEventArgs e)
        {
            ListViewItem theClickedOne = listView1.GetItemAt(e.X, e.Y);
            String id = "", status = "";
            itemDoubleClicked = true;

            String name = theClickedOne.Text.Split(' ')[0];
            Console.WriteLine(name);

            foreach (Friend f in Client.friends)
                if (f.name.Equals(name))
                {
                    id = f.id;
                    status = f.status;
                }

            Console.WriteLine(name);
            Client.currentEvent = name;
            // EventAdmin evAdmin = new EventAdmin(name);
            // evAdmin.Owner = this;
            //evAdmin.Show();
            ViewOwnProfile viewOwnProfile = new ViewOwnProfile(id, eventName);
            viewOwnProfile.Owner = this;
            viewOwnProfile.Show();
        }


        public GuestsListGuest(String eventName)
        {

            this.eventName = eventName;
            List<String> guestsList = Client.getGuests(eventName);
            Console.WriteLine(guestsList.ElementAt(0));

            InitializeComponent();

            listView1.View = View.Details;
            List<ListViewItem> items = new List<ListViewItem>();

            ColumnHeader columnHeader0 = new ColumnHeader();
            columnHeader0.Text = "Name";
            columnHeader0.Width = -1;

            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0 });

            ListViewGroup guests;

            guests = new ListViewGroup("Guests", HorizontalAlignment.Center);

            items.Add(new ListViewItem("ana", guests));

            foreach (String a in guestsList)
                items.Add(new ListViewItem(a, guests));

            listView1.Groups.Add(guests);

            listView1.Items.AddRange(items.ToArray());

            listView1.MouseDoubleClick += new MouseEventHandler(mouseDoubleClickedEvent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void presentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentsListGuest presentsListGuest = new PresentsListGuest(eventName);
            presentsListGuest.Owner = this.Owner;
            presentsListGuest.Show();

            this.Hide();
        }

        private void groupStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner.Owner.Show();
            this.Dispose();
        }
    }
}
