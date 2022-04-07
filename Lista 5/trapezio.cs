using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lista_5.Exercicios_2
{
    public partial class trapezio : Form
    {
        double valor_primario, valor_secundario, valor_terciario, area_trapezio;

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";
        }

        public trapezio()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor_primario = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            valor_secundario = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            valor_terciario = double.Parse(textBox3.Text, CultureInfo.InvariantCulture);
            area_trapezio = (valor_primario + valor_secundario) * valor_terciario / 2;
            label4.Text = area_trapezio.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
