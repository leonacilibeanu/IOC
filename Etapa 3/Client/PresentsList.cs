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
    public partial class PresentsList : Form
    {
        bool itemDoubleClicked = false;
        public PresentsList()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void mouseDoubleClickedEvent(object sender, MouseEventArgs e)
        {
            int length;
            ListViewItem theClickedOne = listView1.GetItemAt(e.X, e.Y);
            itemDoubleClicked = true;

            String name = theClickedOne.Text.Split(' ')[2];
            length = theClickedOne.Text.Split(' ')[0].Length - 1;
            String priority = theClickedOne.Text.Split(' ')[0].Substring(0, length);

            Console.WriteLine(name);
            Console.WriteLine(priority);

            EditPresents editPresent = new EditPresents(name, priority);
            editPresent.Owner = this;
            editPresent.Show();
        }

        public void InitializeListView()
        {
            listView1.View = View.Details;

            List<ListViewItem> items = new List<ListViewItem>();

            ColumnHeader columnHeader0 = new ColumnHeader();
            columnHeader0.Text = "Name";
            columnHeader0.Width = -1;

            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0 });

            ListViewGroup events;

            events = new ListViewGroup("Presents", HorizontalAlignment.Center); // pun numele grupului

            items.Add(new ListViewItem("1.  Tableta", events));
            items.Add(new ListViewItem("2.  Frigider", events));
            items.Add(new ListViewItem("3.  Mixer", events));

            listView1.Groups.Add(events);

            listView1.Items.AddRange(items.ToArray());

            listView1.MouseDoubleClick += new MouseEventHandler(mouseDoubleClickedEvent);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestsList guestList = new GuestsList();
            guestList.Owner = this.Owner;
            guestList.Show();

            this.Dispose();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventList eventList = new EventList();
            eventList.Owner = this.Owner.Owner;
            eventList.Show();

            this.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           //TODO SIGN OU
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }
    }
}
