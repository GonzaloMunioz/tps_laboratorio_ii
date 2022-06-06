
namespace MiEstetica
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseniaRepetir = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseniaRepetir = new System.Windows.Forms.TextBox();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.tbCorreoElectronico = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 85);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(88, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(30, 147);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(78, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "usuario";
            // 
            // lblContraseniaRepetir
            // 
            this.lblContraseniaRepetir.AutoSize = true;
            this.lblContraseniaRepetir.Location = new System.Drawing.Point(30, 271);
            this.lblContraseniaRepetir.Name = "lblContraseniaRepetir";
            this.lblContraseniaRepetir.Size = new System.Drawing.Size(206, 17);
            this.lblContraseniaRepetir.TabIndex = 3;
            this.lblContraseniaRepetir.Text = "Repita su contraseña";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(28, 209);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(118, 17);
            this.lblContrasenia.TabIndex = 4;
            this.lblContrasenia.Text = "contraseña";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(28, 333);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(304, 17);
            this.lblCorreoElectronico.TabIndex = 5;
            this.lblCorreoElectronico.Text = "Dirección de correo electrónico";
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(28, 393);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(184, 17);
            this.lblFechaDeNacimiento.TabIndex = 6;
            this.lblFechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(30, 43);
            this.tbNombre.MaxLength = 150;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PlaceholderText = "Ingrese su nombre";
            this.tbNombre.Size = new System.Drawing.Size(436, 24);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(29, 413);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(441, 24);
            this.dtpFechaDeNacimiento.TabIndex = 6;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(30, 105);
            this.tbApellido.MaxLength = 150;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.PlaceholderText = "Ingrese su apellido";
            this.tbApellido.Size = new System.Drawing.Size(436, 24);
            this.tbApellido.TabIndex = 1;
            this.tbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellido_KeyPress);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(30, 167);
            this.tbUsuario.MaxLength = 150;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.PlaceholderText = "Ingrese su usuario";
            this.tbUsuario.Size = new System.Drawing.Size(436, 24);
            this.tbUsuario.TabIndex = 2;
            // 
            // tbContraseniaRepetir
            // 
            this.tbContraseniaRepetir.Location = new System.Drawing.Point(30, 291);
            this.tbContraseniaRepetir.MaxLength = 150;
            this.tbContraseniaRepetir.Name = "tbContraseniaRepetir";
            this.tbContraseniaRepetir.PasswordChar = '*';
            this.tbContraseniaRepetir.PlaceholderText = "Reingrese su contraseña";
            this.tbContraseniaRepetir.Size = new System.Drawing.Size(436, 24);
            this.tbContraseniaRepetir.TabIndex = 4;
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(29, 229);
            this.tbContrasenia.MaxLength = 150;
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.PasswordChar = '*';
            this.tbContrasenia.PlaceholderText = "Ingrese su contraseña";
            this.tbContrasenia.Size = new System.Drawing.Size(436, 24);
            this.tbContrasenia.TabIndex = 3;
            // 
            // tbCorreoElectronico
            // 
            this.tbCorreoElectronico.Location = new System.Drawing.Point(30, 353);
            this.tbCorreoElectronico.MaxLength = 150;
            this.tbCorreoElectronico.Name = "tbCorreoElectronico";
            this.tbCorreoElectronico.PlaceholderText = "Ingrese su dirección de correo electrónico";
            this.tbCorreoElectronico.Size = new System.Drawing.Size(436, 24);
            this.tbCorreoElectronico.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(173, 460);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmRegistro
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(499, 495);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbCorreoElectronico);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.tbContraseniaRepetir);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.dtpFechaDeNacimiento);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblFechaDeNacimiento);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblContraseniaRepetir);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEAUTY LIFE";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseniaRepetir;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseniaRepetir;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.TextBox tbCorreoElectronico;
        private System.Windows.Forms.Button btnAceptar;
    }
}

