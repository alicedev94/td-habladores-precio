namespace phApp
{
    partial class PROGRESO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Lbl_Procesando = new System.Windows.Forms.Label();
            this.BGW1 = new System.ComponentModel.BackgroundWorker();
            this.T1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BGW2 = new System.ComponentModel.BackgroundWorker();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Lbl_Actual = new System.Windows.Forms.Label();
            this.PGB = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Procesando
            // 
            this.Lbl_Procesando.AutoSize = true;
            this.Lbl_Procesando.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Procesando.Location = new System.Drawing.Point(41, 7);
            this.Lbl_Procesando.Name = "Lbl_Procesando";
            this.Lbl_Procesando.Size = new System.Drawing.Size(118, 21);
            this.Lbl_Procesando.TabIndex = 0;
            this.Lbl_Procesando.Text = "PROCESANDO";
            // 
            // BGW1
            // 
            this.BGW1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Lbl_Procesando);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 37);
            this.panel1.TabIndex = 1;
            // 
            // BGW2
            // 
            this.BGW2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW2_DoWork);
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Total.Location = new System.Drawing.Point(12, 59);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(70, 15);
            this.Lbl_Total.TabIndex = 2;
            this.Lbl_Total.Text = "PROGRESO";
            // 
            // Lbl_Actual
            // 
            this.Lbl_Actual.AutoSize = true;
            this.Lbl_Actual.Location = new System.Drawing.Point(35, 87);
            this.Lbl_Actual.Name = "Lbl_Actual";
            this.Lbl_Actual.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Actual.TabIndex = 3;
            this.Lbl_Actual.Text = "label4";
            // 
            // PGB
            // 
            this.PGB.Location = new System.Drawing.Point(12, 117);
            this.PGB.Name = "PGB";
            this.PGB.Size = new System.Drawing.Size(205, 23);
            this.PGB.TabIndex = 4;
            // 
            // PROGRESO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 156);
            this.ControlBox = false;
            this.Controls.Add(this.PGB);
            this.Controls.Add(this.Lbl_Actual);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PROGRESO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progreso";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Procesando;
        private System.ComponentModel.BackgroundWorker BGW1;
        private System.Windows.Forms.Timer T1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker BGW2;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Label Lbl_Actual;
        private System.Windows.Forms.ProgressBar PGB;
    }
}