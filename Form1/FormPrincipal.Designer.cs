namespace Form1
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            perfilPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { archivosToolStripMenuItem, opcionesToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(944, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem });
            archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            archivosToolStripMenuItem.Text = "&Archivos";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { perfilPersonaToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // perfilPersonaToolStripMenuItem
            // 
            perfilPersonaToolStripMenuItem.Name = "perfilPersonaToolStripMenuItem";
            perfilPersonaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            perfilPersonaToolStripMenuItem.Text = "Perfil Persona";
            perfilPersonaToolStripMenuItem.Click += perfilPersonaToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            aboutToolStripMenuItem.Text = "A&bout";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripSeparator1, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new System.Drawing.Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(944, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Perfil Persona";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (System.Drawing.Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new System.Drawing.Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (System.Drawing.Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new System.Drawing.Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (System.Drawing.Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new System.Drawing.Size(23, 22);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new System.Drawing.Point(0, 600);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(944, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightCoral;
            ClientSize = new System.Drawing.Size(944, 622);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}