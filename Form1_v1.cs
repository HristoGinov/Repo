using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                
                label4.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                comboBox2.Visible = true;

            }
            else
            {
                label4.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                comboBox2.Visible = false;

            }
                

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
