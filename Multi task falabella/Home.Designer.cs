namespace Multi_task_falabella
{
    partial class Home
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
            this.btnPublicidadSS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPublicidadSS
            // 
            this.btnPublicidadSS.Location = new System.Drawing.Point(100, 50);
            this.btnPublicidadSS.Name = "btnPublicidadSS";
            this.btnPublicidadSS.Size = new System.Drawing.Size(100, 23);
            this.btnPublicidadSS.TabIndex = 0;
            this.btnPublicidadSS.Text = "Publicidad SS";
            this.btnPublicidadSS.UseVisualStyleBackColor = true;
            this.btnPublicidadSS.Click += new System.EventHandler(this.btnPublicidadSS_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPublicidadSS);
            this.Name = "MainForm";
            this.Text = "Publicidad SS App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPublicidadSS;
    }
}
