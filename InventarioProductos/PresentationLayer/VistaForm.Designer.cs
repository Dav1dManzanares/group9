namespace PresentationLayer
{
    partial class VistaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaForm));
            button1 = new Button();
            button2 = new Button();
            btnAlimentos = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(82, 153);
            button1.Name = "button1";
            button1.Size = new Size(153, 82);
            button1.TabIndex = 0;
            button1.Text = "Muebleria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(331, 153);
            button2.Name = "button2";
            button2.Size = new Size(153, 82);
            button2.TabIndex = 1;
            button2.Text = "Electrico";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAlimentos
            // 
            btnAlimentos.Location = new Point(578, 153);
            btnAlimentos.Name = "btnAlimentos";
            btnAlimentos.Size = new Size(153, 82);
            btnAlimentos.TabIndex = 2;
            btnAlimentos.Text = "Alimentos";
            btnAlimentos.UseVisualStyleBackColor = true;
            btnAlimentos.Click += btnAlimentos_Click;
            // 
            // VistaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlimentos);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "VistaForm";
            Text = "VistaForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnAlimentos;
    }
}