
namespace MiEstetica
{
    partial class frmBuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarCliente));
            this.rtbListaClientes = new System.Windows.Forms.RichTextBox();
            this.lblListadoClientes = new System.Windows.Forms.Label();
            this.lblIngreseID = new System.Windows.Forms.Label();
            this.tbIngreseID = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbListaClientes
            // 
            this.rtbListaClientes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rtbListaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.rtbListaClientes.Location = new System.Drawing.Point(12, 27);
            this.rtbListaClientes.Name = "rtbListaClientes";
            this.rtbListaClientes.ReadOnly = true;
            this.rtbListaClientes.Size = new System.Drawing.Size(302, 316);
            this.rtbListaClientes.TabIndex = 0;
            this.rtbListaClientes.Text = "";
            // 
            // lblListadoClientes
            // 
            this.lblListadoClientes.AutoSize = true;
            this.lblListadoClientes.Location = new System.Drawing.Point(73, 7);
            this.lblListadoClientes.Name = "lblListadoClientes";
            this.lblListadoClientes.Size = new System.Drawing.Size(184, 17);
            this.lblListadoClientes.TabIndex = 1;
            this.lblListadoClientes.Text = "Listado de clientes";
            // 
            // lblIngreseID
            // 
            this.lblIngreseID.AutoSize = true;
            this.lblIngreseID.Location = new System.Drawing.Point(351, 287);
            this.lblIngreseID.Name = "lblIngreseID";
            this.lblIngreseID.Size = new System.Drawing.Size(321, 17);
            this.lblIngreseID.TabIndex = 2;
            this.lblIngreseID.Text = "Ingrese el ID del cliente a buscar";
            // 
            // tbIngreseID
            // 
            this.tbIngreseID.Location = new System.Drawing.Point(351, 319);
            this.tbIngreseID.MaxLength = 6;
            this.tbIngreseID.Name = "tbIngreseID";
            this.tbIngreseID.PlaceholderText = "Ingrese el ID del cliente";
            this.tbIngreseID.Size = new System.Drawing.Size(233, 24);
            this.tbIngreseID.TabIndex = 3;
            this.tbIngreseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIngreseID_KeyPress);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(394, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(248, 253);
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Location = new System.Drawing.Point(590, 319);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 24);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmBuscarCliente
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(705, 355);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tbIngreseID);
            this.Controls.Add(this.lblIngreseID);
            this.Controls.Add(this.lblListadoClientes);
            this.Controls.Add(this.rtbListaClientes);
            this.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEAUTY LIFE";
            this.Load += new System.EventHandler(this.frmModificarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListaClientes;
        private System.Windows.Forms.Label lblListadoClientes;
        private System.Windows.Forms.Label lblIngreseID;
        private System.Windows.Forms.TextBox tbIngreseID;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnAceptar;
    }
}