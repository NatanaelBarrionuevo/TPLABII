namespace menuslide
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidebar = new System.Windows.Forms.Panel();
            this.pnlsalir = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pnlinfo = new System.Windows.Forms.Panel();
            this.btninformacion = new System.Windows.Forms.Button();
            this.pnlayuda = new System.Windows.Forms.Panel();
            this.btnayuda = new System.Windows.Forms.Button();
            this.pnlcompra = new System.Windows.Forms.Panel();
            this.btncompra = new System.Windows.Forms.Button();
            this.pnlhome = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.btnmenu = new System.Windows.Forms.Button();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.pnlbar = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlhijos = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.pnlsalir.SuspendLayout();
            this.pnlinfo.SuspendLayout();
            this.pnlayuda.SuspendLayout();
            this.pnlcompra.SuspendLayout();
            this.pnlhome.SuspendLayout();
            this.pnlmenu.SuspendLayout();
            this.pnlbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.pnlsalir);
            this.sidebar.Controls.Add(this.pnlinfo);
            this.sidebar.Controls.Add(this.pnlayuda);
            this.sidebar.Controls.Add(this.pnlcompra);
            this.sidebar.Controls.Add(this.pnlhome);
            this.sidebar.Controls.Add(this.pnlmenu);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(143, 478);
            this.sidebar.MinimumSize = new System.Drawing.Size(41, 478);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(143, 478);
            this.sidebar.TabIndex = 0;
            // 
            // pnlsalir
            // 
            this.pnlsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlsalir.Controls.Add(this.btnsalir);
            this.pnlsalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlsalir.Location = new System.Drawing.Point(0, 433);
            this.pnlsalir.Name = "pnlsalir";
            this.pnlsalir.Size = new System.Drawing.Size(143, 45);
            this.pnlsalir.TabIndex = 6;
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(-15, -6);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnsalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsalir.Size = new System.Drawing.Size(226, 57);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "        Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pnlinfo
            // 
            this.pnlinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlinfo.Controls.Add(this.btninformacion);
            this.pnlinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlinfo.Location = new System.Drawing.Point(0, 228);
            this.pnlinfo.Name = "pnlinfo";
            this.pnlinfo.Size = new System.Drawing.Size(143, 45);
            this.pnlinfo.TabIndex = 5;
            // 
            // btninformacion
            // 
            this.btninformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btninformacion.Image = ((System.Drawing.Image)(resources.GetObject("btninformacion.Image")));
            this.btninformacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninformacion.Location = new System.Drawing.Point(-15, -6);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btninformacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btninformacion.Size = new System.Drawing.Size(226, 57);
            this.btninformacion.TabIndex = 4;
            this.btninformacion.Text = "        Informacion";
            this.btninformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninformacion.UseVisualStyleBackColor = true;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // pnlayuda
            // 
            this.pnlayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlayuda.Controls.Add(this.btnayuda);
            this.pnlayuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlayuda.Location = new System.Drawing.Point(0, 183);
            this.pnlayuda.Name = "pnlayuda";
            this.pnlayuda.Size = new System.Drawing.Size(143, 45);
            this.pnlayuda.TabIndex = 5;
            // 
            // btnayuda
            // 
            this.btnayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnayuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnayuda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnayuda.Image = ((System.Drawing.Image)(resources.GetObject("btnayuda.Image")));
            this.btnayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnayuda.Location = new System.Drawing.Point(-15, -6);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnayuda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnayuda.Size = new System.Drawing.Size(226, 57);
            this.btnayuda.TabIndex = 4;
            this.btnayuda.Text = "        Ayuda";
            this.btnayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnayuda.UseVisualStyleBackColor = true;
            // 
            // pnlcompra
            // 
            this.pnlcompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlcompra.Controls.Add(this.btncompra);
            this.pnlcompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlcompra.Location = new System.Drawing.Point(0, 138);
            this.pnlcompra.Name = "pnlcompra";
            this.pnlcompra.Size = new System.Drawing.Size(143, 45);
            this.pnlcompra.TabIndex = 5;
            // 
            // btncompra
            // 
            this.btncompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncompra.Image = ((System.Drawing.Image)(resources.GetObject("btncompra.Image")));
            this.btncompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncompra.Location = new System.Drawing.Point(-15, -3);
            this.btncompra.Name = "btncompra";
            this.btncompra.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btncompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btncompra.Size = new System.Drawing.Size(226, 57);
            this.btncompra.TabIndex = 4;
            this.btncompra.Text = "        Compra";
            this.btncompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncompra.UseVisualStyleBackColor = true;
            // 
            // pnlhome
            // 
            this.pnlhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlhome.Controls.Add(this.btnhome);
            this.pnlhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlhome.Location = new System.Drawing.Point(0, 93);
            this.pnlhome.Name = "pnlhome";
            this.pnlhome.Size = new System.Drawing.Size(143, 45);
            this.pnlhome.TabIndex = 2;
            // 
            // btnhome
            // 
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(-15, -5);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnhome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnhome.Size = new System.Drawing.Size(226, 57);
            this.btnhome.TabIndex = 4;
            this.btnhome.Text = "        Home";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.UseVisualStyleBackColor = true;
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlmenu.Controls.Add(this.btnmenu);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(143, 93);
            this.pnlmenu.TabIndex = 1;
            // 
            // btnmenu
            // 
            this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenu.Location = new System.Drawing.Point(-15, -2);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Padding = new System.Windows.Forms.Padding(20, 0, 80, 0);
            this.btnmenu.Size = new System.Drawing.Size(226, 106);
            this.btnmenu.TabIndex = 4;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.button5_Click);
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 1;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // pnlbar
            // 
            this.pnlbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlbar.Controls.Add(this.panel8);
            this.pnlbar.Controls.Add(this.button3);
            this.pnlbar.Controls.Add(this.button2);
            this.pnlbar.Location = new System.Drawing.Point(0, 0);
            this.pnlbar.Name = "pnlbar";
            this.pnlbar.Size = new System.Drawing.Size(898, 35);
            this.pnlbar.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(48, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(850, 443);
            this.panel8.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(840, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 35);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(869, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 35);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pnlhijos
            // 
            this.pnlhijos.Location = new System.Drawing.Point(139, 35);
            this.pnlhijos.Name = "pnlhijos";
            this.pnlhijos.Size = new System.Drawing.Size(759, 443);
            this.pnlhijos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(898, 478);
            this.Controls.Add(this.pnlhijos);
            this.Controls.Add(this.pnlbar);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.pnlsalir.ResumeLayout(false);
            this.pnlinfo.ResumeLayout(false);
            this.pnlayuda.ResumeLayout(false);
            this.pnlcompra.ResumeLayout(false);
            this.pnlhome.ResumeLayout(false);
            this.pnlmenu.ResumeLayout(false);
            this.pnlbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel pnlhome;
        private System.Windows.Forms.Panel pnlcompra;
        private System.Windows.Forms.Button btncompra;
        private System.Windows.Forms.Panel pnlinfo;
        private System.Windows.Forms.Panel pnlayuda;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btninformacion;
        private System.Windows.Forms.Panel pnlsalir;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Panel pnlbar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnlhijos;
    }
}

