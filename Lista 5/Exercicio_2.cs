using Lista_5.Exercicios_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_5
{
    public partial class Exercicio_2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public Exercicio_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader2.Controls.Clear();
            Triangulo triangulo_vrb = new Triangulo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            triangulo_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader2.Controls.Add(triangulo_vrb);
            triangulo_vrb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader2.Controls.Clear();
            Circulo Circulo_vrb = new Circulo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Circulo_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader2.Controls.Add(Circulo_vrb);
            Circulo_vrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader2.Controls.Clear();
            trapezio Trapezio_vrb = new trapezio() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Trapezio_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader2.Controls.Add(Trapezio_vrb);
            Trapezio_vrb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader2.Controls.Clear();
            quadrado quadrado_vrb = new quadrado() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            quadrado_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader2.Controls.Add(quadrado_vrb);
            quadrado_vrb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader2.Controls.Clear();
            retangulo retangulo_vrb = new retangulo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            retangulo_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader2.Controls.Add(retangulo_vrb);
            retangulo_vrb.Show();
        }
    }
}
