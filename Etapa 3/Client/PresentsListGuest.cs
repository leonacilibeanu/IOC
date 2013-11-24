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
    public partial class PresentsListGuest : Form
    {
        public bool itemDoubleClicked = false;
        public String eventName;

        public PresentsListGuest(String eventName)
        {
            this.eventName = eventName;
            InitializeComponent();
            InitializeListView();
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

            EditPresentsGuest editPresentsGuest = new EditPresentsGuest();
           // editPresentsGuest.Owner = this;
            editPresentsGuest.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void groupStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestsListGuest guestListGuest = new GuestsListGuest(eventName);
            guestListGuest.Owner = this;
            guestListGuest.Show();

            this.Hide();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner.Owner.Show();

            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
