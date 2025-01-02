namespace Controle_MaskedTextBox
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
            maskedTextBoxNumeros = new MaskedTextBox();
            maskedTextBoxCelular = new MaskedTextBox();
            maskedTextBoxSenha = new MaskedTextBox();
            maskedTextBoxDecimais = new MaskedTextBox();
            maskedTextBoxHora = new MaskedTextBox();
            maskedTextBoxPlacaDeCarro = new MaskedTextBox();
            maskedTextBoxData = new MaskedTextBox();
            maskedTextBoxLetras = new MaskedTextBox();
            botaoVerifica = new Button();
            SuspendLayout();
            // 
            // maskedTextBoxNumeros
            // 
            maskedTextBoxNumeros.Location = new Point(12, 12);
            maskedTextBoxNumeros.Name = "maskedTextBoxNumeros";
            maskedTextBoxNumeros.Size = new Size(420, 23);
            maskedTextBoxNumeros.TabIndex = 0;
            // 
            // maskedTextBoxCelular
            // 
            maskedTextBoxCelular.Location = new Point(12, 215);
            maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            maskedTextBoxCelular.Size = new Size(420, 23);
            maskedTextBoxCelular.TabIndex = 1;
            // 
            // maskedTextBoxSenha
            // 
            maskedTextBoxSenha.Location = new Point(12, 186);
            maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            maskedTextBoxSenha.Size = new Size(420, 23);
            maskedTextBoxSenha.TabIndex = 2;
            // 
            // maskedTextBoxDecimais
            // 
            maskedTextBoxDecimais.Location = new Point(12, 157);
            maskedTextBoxDecimais.Name = "maskedTextBoxDecimais";
            maskedTextBoxDecimais.Size = new Size(420, 23);
            maskedTextBoxDecimais.TabIndex = 3;
            // 
            // maskedTextBoxHora
            // 
            maskedTextBoxHora.Location = new Point(12, 128);
            maskedTextBoxHora.Name = "maskedTextBoxHora";
            maskedTextBoxHora.Size = new Size(420, 23);
            maskedTextBoxHora.TabIndex = 4;
            // 
            // maskedTextBoxPlacaDeCarro
            // 
            maskedTextBoxPlacaDeCarro.Location = new Point(12, 99);
            maskedTextBoxPlacaDeCarro.Name = "maskedTextBoxPlacaDeCarro";
            maskedTextBoxPlacaDeCarro.Size = new Size(420, 23);
            maskedTextBoxPlacaDeCarro.TabIndex = 5;
            // 
            // maskedTextBoxData
            // 
            maskedTextBoxData.Location = new Point(12, 70);
            maskedTextBoxData.Name = "maskedTextBoxData";
            maskedTextBoxData.Size = new Size(420, 23);
            maskedTextBoxData.TabIndex = 6;
            // 
            // maskedTextBoxLetras
            // 
            maskedTextBoxLetras.Location = new Point(12, 41);
            maskedTextBoxLetras.Name = "maskedTextBoxLetras";
            maskedTextBoxLetras.Size = new Size(420, 23);
            maskedTextBoxLetras.TabIndex = 7;
            // 
            // botaoVerifica
            // 
            botaoVerifica.Location = new Point(48, 244);
            botaoVerifica.Name = "botaoVerifica";
            botaoVerifica.Size = new Size(343, 97);
            botaoVerifica.TabIndex = 8;
            botaoVerifica.Text = "Verifica";
            botaoVerifica.UseVisualStyleBackColor = true;
            botaoVerifica.Click += botaoVerifica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botaoVerifica);
            Controls.Add(maskedTextBoxLetras);
            Controls.Add(maskedTextBoxData);
            Controls.Add(maskedTextBoxPlacaDeCarro);
            Controls.Add(maskedTextBoxHora);
            Controls.Add(maskedTextBoxDecimais);
            Controls.Add(maskedTextBoxSenha);
            Controls.Add(maskedTextBoxCelular);
            Controls.Add(maskedTextBoxNumeros);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxNumeros;
        private MaskedTextBox maskedTextBoxCelular;
        private MaskedTextBox maskedTextBoxSenha;
        private MaskedTextBox maskedTextBoxDecimais;
        private MaskedTextBox maskedTextBoxHora;
        private MaskedTextBox maskedTextBoxPlacaDeCarro;
        private MaskedTextBox maskedTextBoxData;
        private MaskedTextBox maskedTextBoxLetras;
        private Button botaoVerifica;
    }
}
