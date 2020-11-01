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
    public partial class SoftwareForm : Form
    {
        public SoftwareForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SoftwareAddForm softwareAddForm = new SoftwareAddForm();
            softwareAddForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            SoftwareEditForm softwareEditForm = new SoftwareEditForm();
            softwareEditForm.Show();
        }
    }
}
