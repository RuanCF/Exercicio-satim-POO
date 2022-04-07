using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lista_5
{
    public partial class Exercicio_1 : Form
    {
        int codigo_funcionario, horas_trabalhadas;
        double salario_hora, salario_dia;

        private void button1_Click(object sender, EventArgs e)
        {
            codigo_funcionario = int.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            horas_trabalhadas = int.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            salario_hora = double.Parse(textBox3.Text, CultureInfo.InvariantCulture);
            salario_dia = (salario_hora * horas_trabalhadas) * 30;

            label4.Text = salario_dia.ToString("F2", CultureInfo.InvariantCulture);
        }

        public Exercicio_1()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //limpar
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";
        }
    }
}
