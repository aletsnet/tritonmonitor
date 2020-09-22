namespace TritonMonitor
{
    partial class FrmMain
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
            this.gpMenu = new System.Windows.Forms.GroupBox();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gpLista = new System.Windows.Forms.GroupBox();
            this.lvLista = new System.Windows.Forms.ListView();
            this.lStatusTicket = new System.Windows.Forms.Label();
            this.gpMenu.SuspendLayout();
            this.gpLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpMenu
            // 
            this.gpMenu.Controls.Add(this.lStatusTicket);
            this.gpMenu.Controls.Add(this.btnConfigurar);
            this.gpMenu.Controls.Add(this.btnActualizar);
            this.gpMenu.Location = new System.Drawing.Point(12, 12);
            this.gpMenu.Name = "gpMenu";
            this.gpMenu.Size = new System.Drawing.Size(418, 49);
            this.gpMenu.TabIndex = 0;
            this.gpMenu.TabStop = false;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(337, 20);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 1;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(256, 19);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // gpLista
            // 
            this.gpLista.Controls.Add(this.lvLista);
            this.gpLista.Location = new System.Drawing.Point(12, 67);
            this.gpLista.Name = "gpLista";
            this.gpLista.Size = new System.Drawing.Size(418, 371);
            this.gpLista.TabIndex = 1;
            this.gpLista.TabStop = false;
            this.gpLista.Text = "Lista";
            // 
            // lvLista
            // 
            this.lvLista.AllowDrop = true;
            this.lvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLista.GridLines = true;
            this.lvLista.HideSelection = false;
            this.lvLista.Location = new System.Drawing.Point(3, 16);
            this.lvLista.MultiSelect = false;
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(412, 352);
            this.lvLista.TabIndex = 0;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            // 
            // lStatusTicket
            // 
            this.lStatusTicket.AutoSize = true;
            this.lStatusTicket.Location = new System.Drawing.Point(15, 25);
            this.lStatusTicket.Name = "lStatusTicket";
            this.lStatusTicket.Size = new System.Drawing.Size(55, 13);
            this.lStatusTicket.TabIndex = 2;
            this.lStatusTicket.Text = "En espera";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.gpLista);
            this.Controls.Add(this.gpMenu);
            this.Name = "FrmMain";
            this.Text = "TritonMonito";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gpMenu.ResumeLayout(false);
            this.gpMenu.PerformLayout();
            this.gpLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpMenu;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox gpLista;
        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.Label lStatusTicket;
    }
}

