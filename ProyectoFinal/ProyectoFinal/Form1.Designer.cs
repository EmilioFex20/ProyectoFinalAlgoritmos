﻿namespace ProyectoFinal
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapaToolStripMenuItem,
            this.búsquedaToolStripMenuItem,
            this.informaciónToolStripMenuItem,
            this.idiomaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(936, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mapaToolStripMenuItem
            // 
            this.mapaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciudadToolStripMenuItem,
            this.rutasToolStripMenuItem});
            this.mapaToolStripMenuItem.Name = "mapaToolStripMenuItem";
            this.mapaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.mapaToolStripMenuItem.Text = "Mapa";
            // 
            // ciudadToolStripMenuItem
            // 
            this.ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            this.ciudadToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.ciudadToolStripMenuItem.Text = "Ciudad";
            this.ciudadToolStripMenuItem.Click += new System.EventHandler(this.ciudadToolStripMenuItem_Click);
            // 
            // rutasToolStripMenuItem
            // 
            this.rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            this.rutasToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.rutasToolStripMenuItem.Text = "Ruta";
            this.rutasToolStripMenuItem.Click += new System.EventHandler(this.rutasToolStripMenuItem_Click);
            // 
            // búsquedaToolStripMenuItem
            // 
            this.búsquedaToolStripMenuItem.Name = "búsquedaToolStripMenuItem";
            this.búsquedaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.búsquedaToolStripMenuItem.Text = "Búsqueda";
            this.búsquedaToolStripMenuItem.Click += new System.EventHandler(this.búsquedaToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informaciónToolStripMenuItem.Text = "Información";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónToolStripMenuItem_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.españolToolStripMenuItem,
            this.inglésToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.españolToolStripMenuItem.Text = "Español";
            // 
            // inglésToolStripMenuItem
            // 
            this.inglésToolStripMenuItem.Name = "inglésToolStripMenuItem";
            this.inglésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inglésToolStripMenuItem.Text = "Inglés";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 470);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Planeación de viajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglésToolStripMenuItem;
    }
}

