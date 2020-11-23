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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
if(EsPrimo(2)==true)
            {
                MessageBox.Show("Es primo." + txtresultado.Text);
            }
else
            {
                MessageBox.Show("No es primo" + txtresultado.Text);
            }
           
        }

        static bool EsPrimo(int num )
        {
            bool primo = true;
            int i = 2;
            while (i <= num / 2 && primo == true)
            {
                if (num % i == 0)
                    primo = false;
                i++;
            }
        }
    }

}
