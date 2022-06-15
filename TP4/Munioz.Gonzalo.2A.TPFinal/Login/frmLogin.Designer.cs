
namespace MiEstetica
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblRegistrarNuevoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.Location = new System.Drawing.Point(184, 384);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(126, 27);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsuario.Font = new System.Drawing.Font("Ablation Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(50, 220);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 18);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.BackColor = System.Drawing.SystemColors.Window;
            this.lblContrasenia.Font = new System.Drawing.Font("Ablation Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContrasenia.Location = new System.Drawing.Point(50, 306);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(126, 18);
            this.lblContrasenia.TabIndex = 10;
            this.lblContrasenia.Text = "CONTRASEÑA";
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(50, 341);
            this.tbContrasenia.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tbContrasenia.MaxLength = 50;
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.PasswordChar = '*';
            this.tbContrasenia.PlaceholderText = "Ingrese su contraseña";
            this.tbContrasenia.Size = new System.Drawing.Size(401, 23);
            this.tbContrasenia.TabIndex = 1;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(50, 258);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tbUsuario.MaxLength = 50;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.PlaceholderText = "Ingrese su usuario";
            this.tbUsuario.Size = new System.Drawing.Size(401, 23);
            this.tbUsuario.TabIndex = 0;
            // 
            // lblRegistrarNuevoUsuario
            // 
            this.lblRegistrarNuevoUsuario.AutoSize = true;
            this.lblRegistrarNuevoUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.lblRegistrarNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrarNuevoUsuario.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistrarNuevoUsuario.Location = new System.Drawing.Point(132, 422);
            this.lblRegistrarNuevoUsuario.Name = "lblRegistrarNuevoUsuario";
            this.lblRegistrarNuevoUsuario.Size = new System.Drawing.Size(233, 17);
            this.lblRegistrarNuevoUsuario.TabIndex = 3;
            this.lblRegistrarNuevoUsuario.Text = "REGISTRAR NUEVO USUARIO";
            this.lblRegistrarNuevoUsuario.Click += new System.EventHandler(this.lblRegistrarNuevoUsuario_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(499, 453);
            this.Controls.Add(this.lblRegistrarNuevoUsuario);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Font = new System.Drawing.Font("Ablation Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEAUTY LIFE";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblRegistrarNuevoUsuario;
    }
}

