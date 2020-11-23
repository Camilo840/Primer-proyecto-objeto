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
    public partial class frmmenupri : Form
    {
        public frmmenupri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            FrmSueldo frm1 = new FrmSueldo();
            frm1.ShowDialog();
        }
    }
}
