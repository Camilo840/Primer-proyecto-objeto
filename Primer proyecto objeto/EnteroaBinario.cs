﻿using System;
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
    public partial class EnteroaBinario : Form
    {
        public EnteroaBinario()
        {
            InitializeComponent();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo: validar que sean numericos.
            //validar  que esté en el rango de 0 a 255.
            int num = Int32.Parse(this.txtnumero.Text);
            if(!(num>=0 && num<=255))
                {
                MessageBox.Show("Tu numero debe estar en el rango 0...255");
                this.txtnumero.Focus();
                return;
            }
            encerar();
            numeroBinario(num);
        } //fin botón Calcular.
        void encerar()
        {
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.checkBox7.Checked = false;
            this.checkBox8.Checked = false;

        }
        void numeroBinario(int num)
        {
            //bucle para transformar el numero en binario.
            int cont = 9;

            while (num > 0)
            {
                int residuo = num % 2;
                cont--;
                if (cont == 8)
                    this.checkBox8.Checked = residuo == 0 ? false : true;
                else if (cont == 7)
                    this.checkBox7.Checked = residuo == 0 ? false : true;
                else if (cont == 6)
                    this.checkBox6.Checked = residuo == 0 ? false : true;
                else if (cont == 5)
                    this.checkBox5.Checked = residuo == 0 ? false : true;
                else if (cont == 4)
                    this.checkBox4.Checked = residuo == 0 ? false : true;
                else if (cont == 3)
                    this.checkBox3.Checked = residuo == 0 ? false : true;
                else if (cont == 2)
                    this.checkBox2.Checked = residuo == 0 ? false : true;
                else if (cont == 1)
                    this.checkBox1.Checked = residuo == 0 ? false : true;
                num = num / 2;
            }
        }
    }
}
