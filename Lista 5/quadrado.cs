using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_5.Exercicios_2
{
    public partial class quadrado : Form
    {
        double valor_primario, area_quadrado;
        public quadrado()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor_primario = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            area_quadrado = valor_primario * valor_primario;
            label4.Text = area_quadrado.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
