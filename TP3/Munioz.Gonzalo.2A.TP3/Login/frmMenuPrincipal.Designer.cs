
namespace MiEstetica
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
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblListarInformacion = new System.Windows.Forms.Label();
            this.rtbListaClientes = new System.Windows.Forms.RichTextBox();
            this.lblVentasHoy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProxTurnos = new System.Windows.Forms.Label();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.rtbProximosTurnos = new System.Windows.Forms.RichTextBox();
            this.rtbProductos = new System.Windows.Forms.RichTextBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnDeserializarJSON = new System.Windows.Forms.Button();
            this.btnSerializarJSON = new System.Windows.Forms.Button();
            this.btnDeserializarXML = new System.Windows.Forms.Button();
            this.btnSerializarXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(376, -9);
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
            this.lblAgregarCliente.Location = new System.Drawing.Point(262, 116);
            this.lblAgregarCliente.Name = "lblAgregarCliente";
            this.lblAgregarCliente.Size = new System.Drawing.Size(174, 19);
            this.lblAgregarCliente.TabIndex = 0;
            this.lblAgregarCliente.Text = "agregar cliente";
            this.lblAgregarCliente.Click += new System.EventHandler(this.lblAgregarCliente_Click);
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Ablation Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarCliente.Location = new System.Drawing.Point(458, 116);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(163, 19);
            this.lblBuscarCliente.TabIndex = 1;
            this.lblBuscarCliente.Text = "Buscar cliente";
            this.lblBuscarCliente.Click += new System.EventHandler(this.lblBuscarCliente_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductos.Font = new System.Drawing.Font("Ablation Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductos.Location = new System.Drawing.Point(872, 116);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(115, 19);
            this.lblProductos.TabIndex = 3;
            this.lblProductos.Text = "Productos";
            this.lblProductos.Click += new System.EventHandler(this.lblProductos_Click);
            // 
            // lblListarInformacion
            // 
            this.lblListarInformacion.AutoSize = true;
            this.lblListarInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListarInformacion.Font = new System.Drawing.Font("Ablation Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListarInformacion.Location = new System.Drawing.Point(653, 116);
            this.lblListarInformacion.Name = "lblListarInformacion";
            this.lblListarInformacion.Size = new System.Drawing.Size(195, 19);
            this.lblListarInformacion.TabIndex = 4;
            this.lblListarInformacion.Text = "Listar información";
            this.lblListarInformacion.Click += new System.EventHandler(this.lblListarInformacion_Click);
            // 
            // rtbListaClientes
            // 
            this.rtbListaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.rtbListaClientes.Location = new System.Drawing.Point(429, 169);
            this.rtbListaClientes.Name = "rtbListaClientes";
            this.rtbListaClientes.ReadOnly = true;
            this.rtbListaClientes.Size = new System.Drawing.Size(406, 500);
            this.rtbListaClientes.TabIndex = 6;
            this.rtbListaClientes.Text = "";
            // 
            // lblVentasHoy
            // 
            this.lblVentasHoy.AutoSize = true;
            this.lblVentasHoy.Location = new System.Drawing.Point(550, 149);
            this.lblVentasHoy.Name = "lblVentasHoy";
            this.lblVentasHoy.Size = new System.Drawing.Size(162, 17);
            this.lblVentasHoy.TabIndex = 8;
            this.lblVentasHoy.Text = "Lista de clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ablation Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.label8.Location = new System.Drawing.Point(218, 123);
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
            this.lblProxTurnos.Location = new System.Drawing.Point(134, 149);
            this.lblProxTurnos.Name = "lblProxTurnos";
            this.lblProxTurnos.Size = new System.Drawing.Size(161, 17);
            this.lblProxTurnos.TabIndex = 11;
            this.lblProxTurnos.Text = "Proximos turnos";
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.Location = new System.Drawing.Point(1000, 149);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(103, 17);
            this.lblListaProductos.TabIndex = 12;
            this.lblListaProductos.Text = "Productos";
            // 
            // rtbProximosTurnos
            // 
            this.rtbProximosTurnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.rtbProximosTurnos.Location = new System.Drawing.Point(12, 169);
            this.rtbProximosTurnos.Name = "rtbProximosTurnos";
            this.rtbProximosTurnos.ReadOnly = true;
            this.rtbProximosTurnos.Size = new System.Drawing.Size(411, 500);
            this.rtbProximosTurnos.TabIndex = 13;
            this.rtbProximosTurnos.Text = "";
            // 
            // rtbProductos
            // 
            this.rtbProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.rtbProductos.Location = new System.Drawing.Point(841, 169);
            this.rtbProductos.Name = "rtbProductos";
            this.rtbProductos.ReadOnly = true;
            this.rtbProductos.Size = new System.Drawing.Size(411, 500);
            this.rtbProductos.TabIndex = 14;
            this.rtbProductos.Text = "";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Edwardian Script ITC", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(-5, 1);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(132, 39);
            this.lblBienvenido.TabIndex = 16;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(236)))));
            this.lblUsuario.Location = new System.Drawing.Point(124, 8);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 28);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnDeserializarJSON
            // 
            this.btnDeserializarJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnDeserializarJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeserializarJSON.Image = ((System.Drawing.Image)(resources.GetObject("btnDeserializarJSON.Image")));
            this.btnDeserializarJSON.Location = new System.Drawing.Point(1068, 31);
            this.btnDeserializarJSON.Name = "btnDeserializarJSON";
            this.btnDeserializarJSON.Size = new System.Drawing.Size(184, 24);
            this.btnDeserializarJSON.TabIndex = 7;
            this.btnDeserializarJSON.Text = "DeserializarJSON";
            this.btnDeserializarJSON.UseVisualStyleBackColor = false;
            this.btnDeserializarJSON.Click += new System.EventHandler(this.btnDeserializarJSON_Click);
            // 
            // btnSerializarJSON
            // 
            this.btnSerializarJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnSerializarJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerializarJSON.Image = ((System.Drawing.Image)(resources.GetObject("btnSerializarJSON.Image")));
            this.btnSerializarJSON.Location = new System.Drawing.Point(1068, 1);
            this.btnSerializarJSON.Name = "btnSerializarJSON";
            this.btnSerializarJSON.Size = new System.Drawing.Size(184, 24);
            this.btnSerializarJSON.TabIndex = 5;
            this.btnSerializarJSON.Text = "SerializarJSON";
            this.btnSerializarJSON.UseVisualStyleBackColor = false;
            this.btnSerializarJSON.Click += new System.EventHandler(this.btnSerializarJSON_Click);
            // 
            // btnDeserializarXML
            // 
            this.btnDeserializarXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnDeserializarXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeserializarXML.Image = ((System.Drawing.Image)(resources.GetObject("btnDeserializarXML.Image")));
            this.btnDeserializarXML.Location = new System.Drawing.Point(878, 31);
            this.btnDeserializarXML.Name = "btnDeserializarXML";
            this.btnDeserializarXML.Size = new System.Drawing.Size(184, 24);
            this.btnDeserializarXML.TabIndex = 6;
            this.btnDeserializarXML.Text = "DeserializarXML";
            this.btnDeserializarXML.UseVisualStyleBackColor = false;
            this.btnDeserializarXML.Click += new System.EventHandler(this.btnDeserializarXML_Click);
            // 
            // btnSerializarXML
            // 
            this.btnSerializarXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.btnSerializarXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerializarXML.Image = ((System.Drawing.Image)(resources.GetObject("btnSerializarXML.Image")));
            this.btnSerializarXML.Location = new System.Drawing.Point(878, 1);
            this.btnSerializarXML.Name = "btnSerializarXML";
            this.btnSerializarXML.Size = new System.Drawing.Size(184, 24);
            this.btnSerializarXML.TabIndex = 4;
            this.btnSerializarXML.Text = "SerializarXML";
            this.btnSerializarXML.UseVisualStyleBackColor = false;
            this.btnSerializarXML.Click += new System.EventHandler(this.btnSerializarXML_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnSerializarXML);
            this.Controls.Add(this.btnDeserializarXML);
            this.Controls.Add(this.btnSerializarJSON);
            this.Controls.Add(this.btnDeserializarJSON);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.rtbProductos);
            this.Controls.Add(this.rtbProximosTurnos);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.lblProxTurnos);
            this.Controls.Add(this.lblVentasHoy);
            this.Controls.Add(this.rtbListaClientes);
            this.Controls.Add(this.lblListarInformacion);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblBuscarCliente);
            this.Controls.Add(this.lblAgregarCliente);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBienvenido);
            this.Font = new System.Drawing.Font("Ablation Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEAUTY LIFE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblAgregarCliente;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblListarInformacion;
        private System.Windows.Forms.RichTextBox rtbListaClientes;
        private System.Windows.Forms.Label lblVentasHoy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProxTurnos;
        private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.RichTextBox rtbProximosTurnos;
        private System.Windows.Forms.RichTextBox rtbProductos;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnDeserializarJSON;
        private System.Windows.Forms.Button btnSerializarJSON;
        private System.Windows.Forms.Button btnDeserializarXML;
        private System.Windows.Forms.Button btnSerializarXML;
    }
}

