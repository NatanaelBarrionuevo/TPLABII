namespace TindaMusica.Venta
{
    partial class frmVentaServicios
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
            label2 = new Label();
            dgvDetalleServicio = new DataGridView();
            prodId = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            cboServicios = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            cboLuthier = new ComboBox();
            groupBox3 = new GroupBox();
            nmcHoras = new NumericUpDown();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleServicio).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmcHoras).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 138);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 7;
            label2.Text = "Servicios";
            // 
            // dgvDetalleServicio
            // 
            dgvDetalleServicio.AllowUserToAddRows = false;
            dgvDetalleServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleServicio.Columns.AddRange(new DataGridViewColumn[] { prodId, nombre, precio, tipo });
            dgvDetalleServicio.Location = new Point(48, 268);
            dgvDetalleServicio.Margin = new Padding(3, 4, 3, 4);
            dgvDetalleServicio.Name = "dgvDetalleServicio";
            dgvDetalleServicio.RowHeadersWidth = 51;
            dgvDetalleServicio.RowTemplate.Height = 24;
            dgvDetalleServicio.Size = new Size(707, 322);
            dgvDetalleServicio.TabIndex = 6;
            // 
            // prodId
            // 
            prodId.HeaderText = "Prod Nro";
            prodId.MinimumWidth = 6;
            prodId.Name = "prodId";
            prodId.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.Width = 125;
            // 
            // cboServicios
            // 
            cboServicios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboServicios.FormattingEnabled = true;
            cboServicios.Location = new Point(16, 26);
            cboServicios.Name = "cboServicios";
            cboServicios.Size = new Size(151, 28);
            cboServicios.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboServicios);
            groupBox1.Location = new Point(48, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 71);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servicio";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboLuthier);
            groupBox2.Location = new Point(248, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(182, 71);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Luthier";
            // 
            // cboLuthier
            // 
            cboLuthier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLuthier.FormattingEnabled = true;
            cboLuthier.Location = new Point(16, 26);
            cboLuthier.Name = "cboLuthier";
            cboLuthier.Size = new Size(151, 28);
            cboLuthier.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nmcHoras);
            groupBox3.Location = new Point(460, 172);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(87, 71);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Horas";
            // 
            // nmcHoras
            // 
            nmcHoras.Location = new Point(15, 27);
            nmcHoras.Name = "nmcHoras";
            nmcHoras.Size = new Size(57, 27);
            nmcHoras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(593, 199);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmVentaServicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 740);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dgvDetalleServicio);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmVentaServicios";
            Text = "Servicios";
            Load += frmVentaServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleServicio).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmcHoras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dgvDetalleServicio;
        private DataGridViewTextBoxColumn prodId;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn tipo;
        private ComboBox cboServicios;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cboLuthier;
        private GroupBox groupBox3;
        private NumericUpDown nmcHoras;
        private Button btnAgregar;
    }
}