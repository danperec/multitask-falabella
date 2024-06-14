using System;

namespace Multi_task_falabella
{
    partial class PublicidadSSForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnEnvioSS;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnVolverSSH;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void btnVolverSSH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            this.btnEnvioSS = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnVolverSSH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnvioSS
            // 
            this.btnEnvioSS.Location = new System.Drawing.Point(270, 20);
            this.btnEnvioSS.Name = "btnEnvioSS";
            this.btnEnvioSS.Size = new System.Drawing.Size(100, 30);
            this.btnEnvioSS.TabIndex = 0;
            this.btnEnvioSS.Text = "Enviar SS";
            this.btnEnvioSS.UseVisualStyleBackColor = true;
            this.btnEnvioSS.Click += new System.EventHandler(this.btnEnvioSS_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 30);
            this.lblStatus.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 100);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(580, 30);
            this.progressBar.TabIndex = 2;
            // 
            // btnVolverSSH
            // 
            this.btnVolverSSH.Location = new System.Drawing.Point(270, 140);
            this.btnVolverSSH.Name = "btnVolverSSH";
            this.btnVolverSSH.Size = new System.Drawing.Size(100, 30);
            this.btnVolverSSH.TabIndex = 3;
            this.btnVolverSSH.Text = "Volver";
            this.btnVolverSSH.UseVisualStyleBackColor = true;
            this.btnVolverSSH.Click += new System.EventHandler(this.btnVolverSSH_Click);
            // 
            // PublicidadSSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 200);
            this.Controls.Add(this.btnVolverSSH);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnEnvioSS);
            this.Name = "PublicidadSSForm";
            this.Text = "Publicidad SS";
            this.Load += new System.EventHandler(this.PublicidadSSForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}



