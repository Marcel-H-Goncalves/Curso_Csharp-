namespace CheckBox_e_RadioButton
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
            Playstation = new CheckBox();
            Xbox = new CheckBox();
            Nintendo = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            textBox1 = new TextBox();
            botaoAplicar = new Button();
            label1 = new Label();
            Steam = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Playstation
            // 
            Playstation.AutoSize = true;
            Playstation.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Playstation.Location = new Point(570, 151);
            Playstation.Name = "Playstation";
            Playstation.Size = new Size(141, 34);
            Playstation.TabIndex = 0;
            Playstation.Text = "Playstation";
            Playstation.UseVisualStyleBackColor = true;
            Playstation.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Xbox
            // 
            Xbox.AutoSize = true;
            Xbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Xbox.Location = new Point(570, 191);
            Xbox.Name = "Xbox";
            Xbox.Size = new Size(84, 34);
            Xbox.TabIndex = 1;
            Xbox.Text = "Xbox";
            Xbox.UseVisualStyleBackColor = true;
            Xbox.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Nintendo
            // 
            Nintendo.AutoSize = true;
            Nintendo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Nintendo.Location = new Point(570, 231);
            Nintendo.Name = "Nintendo";
            Nintendo.Size = new Size(126, 34);
            Nintendo.TabIndex = 2;
            Nintendo.Text = "Nintendo";
            Nintendo.UseVisualStyleBackColor = true;
            Nintendo.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 34);
            radioButton1.TabIndex = 3;
            radioButton1.Text = "Playstation";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            radioButton2.Location = new Point(6, 62);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 34);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "Xbox";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            radioButton3.Location = new Point(6, 102);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(125, 34);
            radioButton3.TabIndex = 5;
            radioButton3.Text = "Nintendo";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(43, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 206);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plataformas";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            radioButton4.Location = new Point(6, 142);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(91, 34);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Steam";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(288, 361);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 35);
            textBox1.TabIndex = 11;
            // 
            // botaoAplicar
            // 
            botaoAplicar.FlatStyle = FlatStyle.Popup;
            botaoAplicar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botaoAplicar.Location = new Point(317, 402);
            botaoAplicar.Name = "botaoAplicar";
            botaoAplicar.Size = new Size(200, 36);
            botaoAplicar.TabIndex = 12;
            botaoAplicar.Text = "Aplicar";
            botaoAplicar.UseVisualStyleBackColor = true;
            botaoAplicar.Click += botaoAplicar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(415, 37);
            label1.TabIndex = 13;
            label1.Text = "Qual sua Plataforma Preferida?";
            // 
            // Steam
            // 
            Steam.AutoSize = true;
            Steam.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Steam.Location = new Point(570, 271);
            Steam.Name = "Steam";
            Steam.Size = new Size(92, 34);
            Steam.TabIndex = 14;
            Steam.Text = "Steam";
            Steam.UseVisualStyleBackColor = true;
            Steam.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(317, 337);
            label2.Name = "label2";
            label2.Size = new Size(196, 21);
            label2.TabIndex = 15;
            label2.Text = "Plataforma Selecionada:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(570, 127);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 16;
            label3.Text = "Plataformas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Steam);
            Controls.Add(label1);
            Controls.Add(botaoAplicar);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(Nintendo);
            Controls.Add(Xbox);
            Controls.Add(Playstation);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox Playstation;
        private CheckBox Xbox;
        private CheckBox Nintendo;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button botaoAplicar;
        private RadioButton radioButton4;
        private Label label1;
        private CheckBox Steam;
        private Label label2;
        private Label label3;
    }
}
