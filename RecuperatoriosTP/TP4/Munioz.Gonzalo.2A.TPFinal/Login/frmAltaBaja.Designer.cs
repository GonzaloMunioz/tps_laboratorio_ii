
namespace MiEstetica
{
    partial class frmAltaBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaBaja));
            this.lblClientesActivos = new System.Windows.Forms.Label();
            this.lblClientesInactivos = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.rtbClientesActivos = new System.Windows.Forms.RichTextBox();
            this.rtbClientesInactivos = new System.Windows.Forms.RichTextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.tbIDBaja = new System.Windows.Forms.TextBox();
            this.tbIDAlta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClientesActivos
            // 
            this.lblClientesActivos.AutoSize = true;
            this.lblClientesActivos.Location = new System.Drawing.Point(12, 30);
            this.lblClientesActivos.Name = "lblClientesActivos";
            this.lblClientesActivos.Size = new System.Drawing.Size(287, 17);
            this.lblClientesActivos.TabIndex = 2;
            this.lblClientesActivos.Text = "Clientes activos (dados de alta)";
            // 
            // lblClientesInactivos
            // 
            this.lblClientesInactivos.AutoSize = true;
            this.lblClientesInactivos.Location = new System.Drawing.Point(622, 30);
            this.lblClientesInactivos.Name = "lblClientesInactivos";
            this.lblClientesInactivos.Size = new System.Drawing.Size(304, 17);
            this.lblClientesInactivos.TabIndex = 3;
            this.lblClientesInactivos.Text = "Clientes inactivos (dados de baja)";
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaja.Image = ((System.Drawing.Image)(resources.GetObject("btnBaja.Image")));
            this.btnBaja.Location = new System.Drawing.Point(405, 380);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(171, 24);
            this.btnBaja.TabIndex = 5;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // rtbClientesActivos
            // 
            this.rtbClientesActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.rtbClientesActivos.Location = new System.Drawing.Point(12, 50);
            this.rtbClientesActivos.Name = "rtbClientesActivos";
            this.rtbClientesActivos.ReadOnly = true;
            this.rtbClientesActivos.Size = new System.Drawing.Size(564, 324);
            this.rtbClientesActivos.TabIndex = 6;
            this.rtbClientesActivos.Text = "";
            // 
            // rtbClientesInactivos
            // 
            this.rtbClientesInactivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.rtbClientesInactivos.Location = new System.Drawing.Point(622, 50);
            this.rtbClientesInactivos.Name = "rtbClientesInactivos";
            this.rtbClientesInactivos.ReadOnly = true;
            this.rtbClientesInactivos.Size = new System.Drawing.Size(564, 324);
            this.rtbClientesInactivos.TabIndex = 7;
            this.rtbClientesInactivos.Text = "";
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlta.Image = ((System.Drawing.Image)(resources.GetObject("btnAlta.Image")));
            this.btnAlta.Location = new System.Drawing.Point(1015, 380);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(171, 24);
            this.btnAlta.TabIndex = 8;
            this.btnAlta.Text = "Dar de alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // tbIDBaja
            // 
            this.tbIDBaja.Location = new System.Drawing.Point(12, 379);
            this.tbIDBaja.MaxLength = 10;
            this.tbIDBaja.Name = "tbIDBaja";
            this.tbIDBaja.PlaceholderText = "Ingrese el ID del cliente a dar de baja";
            this.tbIDBaja.Size = new System.Drawing.Size(367, 24);
            this.tbIDBaja.TabIndex = 9;
            this.tbIDBaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIDBaja_KeyPress);
            // 
            // tbIDAlta
            // 
            this.tbIDAlta.Location = new System.Drawing.Point(622, 380);
            this.tbIDAlta.Name = "tbIDAlta";
            this.tbIDAlta.PlaceholderText = "Ingrese el ID del cliente a dar de alta";
            this.tbIDAlta.Size = new System.Drawing.Size(367, 24);
            this.tbIDAlta.TabIndex = 10;
            this.tbIDAlta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIDAlta_KeyPress);
            // 
            // frmAltaBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1196, 415);
            this.Controls.Add(this.tbIDAlta);
            this.Controls.Add(this.tbIDBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.rtbClientesInactivos);
            this.Controls.Add(this.rtbClientesActivos);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.lblClientesInactivos);
            this.Controls.Add(this.lblClientesActivos);
            this.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEAUTY LIFE";
            this.Load += new System.EventHandler(this.frmAltaBaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClientesActivos;
        private System.Windows.Forms.Label lblClientesInactivos;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.RichTextBox rtbClientesActivos;
        private System.Windows.Forms.RichTextBox rtbClientesInactivos;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox tbIDBaja;
        private System.Windows.Forms.TextBox tbIDAlta;
    }
}