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
    public partial class Primo : Form
    {
        public Primo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtnumero.Text);
            if (esPrimo(num))

                this.txtresultado.Text = "Es primo";
            else
                this.txtresultado.Text = "No es primo";
            
        }
        bool esPrimo(int numero)
        {
            bool primo = true;
            for (int k = 2; k < numero / 2; k++)
            {
                if (numero % k == 0)
                {
                    primo = false;
                    break;
                }
            }
            return primo;
        }
    }
}
