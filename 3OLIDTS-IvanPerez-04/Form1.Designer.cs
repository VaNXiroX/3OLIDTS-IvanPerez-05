namespace _3OLIDTS_IvanPerez_04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNombre = new TextBox();
            tbApellidos = new TextBox();
            tbEdad = new TextBox();
            tbEstatura = new TextBox();
            tbTelefono = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Hombre = new CheckBox();
            Mujer = new CheckBox();
            Helicoptero_Apache = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(142, 40);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 0;
            tbNombre.TextChanged += textBox1_TextChanged;
            // 
            // tbApellidos
            // 
            tbApellidos.Location = new Point(140, 93);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(125, 27);
            tbApellidos.TabIndex = 1;
            tbApellidos.TextChanged += textBox2_TextChanged;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(140, 152);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(125, 27);
            tbEdad.TabIndex = 2;
            tbEdad.TextChanged += textBox3_TextChanged;
            // 
            // tbEstatura
            // 
            tbEstatura.Location = new Point(138, 215);
            tbEstatura.Name = "tbEstatura";
            tbEstatura.Size = new Size(125, 27);
            tbEstatura.TabIndex = 3;
            tbEstatura.TextChanged += textBox4_TextChanged;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(138, 282);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(125, 27);
            tbTelefono.TabIndex = 4;
            tbTelefono.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 96);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 6;
            label2.Text = "Apellidos: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 159);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 7;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 222);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 8;
            label4.Text = "Estatura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 289);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 338);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 10;
            label6.Text = "Género";
            // 
            // Hombre
            // 
            Hombre.AutoSize = true;
            Hombre.Location = new Point(99, 375);
            Hombre.Name = "Hombre";
            Hombre.Size = new Size(86, 24);
            Hombre.TabIndex = 11;
            Hombre.Text = "Hombre";
            Hombre.UseVisualStyleBackColor = true;
            Hombre.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Mujer
            // 
            Mujer.AutoSize = true;
            Mujer.Location = new Point(206, 375);
            Mujer.Name = "Mujer";
            Mujer.Size = new Size(69, 24);
            Mujer.TabIndex = 12;
            Mujer.Text = "Mujer";
            Mujer.UseVisualStyleBackColor = true;
            Mujer.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Helicoptero_Apache
            // 
            Helicoptero_Apache.AutoSize = true;
            Helicoptero_Apache.Location = new Point(99, 414);
            Helicoptero_Apache.Name = "Helicoptero_Apache";
            Helicoptero_Apache.Size = new Size(164, 24);
            Helicoptero_Apache.TabIndex = 13;
            Helicoptero_Apache.Text = "Helicoptero Apache";
            Helicoptero_Apache.UseVisualStyleBackColor = true;
            Helicoptero_Apache.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(453, 134);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(453, 193);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Helicoptero_Apache);
            Controls.Add(Mujer);
            Controls.Add(Hombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbTelefono);
            Controls.Add(tbEstatura);
            Controls.Add(tbEdad);
            Controls.Add(tbApellidos);
            Controls.Add(tbNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombre;
        private TextBox tbApellidos;
        private TextBox tbEdad;
        private TextBox tbEstatura;
        private TextBox tbTelefono;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox Hombre;
        private CheckBox Mujer;
        private CheckBox Helicoptero_Apache;
        private Button button1;
        private Button button2;
    }
}
