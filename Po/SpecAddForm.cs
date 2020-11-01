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
    public partial class SpecAddForm : Form
    {
        public SpecAddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SpecForm specForm = new SpecForm();
            specForm.Show();
        }
    }
}
