namespace Cliente_WebService
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
            buttonEnviaString = new Button();
            buttonPegaString = new Button();
            textBoxEnviaString = new TextBox();
            textBoxPegaString = new TextBox();
            SuspendLayout();
            // 
            // buttonEnviaString
            // 
            buttonEnviaString.Location = new Point(12, 191);
            buttonEnviaString.Name = "buttonEnviaString";
            buttonEnviaString.Size = new Size(286, 140);
            buttonEnviaString.TabIndex = 0;
            buttonEnviaString.Text = "Envia String";
            buttonEnviaString.UseVisualStyleBackColor = true;
            buttonEnviaString.Click += buttonEnviaString_Click;
            // 
            // buttonPegaString
            // 
            buttonPegaString.Location = new Point(354, 191);
            buttonPegaString.Name = "buttonPegaString";
            buttonPegaString.Size = new Size(286, 140);
            buttonPegaString.TabIndex = 1;
            buttonPegaString.Text = "Pega String";
            buttonPegaString.UseVisualStyleBackColor = true;
            buttonPegaString.Click += buttonPegaString_Click;
            // 
            // textBoxEnviaString
            // 
            textBoxEnviaString.Location = new Point(12, 162);
            textBoxEnviaString.Name = "textBoxEnviaString";
            textBoxEnviaString.Size = new Size(286, 23);
            textBoxEnviaString.TabIndex = 2;
            // 
            // textBoxPegaString
            // 
            textBoxPegaString.Location = new Point(354, 162);
            textBoxPegaString.Name = "textBoxPegaString";
            textBoxPegaString.Size = new Size(286, 23);
            textBoxPegaString.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 429);
            Controls.Add(textBoxPegaString);
            Controls.Add(textBoxEnviaString);
            Controls.Add(buttonPegaString);
            Controls.Add(buttonEnviaString);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnviaString;
        private Button buttonPegaString;
        private TextBox textBoxEnviaString;
        private TextBox textBoxPegaString;
    }
}
