using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediciones_eléctricas
{
    public partial class Voltaje : Form
    {
        public Voltaje()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int r, i, v;
            r = int.Parse(textBox1.Text);
            i = int.Parse(textBox2.Text);
            v = (r * i);
            label4.Text = v + " volts";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu openForms = new Menu();
            openForms.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Corriente openForms = new Corriente();
            openForms.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resistencia openForms = new Resistencia();
            openForms.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "0";
        }
    }
}
