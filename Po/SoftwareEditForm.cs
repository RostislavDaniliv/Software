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
    public partial class SoftwareEditForm : Form
    {
        public SoftwareEditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SoftwareForm softwareForm = new SoftwareForm();
            softwareForm.Show();
        }
    }
}
