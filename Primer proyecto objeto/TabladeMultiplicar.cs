using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_proyecto_objeto
{
    public partial class TabladeMultiplicar : Form
    {
        public TabladeMultiplicar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int tabla = int.Parse(textBox1.Text);
            int limite = int.Parse(textBox2.Text);
            int resultado;
            for (int i =1; i<=limite;i++)
            {
                resultado = tabla * i;
                listBox1.Items.Add(tabla + "x" + i + "=" + resultado);
            }



        }

        private void TabladeMultiplicar_Load(object sender, EventArgs e)
        {

        }
    }
}
