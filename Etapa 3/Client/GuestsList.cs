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
    public partial class GuestsList : Form
    {
        String eventName;

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

            ViewOwnProfile viewOwnProfile = new ViewOwnProfile(id, eventName);
            viewOwnProfile.Owner = this;
            viewOwnProfile.Show();
        }

        public GuestsList()
        {
            InitializeComponent();
        }

        public GuestsList(String eventName)
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
            this.Owner.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindFriend findFriend = new FindFriend(this.eventName);
            findFriend.Owner = this;
           // this.Dispose();
            findFriend.Show();
           
        }

        private void presentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentsList presentsList = new PresentsList();
            presentsList.Owner = this.Owner;
            presentsList.Show();

            this.Dispose();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventList eventList = new EventList();
            eventList.Owner = this.Owner.Owner;
            eventList.Show();

            this.Dispose();
        }

        private void guestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
