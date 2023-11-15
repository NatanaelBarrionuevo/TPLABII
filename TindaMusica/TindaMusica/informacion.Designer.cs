namespace menuslide
{
    partial class informacion
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
            this.lnk = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnk
            // 
            this.lnk.AutoSize = true;
            this.lnk.Location = new System.Drawing.Point(362, 247);
            this.lnk.Name = "lnk";
            this.lnk.Size = new System.Drawing.Size(46, 13);
            this.lnk.TabIndex = 0;
            this.lnk.TabStop = true;
            this.lnk.Text = "clic aqui";
            this.lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "nuestra pagina cheta";
            // 
            // informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "informacion";
            this.Text = "informacion";
            this.Load += new System.EventHandler(this.informacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk;
        private System.Windows.Forms.Label label1;
    }
}