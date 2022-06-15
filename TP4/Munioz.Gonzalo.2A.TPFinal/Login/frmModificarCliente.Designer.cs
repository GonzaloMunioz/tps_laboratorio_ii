
namespace MiEstetica
{
    partial class frmModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCliente));
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.dtpTurno = new System.Windows.Forms.DateTimePicker();
            this.lblTurno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rtbCliente = new System.Windows.Forms.RichTextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(349, 260);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(175, 24);
            this.btnModificar.TabIndex = 56;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(641, 134);
            this.tbDireccion.MaxLength = 150;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.PlaceholderText = "Ingrese la dirección";
            this.tbDireccion.Size = new System.Drawing.Size(261, 24);
            this.tbDireccion.TabIndex = 54;
            this.tbDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDireccion_KeyPress);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(349, 134);
            this.tbDNI.MaxLength = 8;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.PlaceholderText = "Ingrese el D.N.I. (sin puntos)";
            this.tbDNI.Size = new System.Drawing.Size(261, 24);
            this.tbDNI.TabIndex = 53;
            this.tbDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDNI_KeyPress);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(641, 61);
            this.tbApellido.MaxLength = 150;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.PlaceholderText = "Ingrese el apellido";
            this.tbApellido.Size = new System.Drawing.Size(261, 24);
            this.tbApellido.TabIndex = 52;
            this.tbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellido_KeyPress);
            // 
            // dtpTurno
            // 
            this.dtpTurno.Location = new System.Drawing.Point(349, 205);
            this.dtpTurno.Name = "dtpTurno";
            this.dtpTurno.Size = new System.Drawing.Size(553, 24);
            this.dtpTurno.TabIndex = 55;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(349, 185);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(70, 17);
            this.lblTurno.TabIndex = 61;
            this.lblTurno.Text = "Turno ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Dirección";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(349, 114);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(36, 17);
            this.lblDNI.TabIndex = 59;
            this.lblDNI.Text = "D.N.I.";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(637, 41);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(88, 17);
            this.lblApellido.TabIndex = 58;
            this.lblApellido.Text = "Apellido";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(349, 61);
            this.tbNombre.MaxLength = 150;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PlaceholderText = "Ingrese el nombre";
            this.tbNombre.Size = new System.Drawing.Size(261, 24);
            this.tbNombre.TabIndex = 51;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(349, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 17);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "Nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(539, 260);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 24);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(727, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(175, 24);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rtbCliente
            // 
            this.rtbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.rtbCliente.Font = new System.Drawing.Font("Ablation Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbCliente.Location = new System.Drawing.Point(12, 41);
            this.rtbCliente.Name = "rtbCliente";
            this.rtbCliente.ReadOnly = true;
            this.rtbCliente.Size = new System.Drawing.Size(331, 245);
            this.rtbCliente.TabIndex = 64;
            this.rtbCliente.Text = "";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 21);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(77, 17);
            this.lblCliente.TabIndex = 65;
            this.lblCliente.Text = "Cliente";
            // 
            // frmModificarCliente
            // 
            this.AcceptButton = this.btnModificar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(914, 298);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.rtbCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.dtpTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEAUTY LIFE";
            this.Load += new System.EventHandler(this.frmModificarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.DateTimePicker dtpTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox rtbCliente;
        private System.Windows.Forms.Label lblCliente;
    }
}