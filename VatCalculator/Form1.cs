using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            double amount;
            double vat;
            double total;
            amount = double.Parse(textBox1.Text);
            vat = 15 * amount / 100;
            total = amount + vat;
            textBox2.Text = vat.ToString();
            textBox3.Text = total.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
