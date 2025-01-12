namespace Decimo_Primeiro_Projeto
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonCadastrar = new Button();
            textBoxNumeroCasa = new TextBox();
            textBoxNomeRua = new TextBox();
            textBoxDataNascimento = new TextBox();
            textBoxNumeroDocumento = new TextBox();
            textBoxNomeCompleto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            buttonExcluir = new Button();
            buttonBusca = new Button();
            textBoxBuscaNumeroDocumento = new TextBox();
            labelNumeroCasa = new Label();
            labelNomeRua = new Label();
            labelDataNascimento = new Label();
            labelNomeCompleto = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(675, 424);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonCadastrar);
            tabPage1.Controls.Add(textBoxNumeroCasa);
            tabPage1.Controls.Add(textBoxNomeRua);
            tabPage1.Controls.Add(textBoxDataNascimento);
            tabPage1.Controls.Add(textBoxNumeroDocumento);
            tabPage1.Controls.Add(textBoxNomeCompleto);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(667, 396);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(192, 268);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(256, 96);
            buttonCadastrar.TabIndex = 10;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // textBoxNumeroCasa
            // 
            textBoxNumeroCasa.Location = new Point(131, 197);
            textBoxNumeroCasa.Name = "textBoxNumeroCasa";
            textBoxNumeroCasa.Size = new Size(392, 23);
            textBoxNumeroCasa.TabIndex = 9;
            // 
            // textBoxNomeRua
            // 
            textBoxNomeRua.Location = new Point(115, 153);
            textBoxNomeRua.Name = "textBoxNomeRua";
            textBoxNomeRua.Size = new Size(408, 23);
            textBoxNomeRua.TabIndex = 8;
            // 
            // textBoxDataNascimento
            // 
            textBoxDataNascimento.Location = new Point(150, 109);
            textBoxDataNascimento.Name = "textBoxDataNascimento";
            textBoxDataNascimento.Size = new Size(373, 23);
            textBoxDataNascimento.TabIndex = 7;
            // 
            // textBoxNumeroDocumento
            // 
            textBoxNumeroDocumento.Location = new Point(171, 65);
            textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            textBoxNumeroDocumento.Size = new Size(352, 23);
            textBoxNumeroDocumento.TabIndex = 6;
            // 
            // textBoxNomeCompleto
            // 
            textBoxNomeCompleto.Location = new Point(132, 21);
            textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            textBoxNomeCompleto.Size = new Size(391, 23);
            textBoxNomeCompleto.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 205);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 4;
            label5.Text = "Número Da Casa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 161);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "Nome Da Rua:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 117);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 2;
            label3.Text = "Data De Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 73);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 1;
            label2.Text = "Número Do Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonExcluir);
            tabPage2.Controls.Add(buttonBusca);
            tabPage2.Controls.Add(textBoxBuscaNumeroDocumento);
            tabPage2.Controls.Add(labelNumeroCasa);
            tabPage2.Controls.Add(labelNomeRua);
            tabPage2.Controls.Add(labelDataNascimento);
            tabPage2.Controls.Add(labelNomeCompleto);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(667, 396);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Modificações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcluir.Location = new Point(361, 285);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(160, 83);
            buttonExcluir.TabIndex = 17;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonBusca
            // 
            buttonBusca.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBusca.Location = new Point(140, 285);
            buttonBusca.Name = "buttonBusca";
            buttonBusca.Size = new Size(160, 83);
            buttonBusca.TabIndex = 16;
            buttonBusca.Text = "Busca";
            buttonBusca.UseVisualStyleBackColor = true;
            buttonBusca.Click += buttonBusca_Click;
            // 
            // textBoxBuscaNumeroDocumento
            // 
            textBoxBuscaNumeroDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxBuscaNumeroDocumento.Location = new Point(166, 60);
            textBoxBuscaNumeroDocumento.Name = "textBoxBuscaNumeroDocumento";
            textBoxBuscaNumeroDocumento.Size = new Size(286, 23);
            textBoxBuscaNumeroDocumento.TabIndex = 15;
            // 
            // labelNumeroCasa
            // 
            labelNumeroCasa.AutoSize = true;
            labelNumeroCasa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNumeroCasa.Location = new Point(166, 244);
            labelNumeroCasa.Name = "labelNumeroCasa";
            labelNumeroCasa.Size = new Size(12, 15);
            labelNumeroCasa.TabIndex = 14;
            labelNumeroCasa.Text = "-";
            // 
            // labelNomeRua
            // 
            labelNomeRua.AutoSize = true;
            labelNomeRua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNomeRua.Location = new Point(166, 200);
            labelNomeRua.Name = "labelNomeRua";
            labelNomeRua.Size = new Size(12, 15);
            labelNomeRua.TabIndex = 13;
            labelNomeRua.Text = "-";
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDataNascimento.Location = new Point(166, 156);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(12, 15);
            labelDataNascimento.TabIndex = 12;
            labelDataNascimento.Text = "-";
            // 
            // labelNomeCompleto
            // 
            labelNomeCompleto.AutoSize = true;
            labelNomeCompleto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNomeCompleto.Location = new Point(166, 112);
            labelNomeCompleto.Name = "labelNomeCompleto";
            labelNomeCompleto.Size = new Size(12, 15);
            labelNomeCompleto.TabIndex = 10;
            labelNomeCompleto.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(5, 244);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 9;
            label6.Text = "Número Da Casa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(5, 200);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 8;
            label7.Text = "Nome Da Rua:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(5, 156);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 7;
            label8.Text = "Data De Nascimento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(6, 68);
            label9.Name = "label9";
            label9.Size = new Size(144, 15);
            label9.TabIndex = 6;
            label9.Text = "Número Do Documento:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(6, 112);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 5;
            label10.Text = "Nome Completo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 448);
            Controls.Add(tabControl1);
            MaximumSize = new Size(715, 487);
            MinimumSize = new Size(715, 487);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TextBox textBoxNumeroCasa;
        private TextBox textBoxNomeRua;
        private TextBox textBoxDataNascimento;
        private TextBox textBoxNumeroDocumento;
        private TextBox textBoxNomeCompleto;
        private Button buttonCadastrar;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button buttonExcluir;
        private Button buttonBusca;
        private TextBox textBoxBuscaNumeroDocumento;
        private Label labelNumeroCasa;
        private Label labelNomeRua;
        private Label labelDataNascimento;
        private Label labelNomeCompleto;
    }
}
