using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Suma(int n)
        {
            if (n <= 1)
                return n;
            else
                return n + Suma(n - 1);//recursión
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumero.Text);
            int resultado = Suma(n);
            label2.Text = resultado.ToString();
        }
    }
}
