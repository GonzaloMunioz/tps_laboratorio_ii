
namespace MiEstetica
{
    partial class frmComprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprar));
            this.lblSeleccioneProducto = new System.Windows.Forms.Label();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccioneProducto
            // 
            this.lblSeleccioneProducto.AutoSize = true;
            this.lblSeleccioneProducto.Location = new System.Drawing.Point(12, 20);
            this.lblSeleccioneProducto.Name = "lblSeleccioneProducto";
            this.lblSeleccioneProducto.Size = new System.Drawing.Size(225, 17);
            this.lblSeleccioneProducto.TabIndex = 0;
            this.lblSeleccioneProducto.Text = "Seleccione un producto";
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.ItemHeight = 16;
            this.lbProductos.Location = new System.Drawing.Point(12, 40);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(378, 164);
            this.lbProductos.TabIndex = 0;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 219);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(197, 17);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Ingrese una cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(12, 239);
            this.tbCantidad.MaxLength = 10;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(197, 24);
            this.tbCantidad.TabIndex = 1;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.Image = ((System.Drawing.Image)(resources.GetObject("btnComprar.Image")));
            this.btnComprar.Location = new System.Drawing.Point(12, 283);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(171, 24);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(331, 219);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(59, 17);
            this.lblCosto.TabIndex = 4;
            this.lblCosto.Text = "Costo";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCostoTotal.Location = new System.Drawing.Point(219, 239);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(171, 24);
            this.lblCostoTotal.TabIndex = 5;
            this.lblCostoTotal.Text = "$ 0";
            this.lblCostoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnCalcularCosto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularCosto.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularCosto.Image")));
            this.btnCalcularCosto.Location = new System.Drawing.Point(219, 283);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(171, 24);
            this.btnCalcularCosto.TabIndex = 6;
            this.btnCalcularCosto.Text = "Calcular costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = false;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // frmComprar
            // 
            this.AcceptButton = this.btnComprar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(402, 319);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.lblSeleccioneProducto);
            this.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEAUTY LIFE";
            this.Load += new System.EventHandler(this.frmComprar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccioneProducto;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Button btnCalcularCosto;
    }
}