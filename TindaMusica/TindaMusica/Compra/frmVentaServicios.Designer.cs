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
            dataGridView1 = new DataGridView();
            prodId = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { prodId, nombre, precio, tipo });
            dataGridView1.Location = new Point(48, 268);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(707, 322);
            dataGridView1.TabIndex = 6;
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
            // frmVentaServicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 740);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmVentaServicios";
            Text = "Servicios";
            Load += frmVentaServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn prodId;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn tipo;
    }
}