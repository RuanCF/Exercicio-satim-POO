using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lista_5.Exercicios_2
{
    public partial class Triangulo : Form
    {
        double valor_primario, valor_secundario, area_triangulo;
        public Triangulo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor_primario = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            valor_secundario = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            area_triangulo = (valor_primario * valor_secundario) / 2;
            label4.Text = area_triangulo.ToString("F2", CultureInfo.InvariantCulture);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }

    }
}
