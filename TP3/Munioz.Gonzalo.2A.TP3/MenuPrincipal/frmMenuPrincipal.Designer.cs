
namespace MenuPrincipal
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblAgregarCliente = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblListarClientes = new System.Windows.Forms.Label();
            this.rtbInformacionGeneral = new System.Windows.Forms.RichTextBox();
            this.lblTotalRecaudado = new System.Windows.Forms.Label();
            this.lblVentasHoy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProxTurnos = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(382, -9);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(488, 112);
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // lblAgregarCliente
            // 
            this.lblAgregarCliente.AutoSize = true;
            this.lblAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAgregarCliente.Font = new System.Drawing.Font("Ablation Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarCliente.Location = new System.Drawing.Point(249, 116);
            this.lblAgregarCliente.Name = "lblAgregarCliente";
            this.lblAgregarCliente.Size = new System.Drawing.Size(174, 19);
            this.lblAgregarCliente.TabIndex = 0;
            this.lblAgregarCliente.Text = "agregar cliente";
            this.lblAgregarCliente.Click += new System.EventHandler(this.lblAgregarCliente_Click);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEntrada.Font = new System.Drawing.Font("Ablation Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEntrada.Location = new System.Drawing.Point(453, 116);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(94, 19);
            this.lblEntrada.TabIndex = 1;
            this.lblEntrada.Text = "Entrada";
            this.lblEntrada.Click += new System.EventHandler(this.lblEntrada_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalida.Font = new System.Drawing.Font("Ablation Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalida.Location = new System.Drawing.Point(586, 116);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(72, 19);
            this.lblSalida.TabIndex = 2;
            this.lblSalida.Text = "Salida";
            this.lblSalida.Click += new System.EventHandler(this.lblSalida_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductos.Font = new System.Drawing.Font("Ablation Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductos.Location = new System.Drawing.Point(698, 116);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(115, 19);
            this.lblProductos.TabIndex = 3;
            this.lblProductos.Text = "Productos";
            this.lblProductos.Click += new System.EventHandler(this.lblProductos_Click);
            // 
            // lblListarClientes
            // 
            this.lblListarClientes.AutoSize = true;
            this.lblListarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListarClientes.Font = new System.Drawing.Font("Ablation Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListarClientes.Location = new System.Drawing.Point(844, 116);
            this.lblListarClientes.Name = "lblListarClientes";
            this.lblListarClientes.Size = new System.Drawing.Size(163, 19);
            this.lblListarClientes.TabIndex = 4;
            this.lblListarClientes.Text = "Listar clientes";
            this.lblListarClientes.Click += new System.EventHandler(this.lblListarClientes_Click);
            // 
            // rtbInformacionGeneral
            // 
            this.rtbInformacionGeneral.Location = new System.Drawing.Point(12, 169);
            this.rtbInformacionGeneral.Name = "rtbInformacionGeneral";
            this.rtbInformacionGeneral.Size = new System.Drawing.Size(1240, 500);
            this.rtbInformacionGeneral.TabIndex = 6;
            this.rtbInformacionGeneral.Text = "";
            // 
            // lblTotalRecaudado
            // 
            this.lblTotalRecaudado.AutoSize = true;
            this.lblTotalRecaudado.Location = new System.Drawing.Point(440, 149);
            this.lblTotalRecaudado.Name = "lblTotalRecaudado";
            this.lblTotalRecaudado.Size = new System.Drawing.Size(154, 17);
            this.lblTotalRecaudado.TabIndex = 7;
            this.lblTotalRecaudado.Text = "Total recaudado";
            // 
            // lblVentasHoy
            // 
            this.lblVentasHoy.AutoSize = true;
            this.lblVentasHoy.Location = new System.Drawing.Point(700, 149);
            this.lblVentasHoy.Name = "lblVentasHoy";
            this.lblVentasHoy.Size = new System.Drawing.Size(135, 17);
            this.lblVentasHoy.TabIndex = 8;
            this.lblVentasHoy.Text = "Ventas de hoy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ablation Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.label8.Location = new System.Drawing.Point(209, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(838, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ablation Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.label9.Location = new System.Drawing.Point(310, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(640, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "______________________________________________________________________";
            // 
            // lblProxTurnos
            // 
            this.lblProxTurnos.AutoSize = true;
            this.lblProxTurnos.Location = new System.Drawing.Point(149, 149);
            this.lblProxTurnos.Name = "lblProxTurnos";
            this.lblProxTurnos.Size = new System.Drawing.Size(161, 17);
            this.lblProxTurnos.TabIndex = 11;
            this.lblProxTurnos.Text = "Proximos turnos";
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Location = new System.Drawing.Point(983, 149);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(138, 17);
            this.lblGastos.TabIndex = 12;
            this.lblGastos.Text = "Gastos del día";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.lblProxTurnos);
            this.Controls.Add(this.lblVentasHoy);
            this.Controls.Add(this.lblTotalRecaudado);
            this.Controls.Add(this.rtbInformacionGeneral);
            this.Controls.Add(this.lblListarClientes);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblAgregarCliente);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEAUTY LIFE";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblAgregarCliente;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblListarClientes;
        private System.Windows.Forms.RichTextBox rtbInformacionGeneral;
        private System.Windows.Forms.Label lblTotalRecaudado;
        private System.Windows.Forms.Label lblVentasHoy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProxTurnos;
        private System.Windows.Forms.Label lblGastos;
    }
}

