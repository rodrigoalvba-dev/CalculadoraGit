namespace Calculadora
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            calculadoraSImpleToolStripMenuItem = new ToolStripMenuItem();
            burbujaToolStripMenuItem = new ToolStripMenuItem();
            burbujaToolStripMenuItem1 = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            temporizadoresToolStripMenuItem = new ToolStripMenuItem();
            relojToolStripMenuItem = new ToolStripMenuItem();
            cronometroToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(640, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraSImpleToolStripMenuItem, burbujaToolStripMenuItem, registroToolStripMenuItem, temporizadoresToolStripMenuItem, cronometroToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(107, 24);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // calculadoraSImpleToolStripMenuItem
            // 
            calculadoraSImpleToolStripMenuItem.Name = "calculadoraSImpleToolStripMenuItem";
            calculadoraSImpleToolStripMenuItem.Size = new Size(224, 26);
            calculadoraSImpleToolStripMenuItem.Text = "Calculadora SImple";
            calculadoraSImpleToolStripMenuItem.Click += calculadoraSImpleToolStripMenuItem_Click;
            // 
            // burbujaToolStripMenuItem
            // 
            burbujaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { burbujaToolStripMenuItem1 });
            burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            burbujaToolStripMenuItem.Size = new Size(224, 26);
            burbujaToolStripMenuItem.Text = "Ordenamientos";
            // 
            // burbujaToolStripMenuItem1
            // 
            burbujaToolStripMenuItem1.Name = "burbujaToolStripMenuItem1";
            burbujaToolStripMenuItem1.Size = new Size(143, 26);
            burbujaToolStripMenuItem1.Text = "Burbuja";
            burbujaToolStripMenuItem1.Click += burbujaToolStripMenuItem1_Click;
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(224, 26);
            registroToolStripMenuItem.Text = "Registro";
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // temporizadoresToolStripMenuItem
            // 
            temporizadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relojToolStripMenuItem });
            temporizadoresToolStripMenuItem.Name = "temporizadoresToolStripMenuItem";
            temporizadoresToolStripMenuItem.Size = new Size(224, 26);
            temporizadoresToolStripMenuItem.Text = "Temporizadores";
            temporizadoresToolStripMenuItem.Click += temporizadoresToolStripMenuItem_Click;
            // 
            // relojToolStripMenuItem
            // 
            relojToolStripMenuItem.Name = "relojToolStripMenuItem";
            relojToolStripMenuItem.Size = new Size(224, 26);
            relojToolStripMenuItem.Text = "Reloj";
            relojToolStripMenuItem.Click += relojToolStripMenuItem_Click;
            // 
            // cronometroToolStripMenuItem
            // 
            cronometroToolStripMenuItem.Name = "cronometroToolStripMenuItem";
            cronometroToolStripMenuItem.Size = new Size(224, 26);
            cronometroToolStripMenuItem.Text = "cronometro";
            cronometroToolStripMenuItem.Click += cronometroToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Menu";
            Text = "FormMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem calculadoraSImpleToolStripMenuItem;
        private ToolStripMenuItem burbujaToolStripMenuItem;
        private ToolStripMenuItem burbujaToolStripMenuItem1;
        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem temporizadoresToolStripMenuItem;
        private ToolStripMenuItem relojToolStripMenuItem;
        private ToolStripMenuItem cronometroToolStripMenuItem;
    }
}
