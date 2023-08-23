namespace ControlDePersonal_Pro
{
    partial class IngresoPersonal
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combxCargo = new System.Windows.Forms.ComboBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContasena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPersonal1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePersonal1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPersonal1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corgoPersonal1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoPersonal1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaseña1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combxCargo);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtContasena);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESO DE LA INFORMACION DEL USUARIO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // combxCargo
            // 
            this.combxCargo.FormattingEnabled = true;
            this.combxCargo.Items.AddRange(new object[] {
            "Administador",
            "Empleado"});
            this.combxCargo.Location = new System.Drawing.Point(95, 130);
            this.combxCargo.Name = "combxCargo";
            this.combxCargo.Size = new System.Drawing.Size(172, 21);
            this.combxCargo.TabIndex = 10;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(95, 43);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(172, 20);
            this.txtNombres.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(95, 88);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(172, 20);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(95, 180);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(172, 20);
            this.txtCorreo.TabIndex = 6;
            // 
            // txtContasena
            // 
            this.txtContasena.Location = new System.Drawing.Point(95, 233);
            this.txtContasena.Name = "txtContasena";
            this.txtContasena.Size = new System.Drawing.Size(172, 20);
            this.txtContasena.TabIndex = 5;
            this.txtContasena.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CONTRASEÑA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CORREO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CARGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRES";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(12, 364);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(87, 23);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(198, 364);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(105, 364);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(180, 17);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(87, 23);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 54);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(31, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(143, 20);
            this.txtId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToDeleteRows = false;
            this.dgvPersonal.AutoGenerateColumns = false;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonal1DataGridViewTextBoxColumn,
            this.nombrePersonal1DataGridViewTextBoxColumn,
            this.apellidoPersonal1DataGridViewTextBoxColumn,
            this.corgoPersonal1DataGridViewTextBoxColumn,
            this.correoPersonal1DataGridViewTextBoxColumn,
            this.contaseña1DataGridViewTextBoxColumn});
            this.dgvPersonal.DataSource = this.personalBindingSource;
            this.dgvPersonal.Location = new System.Drawing.Point(303, 13);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            this.dgvPersonal.Size = new System.Drawing.Size(543, 372);
            this.dgvPersonal.TabIndex = 6;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(ControlDePersonal_Pro.Personal);
            // 
            // idPersonal1DataGridViewTextBoxColumn
            // 
            this.idPersonal1DataGridViewTextBoxColumn.DataPropertyName = "IdPersonal1";
            this.idPersonal1DataGridViewTextBoxColumn.HeaderText = "IdPersonal1";
            this.idPersonal1DataGridViewTextBoxColumn.Name = "idPersonal1DataGridViewTextBoxColumn";
            this.idPersonal1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePersonal1DataGridViewTextBoxColumn
            // 
            this.nombrePersonal1DataGridViewTextBoxColumn.DataPropertyName = "NombrePersonal1";
            this.nombrePersonal1DataGridViewTextBoxColumn.HeaderText = "NombrePersonal1";
            this.nombrePersonal1DataGridViewTextBoxColumn.Name = "nombrePersonal1DataGridViewTextBoxColumn";
            this.nombrePersonal1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoPersonal1DataGridViewTextBoxColumn
            // 
            this.apellidoPersonal1DataGridViewTextBoxColumn.DataPropertyName = "ApellidoPersonal1";
            this.apellidoPersonal1DataGridViewTextBoxColumn.HeaderText = "ApellidoPersonal1";
            this.apellidoPersonal1DataGridViewTextBoxColumn.Name = "apellidoPersonal1DataGridViewTextBoxColumn";
            this.apellidoPersonal1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corgoPersonal1DataGridViewTextBoxColumn
            // 
            this.corgoPersonal1DataGridViewTextBoxColumn.DataPropertyName = "CorgoPersonal1";
            this.corgoPersonal1DataGridViewTextBoxColumn.HeaderText = "CorgoPersonal1";
            this.corgoPersonal1DataGridViewTextBoxColumn.Name = "corgoPersonal1DataGridViewTextBoxColumn";
            this.corgoPersonal1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoPersonal1DataGridViewTextBoxColumn
            // 
            this.correoPersonal1DataGridViewTextBoxColumn.DataPropertyName = "CorreoPersonal1";
            this.correoPersonal1DataGridViewTextBoxColumn.HeaderText = "CorreoPersonal1";
            this.correoPersonal1DataGridViewTextBoxColumn.Name = "correoPersonal1DataGridViewTextBoxColumn";
            this.correoPersonal1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contaseña1DataGridViewTextBoxColumn
            // 
            this.contaseña1DataGridViewTextBoxColumn.DataPropertyName = "Contaseña1";
            this.contaseña1DataGridViewTextBoxColumn.HeaderText = "Contaseña1";
            this.contaseña1DataGridViewTextBoxColumn.Name = "contaseña1DataGridViewTextBoxColumn";
            this.contaseña1DataGridViewTextBoxColumn.ReadOnly = true;
            this.contaseña1DataGridViewTextBoxColumn.Visible = false;
            // 
            // IngresoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 397);
            this.Controls.Add(this.dgvPersonal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "IngresoPersonal";
            this.Text = "INGRESO DEL PERSONAL";
            this.Load += new System.EventHandler(this.IngresoPersonal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContasena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combxCargo;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonal1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersonal1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPersonal1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corgoPersonal1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoPersonal1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaseña1DataGridViewTextBoxColumn;
    }
}