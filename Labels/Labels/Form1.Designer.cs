namespace Labels
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
            MinhaLabel = new Label();
            SuspendLayout();
            // 
            // MinhaLabel
            // 
            MinhaLabel.AutoSize = true;
            MinhaLabel.Font = new Font("Pristina", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinhaLabel.ForeColor = SystemColors.ActiveCaption;
            MinhaLabel.Location = new Point(197, 165);
            MinhaLabel.Name = "MinhaLabel";
            MinhaLabel.Size = new Size(405, 63);
            MinhaLabel.TabIndex = 0;
            MinhaLabel.Text = "Minha Primeira Label";
            MinhaLabel.Click += MinhaLabel_Click;
            MinhaLabel.DoubleClick += MinhaLabel_DoubleClick;
            MinhaLabel.MouseEnter += MinhaLabel_MouseEnter;
            MinhaLabel.MouseLeave += MinhaLabel_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MinhaLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MinhaLabel;
    }
}
