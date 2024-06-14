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
            this.btnSalirHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPublicidadSS
            // 
            this.btnPublicidadSS.Location = new System.Drawing.Point(57, 45);
            this.btnPublicidadSS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPublicidadSS.Name = "btnPublicidadSS";
            this.btnPublicidadSS.Size = new System.Drawing.Size(133, 28);
            this.btnPublicidadSS.TabIndex = 0;
            this.btnPublicidadSS.Text = "PUBLICIDAD SS";
            this.btnPublicidadSS.UseVisualStyleBackColor = true;
            this.btnPublicidadSS.Click += new System.EventHandler(this.btnPublicidadSS_Click);
            // 
            // btnSalirHome
            // 
            this.btnSalirHome.Location = new System.Drawing.Point(486, 471);
            this.btnSalirHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalirHome.Name = "btnSalirHome";
            this.btnSalirHome.Size = new System.Drawing.Size(133, 28);
            this.btnSalirHome.TabIndex = 1;
            this.btnSalirHome.Text = "SALIR";
            this.btnSalirHome.UseVisualStyleBackColor = true;
            this.btnSalirHome.Click += new System.EventHandler(this.btnSalirHome_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 524);
            this.Controls.Add(this.btnSalirHome);
            this.Controls.Add(this.btnPublicidadSS);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.Text = "Publicidad SS App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPublicidadSS;
        private System.Windows.Forms.Button btnSalirHome;
    }
}