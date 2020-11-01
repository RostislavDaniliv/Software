using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Po
{
    public partial class SpecForm : Form
    {
        public SpecForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SpecAddForm specAddForm = new SpecAddForm();
            specAddForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            SpecEditForm specEditForm = new SpecEditForm();
            specEditForm.Show();
        }
    }
}
