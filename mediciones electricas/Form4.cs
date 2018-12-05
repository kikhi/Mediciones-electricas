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
    public partial class Resistencia : Form
    {
        public Resistencia()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int v, r, i;
            v = int.Parse(textBox1.Text);
            i = int.Parse(textBox2.Text);
            r = (v / i);
            label4.Text = r + "ohmios";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu openForm = new Menu();
            openForm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Voltaje openForm = new Voltaje();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Corriente openForm = new Corriente();
            openForm.Show();
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
