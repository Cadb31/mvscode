namespace PersonasFormApp
{
    partial class FormPersona
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(403, 24);
            this.menuStripMain.TabIndex = 12;
            this.menuStripMain.Text = "menuStripCrud";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarMenuItem,
            this.consultarMenuItem,
            this.eliminarMenuItem,
            this.actualizarMenuItem,
            this.toolStripSeparator,
            this.salirMenuItem});
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.insertarToolStripMenuItem.Text = "Archivo";
            // 
            // insertarMenuItem
            // 
            this.insertarMenuItem.Name = "insertarMenuItem";
            this.insertarMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insertarMenuItem.Text = "Insertar";
            this.insertarMenuItem.Click += new System.EventHandler(this.insertarMenuItem_Click);
            // 
            // consultarMenuItem
            // 
            this.consultarMenuItem.Name = "consultarMenuItem";
            this.consultarMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultarMenuItem.Text = "Consultar";
            // 
            // eliminarMenuItem
            // 
            this.eliminarMenuItem.Name = "eliminarMenuItem";
            this.eliminarMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarMenuItem.Text = "Eliminar";
            // 
            // actualizarMenuItem
            // 
            this.actualizarMenuItem.Name = "actualizarMenuItem";
            this.actualizarMenuItem.Size = new System.Drawing.Size(152, 22);
            this.actualizarMenuItem.Text = "Actualizar";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirMenuItem.Text = "Salir";
            this.salirMenuItem.Click += new System.EventHandler(this.salirMenuItem_Click);
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 221);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormPersona";
            this.Text = "Personas";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
    }
}

