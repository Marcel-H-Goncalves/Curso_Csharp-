﻿namespace TrackBar_e_ProgressBar
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
            progressBarPassivo = new ProgressBar();
            trackBarAtiva = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBarAtiva).BeginInit();
            SuspendLayout();
            // 
            // progressBarPassivo
            // 
            progressBarPassivo.Location = new Point(45, 100);
            progressBarPassivo.Name = "progressBarPassivo";
            progressBarPassivo.Size = new Size(355, 26);
            progressBarPassivo.TabIndex = 0;
            // 
            // trackBarAtiva
            // 
            trackBarAtiva.Location = new Point(45, 132);
            trackBarAtiva.Maximum = 100;
            trackBarAtiva.Name = "trackBarAtiva";
            trackBarAtiva.Size = new Size(355, 45);
            trackBarAtiva.TabIndex = 1;
            trackBarAtiva.ValueChanged += trackBarAtiva_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBarAtiva);
            Controls.Add(progressBarPassivo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBarAtiva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBarPassivo;
        private TrackBar trackBarAtiva;
    }
}
