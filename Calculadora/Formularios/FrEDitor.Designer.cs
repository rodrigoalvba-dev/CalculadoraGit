namespace Calculadora.Formularios
{
    partial class FrEDitor
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
            menuStrip1 = new MenuStrip();
            activosToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abriroolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem1 = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            OFP = new OpenFileDialog();
            SFD = new SaveFileDialog();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { activosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // activosToolStripMenuItem
            // 
            activosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abriroolStripMenuItem, guardarToolStripMenuItem1, guardarComoToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            activosToolStripMenuItem.Name = "activosToolStripMenuItem";
            activosToolStripMenuItem.Size = new Size(75, 24);
            activosToolStripMenuItem.Text = "Activos ";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(189, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abriroolStripMenuItem
            // 
            abriroolStripMenuItem.Name = "abriroolStripMenuItem";
            abriroolStripMenuItem.Size = new Size(189, 26);
            abriroolStripMenuItem.Text = "Abrir";
            abriroolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem1
            // 
            guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            guardarToolStripMenuItem1.Size = new Size(189, 26);
            guardarToolStripMenuItem1.Text = "Guardar";
            guardarToolStripMenuItem1.Click += guardarToolStripMenuItem1_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(189, 26);
            guardarComoToolStripMenuItem.Text = "Guardar Como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(186, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(189, 26);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // OFP
            // 
            OFP.Filter = "\"Archivo de Texto\"|*.txt";
            // 
            // SFD
            // 
            SFD.Filter = "\"Archivo de Texto\"|*.txt";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 409);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // FrEDitor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrEDitor";
            Text = "fr";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem activosToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abriroolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private StatusStrip statusStrip1;
        private OpenFileDialog OFP;
        private SaveFileDialog SFD;
        private ToolStripMenuItem guardarToolStripMenuItem1;
        private RichTextBox richTextBox1;
    }
}