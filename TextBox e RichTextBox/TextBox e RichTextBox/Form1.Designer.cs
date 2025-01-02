namespace TextBox_e_RichTextBox
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
            MeuRichTextBox = new RichTextBox();
            MeuTextBox = new TextBox();
            BotaoInverte = new Button();
            SuspendLayout();
            // 
            // MeuRichTextBox
            // 
            MeuRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MeuRichTextBox.Location = new Point(12, 41);
            MeuRichTextBox.Name = "MeuRichTextBox";
            MeuRichTextBox.Size = new Size(776, 336);
            MeuRichTextBox.TabIndex = 0;
            MeuRichTextBox.Text = "";
            // 
            // MeuTextBox
            // 
            MeuTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MeuTextBox.Location = new Point(12, 12);
            MeuTextBox.Name = "MeuTextBox";
            MeuTextBox.Size = new Size(776, 23);
            MeuTextBox.TabIndex = 1;
            // 
            // BotaoInverte
            // 
            BotaoInverte.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BotaoInverte.Font = new Font("Sitka Heading", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BotaoInverte.Location = new Point(12, 383);
            BotaoInverte.Name = "BotaoInverte";
            BotaoInverte.Size = new Size(776, 55);
            BotaoInverte.TabIndex = 2;
            BotaoInverte.Text = "Clique Aqui Para Inverter";
            BotaoInverte.UseVisualStyleBackColor = true;
            BotaoInverte.Click += BotaoInverte_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BotaoInverte);
            Controls.Add(MeuTextBox);
            Controls.Add(MeuRichTextBox);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox MeuRichTextBox;
        private TextBox MeuTextBox;
        private Button BotaoInverte;
    }
}
