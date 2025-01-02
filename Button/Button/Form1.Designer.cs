namespace Button
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
            meuBotao = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // meuBotao
            // 
            meuBotao.BackColor = SystemColors.HotTrack;
            meuBotao.Font = new Font("Old English Text MT", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            meuBotao.Location = new Point(142, 145);
            meuBotao.Name = "meuBotao";
            meuBotao.Size = new Size(514, 155);
            meuBotao.TabIndex = 0;
            meuBotao.Text = "Meu Primeiro Botão";
            meuBotao.UseVisualStyleBackColor = false;
            meuBotao.Click += meuBotao_Click;
            meuBotao.MouseEnter += meuBotao_MouseEnter;
            meuBotao.MouseLeave += meuBotao_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(meuBotao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button meuBotao;
    }
}
