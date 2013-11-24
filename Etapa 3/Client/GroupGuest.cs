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
    public partial class GroupGuest : Form
    {
        public GroupGuest()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReservedPresentsList reservedPresentsList = new ReservedPresentsList();
            reservedPresentsList.Owner = this;
            reservedPresentsList.Show();
        }
    }
}
