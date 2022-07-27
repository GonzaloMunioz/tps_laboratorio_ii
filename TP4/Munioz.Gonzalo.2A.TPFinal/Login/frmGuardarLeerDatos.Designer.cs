
namespace MiEstetica
{
    partial class frmGuardarLeerDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuardarLeerDatos));
            this.lblSerializacionXML = new System.Windows.Forms.Label();
            this.btnSerializarXML = new System.Windows.Forms.Button();
            this.btnDeserializarXML = new System.Windows.Forms.Button();
            this.btnSerializarJSON = new System.Windows.Forms.Button();
            this.btnDeserializarJSON = new System.Windows.Forms.Button();
            this.lblSerializacionJSON = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblBaseDeDatos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSerializacionXML
            // 
            this.lblSerializacionXML.AutoSize = true;
            this.lblSerializacionXML.Location = new System.Drawing.Point(16, 296);
            this.lblSerializacionXML.Name = "lblSerializacionXML";
            this.lblSerializacionXML.Size = new System.Drawing.Size(168, 17);
            this.lblSerializacionXML.TabIndex = 0;
            this.lblSerializacionXML.Text = "Serialización XML";
            // 
            // btnSerializarXML
            // 
            this.btnSerializarXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnSerializarXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerializarXML.Image = ((System.Drawing.Image)(resources.GetObject("btnSerializarXML.Image")));
            this.btnSerializarXML.Location = new System.Drawing.Point(11, 329);
            this.btnSerializarXML.Name = "btnSerializarXML";
            this.btnSerializarXML.Size = new System.Drawing.Size(178, 24);
            this.btnSerializarXML.TabIndex = 0;
            this.btnSerializarXML.Text = "SerializarXML";
            this.btnSerializarXML.UseVisualStyleBackColor = false;
            this.btnSerializarXML.Click += new System.EventHandler(this.btnSerializarXML_Click);
            // 
            // btnDeserializarXML
            // 
            this.btnDeserializarXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnDeserializarXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeserializarXML.Image = ((System.Drawing.Image)(resources.GetObject("btnDeserializarXML.Image")));
            this.btnDeserializarXML.Location = new System.Drawing.Point(11, 359);
            this.btnDeserializarXML.Name = "btnDeserializarXML";
            this.btnDeserializarXML.Size = new System.Drawing.Size(178, 24);
            this.btnDeserializarXML.TabIndex = 3;
            this.btnDeserializarXML.Text = "DeserializarXML";
            this.btnDeserializarXML.UseVisualStyleBackColor = false;
            this.btnDeserializarXML.Click += new System.EventHandler(this.btnDeserializarXML_Click);
            // 
            // btnSerializarJSON
            // 
            this.btnSerializarJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnSerializarJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerializarJSON.Image = ((System.Drawing.Image)(resources.GetObject("btnSerializarJSON.Image")));
            this.btnSerializarJSON.Location = new System.Drawing.Point(195, 329);
            this.btnSerializarJSON.Name = "btnSerializarJSON";
            this.btnSerializarJSON.Size = new System.Drawing.Size(178, 24);
            this.btnSerializarJSON.TabIndex = 1;
            this.btnSerializarJSON.Text = "SerializarJSON";
            this.btnSerializarJSON.UseVisualStyleBackColor = false;
            this.btnSerializarJSON.Click += new System.EventHandler(this.btnSerializarJSON_Click);
            // 
            // btnDeserializarJSON
            // 
            this.btnDeserializarJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnDeserializarJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeserializarJSON.Image = ((System.Drawing.Image)(resources.GetObject("btnDeserializarJSON.Image")));
            this.btnDeserializarJSON.Location = new System.Drawing.Point(195, 359);
            this.btnDeserializarJSON.Name = "btnDeserializarJSON";
            this.btnDeserializarJSON.Size = new System.Drawing.Size(178, 24);
            this.btnDeserializarJSON.TabIndex = 4;
            this.btnDeserializarJSON.Text = "DeserializarJSON";
            this.btnDeserializarJSON.UseVisualStyleBackColor = false;
            this.btnDeserializarJSON.Click += new System.EventHandler(this.btnDeserializarJSON_Click);
            // 
            // lblSerializacionJSON
            // 
            this.lblSerializacionJSON.AutoSize = true;
            this.lblSerializacionJSON.Location = new System.Drawing.Point(195, 296);
            this.lblSerializacionJSON.Name = "lblSerializacionJSON";
            this.lblSerializacionJSON.Size = new System.Drawing.Size(176, 17);
            this.lblSerializacionJSON.TabIndex = 12;
            this.lblSerializacionJSON.Text = "Serializacion JSON";
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnLeer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeer.Image = ((System.Drawing.Image)(resources.GetObject("btnLeer.Image")));
            this.btnLeer.Location = new System.Drawing.Point(379, 359);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(178, 24);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(379, 329);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(178, 24);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblBaseDeDatos
            // 
            this.lblBaseDeDatos.AutoSize = true;
            this.lblBaseDeDatos.Location = new System.Drawing.Point(404, 296);
            this.lblBaseDeDatos.Name = "lblBaseDeDatos";
            this.lblBaseDeDatos.Size = new System.Drawing.Size(129, 17);
            this.lblBaseDeDatos.TabIndex = 19;
            this.lblBaseDeDatos.Text = "Base de datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 253);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmGuardarLeerDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(569, 392);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBaseDeDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.lblSerializacionJSON);
            this.Controls.Add(this.btnSerializarXML);
            this.Controls.Add(this.btnDeserializarXML);
            this.Controls.Add(this.btnSerializarJSON);
            this.Controls.Add(this.btnDeserializarJSON);
            this.Controls.Add(this.lblSerializacionXML);
            this.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGuardarLeerDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEAUTY LIFE";
            this.Load += new System.EventHandler(this.frmGuardarLeerDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerializacionXML;
        private System.Windows.Forms.Button btnSerializarXML;
        private System.Windows.Forms.Button btnDeserializarXML;
        private System.Windows.Forms.Button btnSerializarJSON;
        private System.Windows.Forms.Button btnDeserializarJSON;
        private System.Windows.Forms.Label lblSerializacionJSON;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblBaseDeDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}