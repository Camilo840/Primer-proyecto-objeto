namespace Primer_proyecto_objeto
{
    partial class FrmSueldo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttotalegresos = new System.Windows.Forms.TextBox();
            this.txtcuentaporpagar = new System.Windows.Forms.TextBox();
            this.txtaso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttotalingreso = new System.Windows.Forms.TextBox();
            this.txtbono = new System.Windows.Forms.TextBox();
            this.txtvalorh = new System.Windows.Forms.TextBox();
            this.txthora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sueldo del trabajador.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttotalegresos);
            this.groupBox1.Controls.Add(this.txtcuentaporpagar);
            this.groupBox1.Controls.Add(this.txtaso);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(385, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Egreso";
            // 
            // txttotalegresos
            // 
            this.txttotalegresos.Location = new System.Drawing.Point(132, 144);
            this.txttotalegresos.Name = "txttotalegresos";
            this.txttotalegresos.ReadOnly = true;
            this.txttotalegresos.Size = new System.Drawing.Size(109, 20);
            this.txttotalegresos.TabIndex = 12;
            this.txttotalegresos.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtcuentaporpagar
            // 
            this.txtcuentaporpagar.Location = new System.Drawing.Point(132, 107);
            this.txtcuentaporpagar.Name = "txtcuentaporpagar";
            this.txtcuentaporpagar.Size = new System.Drawing.Size(109, 20);
            this.txtcuentaporpagar.TabIndex = 13;
            this.txtcuentaporpagar.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtaso
            // 
            this.txtaso.Location = new System.Drawing.Point(132, 26);
            this.txtaso.Name = "txtaso";
            this.txtaso.Size = new System.Drawing.Size(109, 20);
            this.txtaso.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "TOTAL DE EGRESOS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtbar
            // 
            this.txtbar.Location = new System.Drawing.Point(132, 68);
            this.txtbar.Name = "txtbar";
            this.txtbar.Size = new System.Drawing.Size(109, 20);
            this.txtbar.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cuenta por pagar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Bar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Aso de trabajadores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttotalingreso);
            this.groupBox2.Controls.Add(this.txtbono);
            this.groupBox2.Controls.Add(this.txtvalorh);
            this.groupBox2.Controls.Add(this.txthora);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(37, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 188);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txttotalingreso
            // 
            this.txttotalingreso.Location = new System.Drawing.Point(152, 135);
            this.txttotalingreso.Name = "txttotalingreso";
            this.txttotalingreso.ReadOnly = true;
            this.txttotalingreso.Size = new System.Drawing.Size(100, 20);
            this.txttotalingreso.TabIndex = 13;
            // 
            // txtbono
            // 
            this.txtbono.Location = new System.Drawing.Point(152, 102);
            this.txtbono.Name = "txtbono";
            this.txtbono.Size = new System.Drawing.Size(109, 20);
            this.txtbono.TabIndex = 12;
            // 
            // txtvalorh
            // 
            this.txtvalorh.Location = new System.Drawing.Point(152, 66);
            this.txtvalorh.Name = "txtvalorh";
            this.txtvalorh.Size = new System.Drawing.Size(109, 20);
            this.txtvalorh.TabIndex = 11;
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(152, 27);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(109, 20);
            this.txthora.TabIndex = 10;
            this.txthora.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "TOTAL DE INGRESOS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bono de responsabilidad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor por hora";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Horas trabajadas";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(189, 45);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(245, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del trabajador :";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(257, 320);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(75, 293);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 8;
            this.label.Click += new System.EventHandler(this.label11_Click);
            // 
            // FrmSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmSueldo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSueldo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvalorh;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.TextBox txttotalingreso;
        private System.Windows.Forms.TextBox txtbono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtaso;
        private System.Windows.Forms.TextBox txtbar;
        private System.Windows.Forms.TextBox txttotalegresos;
        private System.Windows.Forms.TextBox txtcuentaporpagar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label;
    }
}

