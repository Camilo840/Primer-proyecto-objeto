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
    public partial class FrmSueldo : Form
    {
        public FrmSueldo()
        {
            InitializeComponent();
        }

        private void FrmSueldo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //validaciones
            if (this.txtnombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar el nombre..");
                this.txtnombre.Focus(); // ubica el cursor en un control
                return; //abandonar

            }
            //sumar los ingresos
            double horasTrab = double.Parse(this.txthora.Text);
            double valorHora = double.Parse(this.txtvalorh.Text);
            double bono = double.Parse(this.txtbono.Text);
            double totIng = horasTrab * valorHora + bono;
            this.txttotalingreso.Text = totIng.ToString();
            //suma de los ingresos
            double aso = double.Parse(this.txtaso.Text);
            double bar = double.Parse(this.txtbar.Text);
            double pagar = double.Parse(this.txtcuentaporpagar.Text);
            double totEgr = aso + bar + pagar;
            this.txttotalegresos.Text = totEgr.ToString();

            double liquidorecibir = totIng - totEgr;
            label.Text = "Estimado," + this.txtnombre.Text + ", tu sueldo es :" + liquidorecibir.ToString();



        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
