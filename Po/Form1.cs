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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void замовникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            customersForm customersform = new customersForm();
            customersform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoftwareForm softwareForm = new SoftwareForm();
            softwareForm.Show();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void виробникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProducerForm producerForm = new ProducerForm();
            producerForm.Show();
        }

        private void техХарактеристикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpecForm specForm = new SpecForm();
            specForm.Show();
        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
