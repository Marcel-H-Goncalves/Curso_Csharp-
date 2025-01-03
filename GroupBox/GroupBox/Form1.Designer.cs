namespace GroupBox
{
    partial class Form1
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
            groupBoxGrupo1 = new System.Windows.Forms.GroupBox();
            trackBar1 = new TrackBar();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBoxGrupo2 = new System.Windows.Forms.GroupBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            groupBoxGrupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBoxGrupo2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGrupo1
            // 
            groupBoxGrupo1.BackColor = SystemColors.ControlLightLight;
            groupBoxGrupo1.Controls.Add(trackBar1);
            groupBoxGrupo1.Controls.Add(textBox1);
            groupBoxGrupo1.Controls.Add(button1);
            groupBoxGrupo1.Location = new Point(12, 12);
            groupBoxGrupo1.Name = "groupBoxGrupo1";
            groupBoxGrupo1.Size = new Size(346, 426);
            groupBoxGrupo1.TabIndex = 0;
            groupBoxGrupo1.TabStop = false;
            groupBoxGrupo1.Text = "Grupo 1";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(6, 115);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(334, 45);
            trackBar1.TabIndex = 5;
            
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(11, 349);
            button1.Name = "button1";
            button1.Size = new Size(329, 71);
            button1.TabIndex = 2;
            button1.Text = "Adicionar Grupo1";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxGrupo2
            // 
            groupBoxGrupo2.BackColor = SystemColors.ButtonHighlight;
            groupBoxGrupo2.Controls.Add(richTextBox1);
            groupBoxGrupo2.Controls.Add(button2);
            groupBoxGrupo2.ForeColor = SystemColors.InfoText;
            groupBoxGrupo2.Location = new Point(427, 12);
            groupBoxGrupo2.Name = "groupBoxGrupo2";
            groupBoxGrupo2.Size = new Size(361, 426);
            groupBoxGrupo2.TabIndex = 1;
            groupBoxGrupo2.TabStop = false;
            groupBoxGrupo2.Text = "Grupo 2";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(349, 96);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(6, 349);
            button2.Name = "button2";
            button2.Size = new Size(349, 71);
            button2.TabIndex = 3;
            button2.Text = "Adicionar Grupo2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxGrupo2);
            Controls.Add(groupBoxGrupo1);
            Name = "Form1";
            Text = "Form1";
            groupBoxGrupo1.ResumeLayout(false);
            groupBoxGrupo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBoxGrupo2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGrupo1;
        private System.Windows.Forms.GroupBox groupBoxGrupo2;
        private TrackBar trackBar1;
        private TextBox textBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
    }
}
