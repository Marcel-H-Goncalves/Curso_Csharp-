namespace ComboBox
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
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new Label();
            buttonConfirmar = new Button();
            label2 = new Label();
            Resultado = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Steam", "Playstation", "Xbox", "Mobile" });
            comboBox1.Location = new Point(21, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(382, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 35);
            label1.TabIndex = 1;
            label1.Text = "Escolha a sua Plataforma:";
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Font = new Font("Sitka Display Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConfirmar.Location = new Point(153, 89);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(112, 49);
            buttonConfirmar.TabIndex = 2;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 191);
            label2.Name = "label2";
            label2.Size = new Size(263, 35);
            label2.TabIndex = 3;
            label2.Text = "Plataforma escolhida foi:";
            // 
            // Resultado
            // 
            Resultado.Anchor = AnchorStyles.None;
            Resultado.AutoSize = true;
            Resultado.Enabled = false;
            Resultado.Font = new Font("Sitka Display Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resultado.Location = new Point(281, 191);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(0, 35);
            Resultado.TabIndex = 4;
            Resultado.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 346);
            Controls.Add(Resultado);
            Controls.Add(label2);
            Controls.Add(buttonConfirmar);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            MaximumSize = new Size(451, 385);
            MinimumSize = new Size(451, 385);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Label label1;
        private Button buttonConfirmar;
        private Label label2;
        private Label Resultado;
    }
}
