namespace ControlDePersonal_Pro
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IngresarDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.IngresoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.AsignarHorarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngresarDatos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IngresarDatos
            // 
            this.IngresarDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngresoUsuario,
            this.AsignarHorarios,
            this.Exit});
            this.IngresarDatos.Name = "IngresarDatos";
            this.IngresarDatos.Size = new System.Drawing.Size(111, 20);
            this.IngresarDatos.Text = "INGRESAR DATOS";
            // 
            // IngresoUsuario
            // 
            this.IngresoUsuario.Name = "IngresoUsuario";
            this.IngresoUsuario.Size = new System.Drawing.Size(184, 22);
            this.IngresoUsuario.Text = "INGRESAR USUARIO";
            this.IngresoUsuario.Click += new System.EventHandler(this.IngresoUsuario_Click);
            // 
            // AsignarHorarios
            // 
            this.AsignarHorarios.Name = "AsignarHorarios";
            this.AsignarHorarios.Size = new System.Drawing.Size(184, 22);
            this.AsignarHorarios.Text = "ASIGNAR HORARIOS";
            this.AsignarHorarios.Click += new System.EventHandler(this.AsignarHorarios_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(184, 22);
            this.Exit.Text = "EXIT";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 507);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "ADMINISTRADOR";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem IngresarDatos;
        private System.Windows.Forms.ToolStripMenuItem IngresoUsuario;
        private System.Windows.Forms.ToolStripMenuItem AsignarHorarios;
        private System.Windows.Forms.ToolStripMenuItem Exit;
    }
}