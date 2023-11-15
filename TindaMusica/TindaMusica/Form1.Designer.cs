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
            components = new System.ComponentModel.Container();
            sidebar = new Panel();
            pnlsalir = new Panel();
            btnsalir = new Button();
            pnlinfo = new Panel();
            btninformacion = new Button();
            pnlayuda = new Panel();
            btnayuda = new Button();
            pnlcompra = new Panel();
            btncompra = new Button();
            pnlhome = new Panel();
            btnhome = new Button();
            pnlmenu = new Panel();
            btnmenu = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            pnlbar = new Panel();
            panel8 = new Panel();
            button3 = new Button();
            button2 = new Button();
            pnlhijos = new Panel();
            sidebar.SuspendLayout();
            pnlsalir.SuspendLayout();
            pnlinfo.SuspendLayout();
            pnlayuda.SuspendLayout();
            pnlcompra.SuspendLayout();
            pnlhome.SuspendLayout();
            pnlmenu.SuspendLayout();
            pnlbar.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(pnlsalir);
            sidebar.Controls.Add(pnlinfo);
            sidebar.Controls.Add(pnlayuda);
            sidebar.Controls.Add(pnlcompra);
            sidebar.Controls.Add(pnlhome);
            sidebar.Controls.Add(pnlmenu);
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(4, 5, 4, 5);
            sidebar.MaximumSize = new Size(191, 735);
            sidebar.MinimumSize = new Size(55, 735);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(191, 735);
            sidebar.TabIndex = 0;
            // 
            // pnlsalir
            // 
            pnlsalir.BackColor = Color.FromArgb(35, 40, 45);
            pnlsalir.Controls.Add(btnsalir);
            pnlsalir.Dock = DockStyle.Bottom;
            pnlsalir.Location = new Point(0, 666);
            pnlsalir.Margin = new Padding(4, 5, 4, 5);
            pnlsalir.Name = "pnlsalir";
            pnlsalir.Size = new Size(191, 69);
            pnlsalir.TabIndex = 6;
            // 
            // btnsalir
            // 
            btnsalir.Cursor = Cursors.Hand;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsalir.ForeColor = SystemColors.ButtonFace;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(-20, -9);
            btnsalir.Margin = new Padding(4, 5, 4, 5);
            btnsalir.Name = "btnsalir";
            btnsalir.Padding = new Padding(27, 0, 0, 0);
            btnsalir.RightToLeft = RightToLeft.No;
            btnsalir.Size = new Size(301, 88);
            btnsalir.TabIndex = 4;
            btnsalir.Text = "        Salir";
            btnsalir.TextAlign = ContentAlignment.MiddleLeft;
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // pnlinfo
            // 
            pnlinfo.BackColor = Color.FromArgb(35, 40, 45);
            pnlinfo.Controls.Add(btninformacion);
            pnlinfo.Dock = DockStyle.Top;
            pnlinfo.Location = new Point(0, 350);
            pnlinfo.Margin = new Padding(4, 5, 4, 5);
            pnlinfo.Name = "pnlinfo";
            pnlinfo.Size = new Size(191, 69);
            pnlinfo.TabIndex = 5;
            // 
            // btninformacion
            // 
            btninformacion.Cursor = Cursors.Hand;
            btninformacion.FlatStyle = FlatStyle.Flat;
            btninformacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btninformacion.ForeColor = SystemColors.ButtonFace;
            btninformacion.ImageAlign = ContentAlignment.MiddleLeft;
            btninformacion.Location = new Point(-20, -9);
            btninformacion.Margin = new Padding(4, 5, 4, 5);
            btninformacion.Name = "btninformacion";
            btninformacion.Padding = new Padding(27, 0, 0, 0);
            btninformacion.RightToLeft = RightToLeft.No;
            btninformacion.Size = new Size(301, 88);
            btninformacion.TabIndex = 4;
            btninformacion.Text = "        Informacion";
            btninformacion.TextAlign = ContentAlignment.MiddleLeft;
            btninformacion.UseVisualStyleBackColor = true;
            btninformacion.Click += btninformacion_Click;
            // 
            // pnlayuda
            // 
            pnlayuda.BackColor = Color.FromArgb(35, 40, 45);
            pnlayuda.Controls.Add(btnayuda);
            pnlayuda.Dock = DockStyle.Top;
            pnlayuda.Location = new Point(0, 281);
            pnlayuda.Margin = new Padding(4, 5, 4, 5);
            pnlayuda.Name = "pnlayuda";
            pnlayuda.Size = new Size(191, 69);
            pnlayuda.TabIndex = 5;
            // 
            // btnayuda
            // 
            btnayuda.Cursor = Cursors.Hand;
            btnayuda.FlatStyle = FlatStyle.Flat;
            btnayuda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnayuda.ForeColor = SystemColors.ButtonFace;
            btnayuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnayuda.Location = new Point(-20, -9);
            btnayuda.Margin = new Padding(4, 5, 4, 5);
            btnayuda.Name = "btnayuda";
            btnayuda.Padding = new Padding(27, 0, 0, 0);
            btnayuda.RightToLeft = RightToLeft.No;
            btnayuda.Size = new Size(301, 88);
            btnayuda.TabIndex = 4;
            btnayuda.Text = "        Ayuda";
            btnayuda.TextAlign = ContentAlignment.MiddleLeft;
            btnayuda.UseVisualStyleBackColor = true;
            // 
            // pnlcompra
            // 
            pnlcompra.BackColor = Color.FromArgb(35, 40, 45);
            pnlcompra.Controls.Add(btncompra);
            pnlcompra.Dock = DockStyle.Top;
            pnlcompra.Location = new Point(0, 212);
            pnlcompra.Margin = new Padding(4, 5, 4, 5);
            pnlcompra.Name = "pnlcompra";
            pnlcompra.Size = new Size(191, 69);
            pnlcompra.TabIndex = 5;
            // 
            // btncompra
            // 
            btncompra.Cursor = Cursors.Hand;
            btncompra.FlatStyle = FlatStyle.Flat;
            btncompra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncompra.ForeColor = SystemColors.ButtonFace;
            btncompra.ImageAlign = ContentAlignment.MiddleLeft;
            btncompra.Location = new Point(-20, -5);
            btncompra.Margin = new Padding(4, 5, 4, 5);
            btncompra.Name = "btncompra";
            btncompra.Padding = new Padding(27, 0, 0, 0);
            btncompra.RightToLeft = RightToLeft.No;
            btncompra.Size = new Size(301, 88);
            btncompra.TabIndex = 4;
            btncompra.Text = "        Compra";
            btncompra.TextAlign = ContentAlignment.MiddleLeft;
            btncompra.UseVisualStyleBackColor = true;
            btncompra.Click += btncompra_Click;
            // 
            // pnlhome
            // 
            pnlhome.BackColor = Color.FromArgb(35, 40, 45);
            pnlhome.Controls.Add(btnhome);
            pnlhome.Dock = DockStyle.Top;
            pnlhome.Location = new Point(0, 143);
            pnlhome.Margin = new Padding(4, 5, 4, 5);
            pnlhome.Name = "pnlhome";
            pnlhome.Size = new Size(191, 69);
            pnlhome.TabIndex = 2;
            // 
            // btnhome
            // 
            btnhome.Cursor = Cursors.Hand;
            btnhome.FlatStyle = FlatStyle.Flat;
            btnhome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnhome.ForeColor = SystemColors.ButtonFace;
            btnhome.ImageAlign = ContentAlignment.MiddleLeft;
            btnhome.Location = new Point(-20, -8);
            btnhome.Margin = new Padding(4, 5, 4, 5);
            btnhome.Name = "btnhome";
            btnhome.Padding = new Padding(27, 0, 0, 0);
            btnhome.RightToLeft = RightToLeft.No;
            btnhome.Size = new Size(301, 88);
            btnhome.TabIndex = 4;
            btnhome.Text = "        Home";
            btnhome.TextAlign = ContentAlignment.MiddleLeft;
            btnhome.UseVisualStyleBackColor = true;
            // 
            // pnlmenu
            // 
            pnlmenu.BackColor = Color.FromArgb(35, 40, 45);
            pnlmenu.Controls.Add(btnmenu);
            pnlmenu.Dock = DockStyle.Top;
            pnlmenu.Location = new Point(0, 0);
            pnlmenu.Margin = new Padding(4, 5, 4, 5);
            pnlmenu.Name = "pnlmenu";
            pnlmenu.Size = new Size(191, 143);
            pnlmenu.TabIndex = 1;
            // 
            // btnmenu
            // 
            btnmenu.Cursor = Cursors.Hand;
            btnmenu.FlatStyle = FlatStyle.Flat;
            btnmenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmenu.ForeColor = SystemColors.ButtonFace;
            btnmenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnmenu.Location = new Point(-20, -3);
            btnmenu.Margin = new Padding(4, 5, 4, 5);
            btnmenu.Name = "btnmenu";
            btnmenu.Padding = new Padding(27, 0, 107, 0);
            btnmenu.Size = new Size(301, 163);
            btnmenu.TabIndex = 4;
            btnmenu.Text = "Menu";
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += button5_Click;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 1;
            sidebartimer.Tick += sidebartimer_Tick;
            // 
            // pnlbar
            // 
            pnlbar.BackColor = Color.FromArgb(35, 40, 45);
            pnlbar.Controls.Add(panel8);
            pnlbar.Controls.Add(button3);
            pnlbar.Controls.Add(button2);
            pnlbar.Location = new Point(0, 0);
            pnlbar.Margin = new Padding(4, 5, 4, 5);
            pnlbar.Name = "pnlbar";
            pnlbar.Size = new Size(1197, 54);
            pnlbar.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Location = new Point(64, 54);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(1133, 682);
            panel8.TabIndex = 2;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1119, 0);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(39, 54);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1158, 0);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(39, 54);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // pnlhijos
            // 
            pnlhijos.Location = new Point(185, 54);
            pnlhijos.Margin = new Padding(4, 5, 4, 5);
            pnlhijos.Name = "pnlhijos";
            pnlhijos.Size = new Size(1012, 682);
            pnlhijos.TabIndex = 2;
            pnlhijos.Paint += pnlhijos_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1197, 735);
            Controls.Add(pnlhijos);
            Controls.Add(pnlbar);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            sidebar.ResumeLayout(false);
            pnlsalir.ResumeLayout(false);
            pnlinfo.ResumeLayout(false);
            pnlayuda.ResumeLayout(false);
            pnlcompra.ResumeLayout(false);
            pnlhome.ResumeLayout(false);
            pnlmenu.ResumeLayout(false);
            pnlbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Panel pnlmenu;
        private Button btnhome;
        private Panel pnlhome;
        private Panel pnlcompra;
        private Button btncompra;
        private Panel pnlinfo;
        private Panel pnlayuda;
        private Button btnayuda;
        private Button btninformacion;
        private Panel pnlsalir;
        private Button btnsalir;
        private Button btnmenu;
        private System.Windows.Forms.Timer sidebartimer;
        private Panel pnlbar;
        private Button button2;
        private Button button3;
        private Panel panel8;
        private Panel pnlhijos;
    }
}

