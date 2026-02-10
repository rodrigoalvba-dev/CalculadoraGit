namespace Calculadora.Formularios
{
    partial class FrmTemporizador
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
            components = new System.ComponentModel.Container();
            labelHora = new Label();
            tmrHora = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            establecerToolStripMenuItem = new ToolStripMenuItem();
            mIalarma1 = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHora.Location = new Point(97, 120);
            labelHora.Margin = new Padding(2, 0, 2, 0);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(450, 106);
            labelHora.TabIndex = 0;
            labelHora.Text = "00:00:00 x.x";
            labelHora.Click += labelHora_Click;
            // 
            // tmrHora
            // 
            tmrHora.Enabled = true;
            tmrHora.Interval = 1000;
            tmrHora.Tick += tmrHora_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { establecerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(640, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // establecerToolStripMenuItem
            // 
            establecerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mIalarma1 });
            establecerToolStripMenuItem.Name = "establecerToolStripMenuItem";
            establecerToolStripMenuItem.Size = new Size(91, 24);
            establecerToolStripMenuItem.Text = "Establecer";
            // 
            // mIalarma1
            // 
            mIalarma1.Name = "mIalarma1";
            mIalarma1.Size = new Size(152, 26);
            mIalarma1.Text = "Alarma 1";
            mIalarma1.Click += mIalarma1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(38, 244);
            button1.Name = "button1";
            button1.Size = new Size(133, 36);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(197, 244);
            button2.Name = "button2";
            button2.Size = new Size(109, 36);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(355, 247);
            button3.Name = "button3";
            button3.Size = new Size(106, 33);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // FrmTemporizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelHora);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "FrmTemporizador";
            Text = "Reloj";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHora;
        private System.Windows.Forms.Timer tmrHora;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem establecerToolStripMenuItem;
        private ToolStripMenuItem mIalarma1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}