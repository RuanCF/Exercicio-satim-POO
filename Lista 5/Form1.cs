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
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            Exercicio_1 Exercicio_1_vrb = new Exercicio_1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Exercicio_1_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(Exercicio_1_vrb);
            Exercicio_1_vrb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            Exercicio_2 Exercicio_2_vrb = new Exercicio_2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Exercicio_2_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(Exercicio_2_vrb);
            Exercicio_2_vrb.Show();
        }
    }
}
