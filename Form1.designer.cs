namespace ControlDePersonal_Pro
{
    partial class FormIngresoPersonal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresoPersonal));
            this.label1 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbContaseña = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.grbRegistroPersonal = new System.Windows.Forms.GroupBox();
            this.btn_reg_salida = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContaseña = new System.Windows.Forms.Label();
            this.grbVerificacion = new System.Windows.Forms.GroupBox();
            this.txtMensaje = new System.Windows.Forms.Label();
            this.lblVerificacion = new System.Windows.Forms.Label();
            this.btnAdministador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.grbRegistroPersonal.SuspendLayout();
            this.grbVerificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(110, 27);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(154, 20);
            this.txbUsuario.TabIndex = 3;
            // 
            // txbContaseña
            // 
            this.txbContaseña.Location = new System.Drawing.Point(110, 68);
            this.txbContaseña.Name = "txbContaseña";
            this.txbContaseña.Size = new System.Drawing.Size(154, 20);
            this.txbContaseña.TabIndex = 4;
            this.txbContaseña.UseSystemPasswordChar = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(61, 109);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Text = "ENTRADA";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // grbRegistroPersonal
            // 
            this.grbRegistroPersonal.Controls.Add(this.btn_limpiar);
            this.grbRegistroPersonal.Controls.Add(this.btn_reg_salida);
            this.grbRegistroPersonal.Controls.Add(this.txbContaseña);
            this.grbRegistroPersonal.Controls.Add(this.btnRegistro);
            this.grbRegistroPersonal.Controls.Add(this.lblUsuario);
            this.grbRegistroPersonal.Controls.Add(this.lblContaseña);
            this.grbRegistroPersonal.Controls.Add(this.txbUsuario);
            this.grbRegistroPersonal.Location = new System.Drawing.Point(222, 45);
            this.grbRegistroPersonal.Name = "grbRegistroPersonal";
            this.grbRegistroPersonal.Size = new System.Drawing.Size(389, 139);
            this.grbRegistroPersonal.TabIndex = 7;
            this.grbRegistroPersonal.TabStop = false;
            this.grbRegistroPersonal.Text = "REGISTRO DE PERSONAL";
            this.grbRegistroPersonal.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_reg_salida
            // 
            this.btn_reg_salida.Location = new System.Drawing.Point(169, 109);
            this.btn_reg_salida.Name = "btn_reg_salida";
            this.btn_reg_salida.Size = new System.Drawing.Size(75, 23);
            this.btn_reg_salida.TabIndex = 7;
            this.btn_reg_salida.Text = "SALIDA";
            this.btn_reg_salida.UseVisualStyleBackColor = true;
            this.btn_reg_salida.Click += new System.EventHandler(this.btn_reg_salida_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Image = global::ControlDePersonal_Pro.Properties.Resources.usuario;
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Location = new System.Drawing.Point(7, 34);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(77, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "       USUARIO\r\n";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblContaseña
            // 
            this.lblContaseña.AutoSize = true;
            this.lblContaseña.Image = global::ControlDePersonal_Pro.Properties.Resources.ojo_de_cerradura;
            this.lblContaseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblContaseña.Location = new System.Drawing.Point(6, 75);
            this.lblContaseña.Name = "lblContaseña";
            this.lblContaseña.Size = new System.Drawing.Size(94, 13);
            this.lblContaseña.TabIndex = 2;
            this.lblContaseña.Text = "       CONTASEÑA";
            // 
            // grbVerificacion
            // 
            this.grbVerificacion.Controls.Add(this.txtMensaje);
            this.grbVerificacion.Controls.Add(this.lblVerificacion);
            this.grbVerificacion.Location = new System.Drawing.Point(222, 190);
            this.grbVerificacion.Name = "grbVerificacion";
            this.grbVerificacion.Size = new System.Drawing.Size(389, 73);
            this.grbVerificacion.TabIndex = 8;
            this.grbVerificacion.TabStop = false;
            this.grbVerificacion.Text = "VERIFICACIÓN";
            this.grbVerificacion.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtMensaje
            // 
            this.txtMensaje.AutoSize = true;
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(6, 20);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(0, 37);
            this.txtMensaje.TabIndex = 7;
            this.txtMensaje.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVerificacion
            // 
            this.lblVerificacion.AutoSize = true;
            this.lblVerificacion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblVerificacion.Location = new System.Drawing.Point(7, 20);
            this.lblVerificacion.Name = "lblVerificacion";
            this.lblVerificacion.Size = new System.Drawing.Size(10, 13);
            this.lblVerificacion.TabIndex = 0;
            this.lblVerificacion.Text = " ";
            // 
            // btnAdministador
            // 
            this.btnAdministador.BackgroundImage = global::ControlDePersonal_Pro.Properties.Resources.administracion;
            this.btnAdministador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdministador.Enabled = false;
            this.btnAdministador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministador.Location = new System.Drawing.Point(473, 12);
            this.btnAdministador.Name = "btnAdministador";
            this.btnAdministador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdministador.Size = new System.Drawing.Size(135, 26);
            this.btnAdministador.TabIndex = 10;
            this.btnAdministador.Text = "ADMINISTRADOR";
            this.btnAdministador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministador.UseVisualStyleBackColor = true;
            this.btnAdministador.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.BackgroundImage = global::ControlDePersonal_Pro.Properties.Resources.calendario_de_escritorio1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 278);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(328, 109);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(58, 23);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // FormIngresoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 278);
            this.Controls.Add(this.btnAdministador);
            this.Controls.Add(this.grbVerificacion);
            this.Controls.Add(this.grbRegistroPersonal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIngresoPersonal";
            this.Text = "INGRESO DE PERSONAL";
            this.Load += new System.EventHandler(this.FormIngresoPersonal_Load);
            this.grbRegistroPersonal.ResumeLayout(false);
            this.grbRegistroPersonal.PerformLayout();
            this.grbVerificacion.ResumeLayout(false);
            this.grbVerificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContaseña;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbContaseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.GroupBox grbRegistroPersonal;
        private System.Windows.Forms.GroupBox grbVerificacion;
        private System.Windows.Forms.Label lblVerificacion;
        private System.Windows.Forms.Button btnAdministador;
        private System.Windows.Forms.Label txtMensaje;
        private System.Windows.Forms.Button btn_reg_salida;
        private System.Windows.Forms.Button btn_limpiar;
    }
}

