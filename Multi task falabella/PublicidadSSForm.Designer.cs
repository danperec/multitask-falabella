using System;

namespace Multi_task_falabella
{
    partial class PublicidadSSForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnVolverSSH = new System.Windows.Forms.Button();
            this.envioSS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolverSSH
            // 
            this.btnVolverSSH.Location = new System.Drawing.Point(241, 413);
            this.btnVolverSSH.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverSSH.Name = "btnVolverSSH";
            this.btnVolverSSH.Size = new System.Drawing.Size(147, 33);
            this.btnVolverSSH.TabIndex = 0;
            this.btnVolverSSH.Text = "VOLVER";
            this.btnVolverSSH.UseVisualStyleBackColor = true;
            this.btnVolverSSH.Click += new System.EventHandler(this.btnVolverSSH_Click);
            // 
            // envioSS
            // 
            this.envioSS.Location = new System.Drawing.Point(253, 107);
            this.envioSS.Name = "envioSS";
            this.envioSS.Size = new System.Drawing.Size(123, 57);
            this.envioSS.TabIndex = 1;
            this.envioSS.Text = "Enviar SS";
            this.envioSS.UseVisualStyleBackColor = true;
            this.envioSS.Click += new System.EventHandler(this.btnEnvioSS_Click);
            // 
            // PublicidadSSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 542);
            this.Controls.Add(this.envioSS);
            this.Controls.Add(this.btnVolverSSH);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PublicidadSSForm";
            this.Text = "Publicidad SS";
            this.ResumeLayout(false);

        }

  
        #endregion

        private System.Windows.Forms.Button btnVolverSSH;
        private System.Windows.Forms.Button envioSS;
    }
}
