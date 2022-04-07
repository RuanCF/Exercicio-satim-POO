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
    public partial class retangulo : Form
    {
        double valor_primario, valor_secundario, area_retangulo;

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }

        public retangulo()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            valor_primario = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            valor_secundario = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            area_retangulo = valor_primario * valor_secundario;
            label4.Text = area_retangulo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
