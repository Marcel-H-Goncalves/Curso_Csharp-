namespace TabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new TabPage();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            trackBar1 = new TrackBar();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            botaoTab1 = new Button();
            botaoTab2 = new Button();
            botaoMudaFundoTab1 = new Button();
            botaoMudaFundoTab2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(60, 96);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(384, 327);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(376, 299);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pagina 1";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(207, 65);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(95, 25);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Opção 2 ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(207, 23);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 25);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Opção 1 ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(7, 58);
            button2.Name = "button2";
            button2.Size = new Size(95, 36);
            button2.TabIndex = 1;
            button2.Text = "Opção 2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(7, 16);
            button1.Name = "button1";
            button1.Size = new Size(95, 36);
            button1.TabIndex = 0;
            button1.Text = "Opção 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(trackBar1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(376, 299);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pagina 2";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(0, 248);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(364, 45);
            trackBar1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 29);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // botaoTab1
            // 
            botaoTab1.Location = new Point(607, 149);
            botaoTab1.Name = "botaoTab1";
            botaoTab1.Size = new Size(121, 23);
            botaoTab1.TabIndex = 3;
            botaoTab1.Text = "Tab1";
            botaoTab1.UseVisualStyleBackColor = true;
            botaoTab1.Click += botaoTab1_Click;
            // 
            // botaoTab2
            // 
            botaoTab2.Location = new Point(607, 120);
            botaoTab2.Name = "botaoTab2";
            botaoTab2.Size = new Size(121, 23);
            botaoTab2.TabIndex = 2;
            botaoTab2.Text = "Tab2";
            botaoTab2.UseVisualStyleBackColor = true;
            botaoTab2.Click += botaoTab2_Click;
            // 
            // botaoMudaFundoTab1
            // 
            botaoMudaFundoTab1.Location = new Point(607, 178);
            botaoMudaFundoTab1.Name = "botaoMudaFundoTab1";
            botaoMudaFundoTab1.Size = new Size(121, 23);
            botaoMudaFundoTab1.TabIndex = 4;
            botaoMudaFundoTab1.Text = "Muda fundo tab1";
            botaoMudaFundoTab1.UseVisualStyleBackColor = true;
            botaoMudaFundoTab1.Click += botaoMudaFundoTab1_Click;
            // 
            // botaoMudaFundoTab2
            // 
            botaoMudaFundoTab2.Location = new Point(607, 207);
            botaoMudaFundoTab2.Name = "botaoMudaFundoTab2";
            botaoMudaFundoTab2.Size = new Size(121, 26);
            botaoMudaFundoTab2.TabIndex = 5;
            botaoMudaFundoTab2.Text = "Muda fundo tab2";
            botaoMudaFundoTab2.UseVisualStyleBackColor = true;
            botaoMudaFundoTab2.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botaoMudaFundoTab2);
            Controls.Add(botaoMudaFundoTab1);
            Controls.Add(botaoTab1);
            Controls.Add(botaoTab2);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox checkBox1;
        private Button button2;
        private Button button1;
        private TabPage tabPage2;
        private CheckBox checkBox2;
        private TrackBar trackBar1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button botaoTab1;
        private Button botaoTab2;
        private Button botaoMudaFundoTab1;
        private Button botaoMudaFundoTab2;
    }
}
