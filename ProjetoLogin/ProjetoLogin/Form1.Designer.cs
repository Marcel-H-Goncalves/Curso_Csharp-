namespace ProjetoLogin
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
            labelLogin = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            maskedTextBoxSenha = new MaskedTextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.None;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Sitka Display Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(329, 103);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(188, 92);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display Semibold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 234);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display Semibold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 267);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.None;
            textBoxUsuario.Location = new Point(329, 241);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(242, 23);
            textBoxUsuario.TabIndex = 3;
            // 
            // maskedTextBoxSenha
            // 
            maskedTextBoxSenha.Anchor = AnchorStyles.None;
            maskedTextBoxSenha.Location = new Point(329, 270);
            maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            maskedTextBoxSenha.PasswordChar = '*';
            maskedTextBoxSenha.Size = new Size(242, 23);
            maskedTextBoxSenha.TabIndex = 5;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.Font = new Font("Sitka Display Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(244, 298);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(327, 85);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 502);
            Controls.Add(buttonLogin);
            Controls.Add(maskedTextBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelLogin);
            MaximumSize = new Size(839, 541);
            MinimumSize = new Size(375, 379);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsuario;
        private MaskedTextBox maskedTextBoxSenha;
        private Button buttonLogin;
    }
}
