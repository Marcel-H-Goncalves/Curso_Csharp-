namespace Controle_Timer
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
            components = new System.ComponentModel.Container();
            timerInterfaceGrafica = new System.Windows.Forms.Timer(components);
            buttonHabilitarTimerInterfaceGrafica = new Button();
            buttonDesabilitarTimerInterfaceGrafica = new Button();
            buttonHabilitarTimerPorCodigo = new Button();
            buttonDesabilitarTimerPorCodigo = new Button();
            SuspendLayout();
            // 
            // timerInterfaceGrafica
            // 
            timerInterfaceGrafica.Interval = 5000;
            timerInterfaceGrafica.Tick += timerInterfaceGrafica_Tick;
            // 
            // buttonHabilitarTimerInterfaceGrafica
            // 
            buttonHabilitarTimerInterfaceGrafica.Location = new Point(35, 81);
            buttonHabilitarTimerInterfaceGrafica.Name = "buttonHabilitarTimerInterfaceGrafica";
            buttonHabilitarTimerInterfaceGrafica.Size = new Size(427, 39);
            buttonHabilitarTimerInterfaceGrafica.TabIndex = 0;
            buttonHabilitarTimerInterfaceGrafica.Text = "Habilitar Timer Interface Gráfica";
            buttonHabilitarTimerInterfaceGrafica.UseVisualStyleBackColor = true;
            buttonHabilitarTimerInterfaceGrafica.Click += buttonHabilitaTimerInterfaceGrafica_Click;
            // 
            // buttonDesabilitarTimerInterfaceGrafica
            // 
            buttonDesabilitarTimerInterfaceGrafica.Location = new Point(35, 126);
            buttonDesabilitarTimerInterfaceGrafica.Name = "buttonDesabilitarTimerInterfaceGrafica";
            buttonDesabilitarTimerInterfaceGrafica.Size = new Size(427, 39);
            buttonDesabilitarTimerInterfaceGrafica.TabIndex = 1;
            buttonDesabilitarTimerInterfaceGrafica.Text = "Desabilitar Timer Interface Gráfica";
            buttonDesabilitarTimerInterfaceGrafica.UseVisualStyleBackColor = true;
            buttonDesabilitarTimerInterfaceGrafica.Click += button2_Click;
            // 
            // buttonHabilitarTimerPorCodigo
            // 
            buttonHabilitarTimerPorCodigo.Location = new Point(35, 201);
            buttonHabilitarTimerPorCodigo.Name = "buttonHabilitarTimerPorCodigo";
            buttonHabilitarTimerPorCodigo.Size = new Size(167, 59);
            buttonHabilitarTimerPorCodigo.TabIndex = 2;
            buttonHabilitarTimerPorCodigo.Text = "Habilitar Timer Por Código";
            buttonHabilitarTimerPorCodigo.UseVisualStyleBackColor = true;
            buttonHabilitarTimerPorCodigo.Click += buttonHabilitarTimerPorCodigo_Click;
            // 
            // buttonDesabilitarTimerPorCodigo
            // 
            buttonDesabilitarTimerPorCodigo.Location = new Point(295, 201);
            buttonDesabilitarTimerPorCodigo.Name = "buttonDesabilitarTimerPorCodigo";
            buttonDesabilitarTimerPorCodigo.Size = new Size(167, 59);
            buttonDesabilitarTimerPorCodigo.TabIndex = 3;
            buttonDesabilitarTimerPorCodigo.Text = "Desabilitar Timer Por Código";
            buttonDesabilitarTimerPorCodigo.UseVisualStyleBackColor = true;
            buttonDesabilitarTimerPorCodigo.Click += buttonDesabilitarTimerPorCodigo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDesabilitarTimerPorCodigo);
            Controls.Add(buttonHabilitarTimerPorCodigo);
            Controls.Add(buttonDesabilitarTimerInterfaceGrafica);
            Controls.Add(buttonHabilitarTimerInterfaceGrafica);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerInterfaceGrafica;
        private Button buttonHabilitarTimerInterfaceGrafica;
        private Button buttonDesabilitarTimerInterfaceGrafica;
        private Button buttonHabilitarTimerPorCodigo;
        private Button buttonDesabilitarTimerPorCodigo;
    }
}
