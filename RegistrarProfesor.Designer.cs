namespace Codigo_de_los_ultimos_3_codigos
{
    partial class RegistrarProfesor
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button11 = new Button();
            button12 = new Button();
            ListarProfesor = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(45, 402);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(683, 402);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(62, 41);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Nombre";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(62, 87);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Apellido";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(64, 135);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Especialidad";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(68, 183);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "telefono";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(71, 227);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 6;
            button7.Text = "correo Electronico";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(75, 267);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 7;
            button8.Text = "direccion de Residencia";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(75, 307);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 8;
            button9.Text = "fecha de Nacimiento";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(79, 346);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 9;
            button10.Text = "numero de Identificacion";
            button10.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += campoNombre_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += campoApellido_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(183, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += campoEspecialidad_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(178, 190);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += campoTelefono_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(170, 231);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += campoCorreoElectronico_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(172, 274);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += campoDireccionResidencia_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(176, 314);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 16;
            textBox7.TextChanged += fechaNacimientoPicker_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(176, 352);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 17;
            textBox8.TextChanged += campoNumeroIdentificacion_TextChanged;
            // 
            // button11
            // 
            button11.Location = new Point(552, 28);
            button11.Name = "button11";
            button11.Size = new Size(92, 53);
            button11.TabIndex = 18;
            button11.Text = "Registro del Profesor";
            button11.UseVisualStyleBackColor = true;
            button11.Click += botonRegistrarProfesor_Click;
            // 
            // button12
            // 
            button12.Location = new Point(552, 103);
            button12.Name = "button12";
            button12.Size = new Size(133, 55);
            button12.TabIndex = 19;
            button12.Text = "Editar/listar profesor";
            button12.UseVisualStyleBackColor = true;
            button12.Click += botonEditarProfesor_Click;
            // 
            // ListarProfesor
            // 
            ListarProfesor.FormattingEnabled = true;
            ListarProfesor.ItemHeight = 15;
            ListarProfesor.Location = new Point(552, 196);
            ListarProfesor.Name = "ListarProfesor";
            ListarProfesor.Size = new Size(120, 94);
            ListarProfesor.TabIndex = 20;
            ListarProfesor.SelectedIndexChanged += listaProfesores_SelectedIndexChanged;
            // 
            // RegistrarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListarProfesor);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "RegistrarProfesor";
            Text = "RegistrarProfesor";
            Load += RegistrarProfesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button11;
        private Button button12;
        private ListBox ListarProfesor;
    }
}