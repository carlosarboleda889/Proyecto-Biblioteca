namespace Biblioteca
{
    partial class Maestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maestro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reintegrarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.actualizaciónToolStripMenuItem,
            this.novedadesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaPorNombreToolStripMenuItem,
            this.consultaPorCódigoToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // actualizaciónToolStripMenuItem
            // 
            this.actualizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarLibroToolStripMenuItem,
            this.eliminarLibroToolStripMenuItem,
            this.actualizarLibroToolStripMenuItem});
            this.actualizaciónToolStripMenuItem.Name = "actualizaciónToolStripMenuItem";
            this.actualizaciónToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.actualizaciónToolStripMenuItem.Text = "Actualización";
            // 
            // novedadesToolStripMenuItem
            // 
            this.novedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestarLibroToolStripMenuItem,
            this.reintegrarLibroToolStripMenuItem});
            this.novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            this.novedadesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.novedadesToolStripMenuItem.Text = "Novedades";
            // 
            // consultaPorNombreToolStripMenuItem
            // 
            this.consultaPorNombreToolStripMenuItem.Name = "consultaPorNombreToolStripMenuItem";
            this.consultaPorNombreToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.consultaPorNombreToolStripMenuItem.Text = "Consulta por código";
            // 
            // consultaPorCódigoToolStripMenuItem
            // 
            this.consultaPorCódigoToolStripMenuItem.Name = "consultaPorCódigoToolStripMenuItem";
            this.consultaPorCódigoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.consultaPorCódigoToolStripMenuItem.Text = "Consulta por nombre";
            // 
            // ingresarLibroToolStripMenuItem
            // 
            this.ingresarLibroToolStripMenuItem.Name = "ingresarLibroToolStripMenuItem";
            this.ingresarLibroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarLibroToolStripMenuItem.Text = "Ingresar libro";
            // 
            // eliminarLibroToolStripMenuItem
            // 
            this.eliminarLibroToolStripMenuItem.Name = "eliminarLibroToolStripMenuItem";
            this.eliminarLibroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarLibroToolStripMenuItem.Text = "Eliminar libro";
            // 
            // actualizarLibroToolStripMenuItem
            // 
            this.actualizarLibroToolStripMenuItem.Name = "actualizarLibroToolStripMenuItem";
            this.actualizarLibroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarLibroToolStripMenuItem.Text = "Actualizar libro";
            // 
            // prestarLibroToolStripMenuItem
            // 
            this.prestarLibroToolStripMenuItem.Name = "prestarLibroToolStripMenuItem";
            this.prestarLibroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prestarLibroToolStripMenuItem.Text = "Prestar libro";
            // 
            // reintegrarLibroToolStripMenuItem
            // 
            this.reintegrarLibroToolStripMenuItem.Name = "reintegrarLibroToolStripMenuItem";
            this.reintegrarLibroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reintegrarLibroToolStripMenuItem.Text = "Reintegrar libro";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Maestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 520);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Maestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPorCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reintegrarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}