namespace PresentationLayer
{
    partial class MueblesForm
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
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dvgMuebles = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgMuebles).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 27);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(377, 460);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos de muebles";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(32, 375);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(280, 51);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(32, 257);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(280, 51);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(32, 316);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(280, 51);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(174, 203);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(138, 27);
            txtCantidad.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(174, 153);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(138, 27);
            txtPrecio.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 100);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(174, 51);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(138, 27);
            txtId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 203);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 153);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 100);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 55);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // dvgMuebles
            // 
            dvgMuebles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMuebles.Location = new Point(432, 43);
            dvgMuebles.Margin = new Padding(3, 4, 3, 4);
            dvgMuebles.Name = "dvgMuebles";
            dvgMuebles.RowHeadersWidth = 51;
            dvgMuebles.Size = new Size(554, 444);
            dvgMuebles.TabIndex = 1;
            dvgMuebles.CellContentClick += dvgMuebles_CellContentClick;
            // 
            // MueblesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 541);
            Controls.Add(dvgMuebles);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MueblesForm";
            Text = "MueblesForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgMuebles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnModificar;
        private DataGridView dvgMuebles;
    }
}