namespace PresentationLayer
{
    partial class AlimentosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlimentosForm));
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dvgAlimentos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgAlimentos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(22, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos de Alimentacion";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(32, 255);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(245, 38);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(32, 167);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(245, 38);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(32, 211);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(245, 38);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(156, 126);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(121, 23);
            txtCantidad.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(156, 89);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(32, 126);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(32, 89);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(32, 49);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // dvgAlimentos
            // 
            dvgAlimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAlimentos.Location = new Point(363, 45);
            dvgAlimentos.Name = "dvgAlimentos";
            dvgAlimentos.Size = new Size(514, 337);
            dvgAlimentos.TabIndex = 2;
            dvgAlimentos.CellContentClick += dvgAlimentos_CellContentClick;
            // 
            // AlimentosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(889, 450);
            Controls.Add(dvgAlimentos);
            Controls.Add(groupBox1);
            Name = "AlimentosForm";
            Text = "AlimentosForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgAlimentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnModificar;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dvgAlimentos;
    }
}