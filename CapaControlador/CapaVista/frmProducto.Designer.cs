namespace CapaVista
{
    partial class frmProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInactivo = new System.Windows.Forms.RadioButton();
            this.btnActivo = new System.Windows.Forms.RadioButton();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.gbxEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Linea";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marca";
            // 
            // btnInactivo
            // 
            this.btnInactivo.AutoSize = true;
            this.btnInactivo.Location = new System.Drawing.Point(17, 38);
            this.btnInactivo.Name = "btnInactivo";
            this.btnInactivo.Size = new System.Drawing.Size(95, 17);
            this.btnInactivo.TabIndex = 5;
            this.btnInactivo.TabStop = true;
            this.btnInactivo.Text = "Inactivo";
            this.btnInactivo.UseVisualStyleBackColor = true;
            // 
            // btnActivo
            // 
            this.btnActivo.AutoSize = true;
            this.btnActivo.Location = new System.Drawing.Point(115, 38);
            this.btnActivo.Name = "btnActivo";
            this.btnActivo.Size = new System.Drawing.Size(79, 17);
            this.btnActivo.TabIndex = 6;
            this.btnActivo.TabStop = true;
            this.btnActivo.Text = "Activo";
            this.btnActivo.UseVisualStyleBackColor = true;
            // 
            // gbxEstado
            // 
            this.gbxEstado.Controls.Add(this.btnInactivo);
            this.gbxEstado.Controls.Add(this.btnActivo);
            this.gbxEstado.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstado.Location = new System.Drawing.Point(36, 181);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(200, 66);
            this.gbxEstado.TabIndex = 7;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Estatus";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(112, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(333, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(141, 110);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(71, 20);
            this.txtExistencia.TabIndex = 10;
            // 
            // cmbLinea
            // 
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.Location = new System.Drawing.Point(301, 109);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(80, 21);
            this.cmbLinea.TabIndex = 11;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(464, 109);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(80, 21);
            this.cmbMarca.TabIndex = 12;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInsertar.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertar.Location = new System.Drawing.Point(581, 69);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 30);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnModificar.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(581, 124);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 30);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(581, 171);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(581, 229);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(581, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_producto,
            this.nombre_producto,
            this.codigo_linea,
            this.codigo_marca,
            this.existencia_producto,
            this.estatus_producto});
            this.dataGridView1.Location = new System.Drawing.Point(36, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // codigo_producto
            // 
            this.codigo_producto.HeaderText = "codigo_producto";
            this.codigo_producto.Name = "codigo_producto";
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "nombre_producto";
            this.nombre_producto.Name = "nombre_producto";
            // 
            // codigo_linea
            // 
            this.codigo_linea.HeaderText = "codigo_linea";
            this.codigo_linea.Name = "codigo_linea";
            // 
            // codigo_marca
            // 
            this.codigo_marca.HeaderText = "codigo_marca";
            this.codigo_marca.Name = "codigo_marca";
            // 
            // existencia_producto
            // 
            this.existencia_producto.HeaderText = "existencia_producto";
            this.existencia_producto.Name = "existencia_producto";
            // 
            // estatus_producto
            // 
            this.estatus_producto.HeaderText = "estatus_producto";
            this.estatus_producto.Name = "estatus_producto";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(255, 216);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(28, 20);
            this.txtEstatus.TabIndex = 19;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.cmbLinea);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton btnInactivo;
        private System.Windows.Forms.RadioButton btnActivo;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.ComboBox cmbLinea;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus_producto;
        private System.Windows.Forms.TextBox txtEstatus;
    }
}