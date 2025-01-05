namespace MenuStrip
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            arquivo = new ToolStripMenuItem();
            novo = new ToolStripMenuItem();
            projeto = new ToolStripMenuItem();
            repositorio = new ToolStripMenuItem();
            abrir = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            pasta = new ToolStripMenuItem();
            editar = new ToolStripMenuItem();
            IrPara = new ToolStripMenuItem();
            localizar = new ToolStripMenuItem();
            exibir = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivo, editar, exibir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivo
            // 
            arquivo.DropDownItems.AddRange(new ToolStripItem[] { novo, abrir });
            arquivo.Name = "arquivo";
            arquivo.Size = new Size(61, 20);
            arquivo.Text = "Arquivo";
            // 
            // novo
            // 
            novo.DropDownItems.AddRange(new ToolStripItem[] { projeto, repositorio });
            novo.Name = "novo";
            novo.Size = new Size(103, 22);
            novo.Text = "Novo";
            // 
            // projeto
            // 
            projeto.Name = "projeto";
            projeto.Size = new Size(134, 22);
            projeto.Text = "Projeto";
            // 
            // repositorio
            // 
            repositorio.Name = "repositorio";
            repositorio.Size = new Size(134, 22);
            repositorio.Text = "Repositório";
            // 
            // abrir
            // 
            abrir.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, pasta });
            abrir.Name = "abrir";
            abrir.Size = new Size(103, 22);
            abrir.Text = "Abrir";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "Projeto/ Repositório";
            // 
            // pasta
            // 
            pasta.Name = "pasta";
            pasta.Size = new Size(180, 22);
            pasta.Text = "Pasta";
            // 
            // editar
            // 
            editar.DropDownItems.AddRange(new ToolStripItem[] { IrPara, localizar });
            editar.Name = "editar";
            editar.Size = new Size(49, 20);
            editar.Text = "Editar";
            // 
            // IrPara
            // 
            IrPara.Name = "IrPara";
            IrPara.Size = new Size(180, 22);
            IrPara.Text = "Ir Para";
            // 
            // localizar
            // 
            localizar.Name = "localizar";
            localizar.Size = new Size(180, 22);
            localizar.Text = "Localizar Arquivo";
            // 
            // exibir
            // 
            exibir.Name = "exibir";
            exibir.Size = new Size(47, 20);
            exibir.Text = "Exibir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem arquivo;
        private ToolStripMenuItem novo;
        private ToolStripMenuItem projeto;
        private ToolStripMenuItem repositorio;
        private ToolStripMenuItem abrir;
        private ToolStripMenuItem editar;
        private ToolStripMenuItem exibir;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem pasta;
        private ToolStripMenuItem IrPara;
        private ToolStripMenuItem localizar;
    }
}
