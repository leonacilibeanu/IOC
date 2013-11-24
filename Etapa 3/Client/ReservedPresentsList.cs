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
    public partial class ReservedPresentsList : Form
    {
        public ReservedPresentsList()
        {
            InitializeComponent();
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

            events = new ListViewGroup("Reserved Presents", HorizontalAlignment.Center); // pun numele grupului

            items.Add(new ListViewItem("1.  Tableta", events));

            listView1.Groups.Add(events);

            listView1.Items.AddRange(items.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Owner.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
