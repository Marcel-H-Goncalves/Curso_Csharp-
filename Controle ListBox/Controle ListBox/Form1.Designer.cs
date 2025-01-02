namespace Controle_ListBox
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
            listBoxPlataforma = new ListBox();
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            SuspendLayout();
            // 
            // listBoxPlataforma
            // 
            listBoxPlataforma.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxPlataforma.FormattingEnabled = true;
            listBoxPlataforma.ItemHeight = 25;
            listBoxPlataforma.Items.AddRange(new object[] { "Playstation", "Xbox", "Steam", "Mobile" });
            listBoxPlataforma.Location = new Point(34, 83);
            listBoxPlataforma.Name = "listBoxPlataforma";
            listBoxPlataforma.Size = new Size(407, 229);
            listBoxPlataforma.TabIndex = 0;
            listBoxPlataforma.SelectedIndexChanged += listBoxPlataforma_SelectedIndexChanged;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdicionar.Location = new Point(34, 317);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(177, 55);
            buttonAdicionar.TabIndex = 1;
            buttonAdicionar.Text = "Adicionar Plataforma";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemover.Location = new Point(265, 317);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(176, 55);
            buttonRemover.TabIndex = 2;
            buttonRemover.Text = "Remover Plataforma";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 450);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Controls.Add(listBoxPlataforma);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPlataforma;
        private Button buttonAdicionar;
        private Button buttonRemover;
    }
}
