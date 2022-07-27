
namespace MiEstetica
{
    partial class frmVender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVender));
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.lblSeleccioneCliente = new System.Windows.Forms.Label();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.lblSeleccioneProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnCalcularPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularPrecio.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularPrecio.Image")));
            this.btnCalcularPrecio.Location = new System.Drawing.Point(295, 488);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(245, 24);
            this.btnCalcularPrecio.TabIndex = 14;
            this.btnCalcularPrecio.Text = "Calcular precio";
            this.btnCalcularPrecio.UseVisualStyleBackColor = false;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecioTotal.Location = new System.Drawing.Point(317, 444);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(223, 24);
            this.lblPrecioTotal.TabIndex = 13;
            this.lblPrecioTotal.Text = "$ 0";
            this.lblPrecioTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(474, 424);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(66, 17);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.Image = ((System.Drawing.Image)(resources.GetObject("btnVender.Image")));
            this.btnVender.Location = new System.Drawing.Point(12, 488);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(247, 24);
            this.btnVender.TabIndex = 10;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(12, 444);
            this.tbCantidad.MaxLength = 10;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(247, 24);
            this.tbCantidad.TabIndex = 9;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 424);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(197, 17);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Ingrese una cantidad";
            // 
            // lbClientes
            // 
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.ItemHeight = 16;
            this.lbClientes.Location = new System.Drawing.Point(12, 36);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(528, 164);
            this.lbClientes.TabIndex = 7;
            // 
            // lblSeleccioneCliente
            // 
            this.lblSeleccioneCliente.AutoSize = true;
            this.lblSeleccioneCliente.Location = new System.Drawing.Point(12, 16);
            this.lblSeleccioneCliente.Name = "lblSeleccioneCliente";
            this.lblSeleccioneCliente.Size = new System.Drawing.Size(209, 17);
            this.lblSeleccioneCliente.TabIndex = 8;
            this.lblSeleccioneCliente.Text = "Seleccione un cliente";
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.ItemHeight = 16;
            this.lbProductos.Location = new System.Drawing.Point(12, 237);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(528, 164);
            this.lbProductos.TabIndex = 15;
            // 
            // lblSeleccioneProducto
            // 
            this.lblSeleccioneProducto.AutoSize = true;
            this.lblSeleccioneProducto.Location = new System.Drawing.Point(12, 217);
            this.lblSeleccioneProducto.Name = "lblSeleccioneProducto";
            this.lblSeleccioneProducto.Size = new System.Drawing.Size(225, 17);
            this.lblSeleccioneProducto.TabIndex = 16;
            this.lblSeleccioneProducto.Text = "Seleccione un producto";
            // 
            // frmVender
            // 
            this.AcceptButton = this.btnVender;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(552, 535);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.lblSeleccioneProducto);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.lblSeleccioneCliente);
            this.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEAUTY LIFE";
            this.Load += new System.EventHandler(this.frmVender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.Label lblSeleccioneCliente;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.Label lblSeleccioneProducto;
    }
}