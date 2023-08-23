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
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngresarDatos,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IngresarDatos
            // 
            this.IngresarDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngresoUsuario,
            this.Exit});
            this.IngresarDatos.Name = "IngresarDatos";
            this.IngresarDatos.Size = new System.Drawing.Size(111, 20);
            this.IngresarDatos.Text = "INGRESAR DATOS";
            // 
            // IngresoUsuario
            // 
            this.IngresoUsuario.Name = "IngresoUsuario";
            this.IngresoUsuario.Size = new System.Drawing.Size(180, 22);
            this.IngresoUsuario.Text = "INGRESAR USUARIO";
            this.IngresoUsuario.Click += new System.EventHandler(this.IngresoUsuario_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "EXIT";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEPORTEToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.reportesToolStripMenuItem.Text = "REPORTES";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // rEPORTEToolStripMenuItem
            // 
            this.rEPORTEToolStripMenuItem.Name = "rEPORTEToolStripMenuItem";
            this.rEPORTEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rEPORTEToolStripMenuItem.Text = "REPORTE";
            this.rEPORTEToolStripMenuItem.Click += new System.EventHandler(this.rEPORTEToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 616);
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
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTEToolStripMenuItem;
    }
}