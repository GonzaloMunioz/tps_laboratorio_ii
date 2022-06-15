
namespace MiEstetica
{
    partial class frmMenuProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuProductos));
            this.lblMarca = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rtbListaProductos = new System.Windows.Forms.RichTextBox();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(350, 43);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 17);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(347, 63);
            this.tbMarca.MaxLength = 50;
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.PlaceholderText = "Ingrese la marca del producto";
            this.tbMarca.Size = new System.Drawing.Size(292, 24);
            this.tbMarca.TabIndex = 0;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(347, 122);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(66, 17);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(350, 199);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(112, 17);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(347, 142);
            this.tbPrecio.MaxLength = 10;
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.PlaceholderText = "Ingrese el precio del producto";
            this.tbPrecio.Size = new System.Drawing.Size(292, 24);
            this.tbPrecio.TabIndex = 1;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecio_KeyPress);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(350, 218);
            this.tbDescripcion.MaxLength = 50;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.PlaceholderText = "Ingrese una breve descripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(292, 24);
            this.tbDescripcion.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(677, 217);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 24);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(677, 63);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 24);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rtbListaProductos
            // 
            this.rtbListaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.rtbListaProductos.Location = new System.Drawing.Point(12, 43);
            this.rtbListaProductos.Name = "rtbListaProductos";
            this.rtbListaProductos.ReadOnly = true;
            this.rtbListaProductos.Size = new System.Drawing.Size(329, 200);
            this.rtbListaProductos.TabIndex = 6;
            this.rtbListaProductos.Text = "";
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.Location = new System.Drawing.Point(13, 22);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(103, 17);
            this.lblListaProductos.TabIndex = 7;
            this.lblListaProductos.Text = "Productos";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.Image = ((System.Drawing.Image)(resources.GetObject("btnComprar.Image")));
            this.btnComprar.Location = new System.Drawing.Point(677, 118);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(138, 24);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.Image = ((System.Drawing.Image)(resources.GetObject("btnVender.Image")));
            this.btnVender.Location = new System.Drawing.Point(677, 170);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(138, 24);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // frmMenuProductos
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(827, 255);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.rtbListaProductos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lblMarca);
            this.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEAUTY LIFE";
            this.Load += new System.EventHandler(this.frmMenuProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RichTextBox rtbListaProductos;
        private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnVender;
    }
}