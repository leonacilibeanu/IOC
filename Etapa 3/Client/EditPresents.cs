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
    public partial class EditPresents : Form
    {
        public String name;
        public String priority;

        public EditPresents(String name, String priority)
        {
            InitializeComponent();
            this.name = name;
            this.priority = priority;

            textBox1.Text = priority;
            textBox2.Text = name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 
        }
    }
}
