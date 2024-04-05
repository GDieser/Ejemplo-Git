namespace Form1
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
            Boton = new System.Windows.Forms.Button();
            lblNombre = new System.Windows.Forms.Label();
            capNombre = new System.Windows.Forms.TextBox();
            lblSaludar = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            capApellido = new System.Windows.Forms.TextBox();
            capEdad = new System.Windows.Forms.TextBox();
            capPuesto = new System.Windows.Forms.TextBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            btnAgregar = new System.Windows.Forms.Button();
            txtElemento = new System.Windows.Forms.TextBox();
            lwElementos = new System.Windows.Forms.ListView();
            lblFecha = new System.Windows.Forms.Label();
            dtpFecha = new System.Windows.Forms.DateTimePicker();
            lblTitulo = new System.Windows.Forms.Label();
            lblColor = new System.Windows.Forms.Label();
            cbColor = new System.Windows.Forms.ComboBox();
            btnPerfil = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Boton
            // 
            Boton.BackColor = System.Drawing.Color.LightCoral;
            Boton.Location = new System.Drawing.Point(180, 407);
            Boton.Name = "Boton";
            Boton.Size = new System.Drawing.Size(121, 31);
            Boton.TabIndex = 11;
            Boton.Text = "Hola";
            Boton.UseVisualStyleBackColor = false;
            Boton.Click += Boton_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(136, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(59, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE:";
            lblNombre.Click += Boton_Click;
            // 
            // capNombre
            // 
            capNombre.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            capNombre.Location = new System.Drawing.Point(201, 40);
            capNombre.Name = "capNombre";
            capNombre.Size = new System.Drawing.Size(225, 23);
            capNombre.TabIndex = 0;
            capNombre.TextChanged += capSaludo_TextChanged;
            // 
            // lblSaludar
            // 
            lblSaludar.AutoSize = true;
            lblSaludar.Location = new System.Drawing.Point(136, 321);
            lblSaludar.Name = "lblSaludar";
            lblSaludar.Size = new System.Drawing.Size(0, 15);
            lblSaludar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(136, 79);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "APELLIDO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(136, 112);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "EDAD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(136, 147);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "PUESTO:";
            // 
            // capApellido
            // 
            capApellido.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            capApellido.Location = new System.Drawing.Point(201, 76);
            capApellido.Name = "capApellido";
            capApellido.Size = new System.Drawing.Size(225, 23);
            capApellido.TabIndex = 1;
            // 
            // capEdad
            // 
            capEdad.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            capEdad.Location = new System.Drawing.Point(201, 109);
            capEdad.Name = "capEdad";
            capEdad.Size = new System.Drawing.Size(225, 23);
            capEdad.TabIndex = 2;
            // 
            // capPuesto
            // 
            capPuesto.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            capPuesto.Location = new System.Drawing.Point(201, 144);
            capPuesto.Name = "capPuesto";
            capPuesto.Size = new System.Drawing.Size(225, 23);
            capPuesto.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(180, 382);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(75, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "HOMBRE";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(364, 382);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(62, 19);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "MUJER";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(351, 184);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtElemento
            // 
            txtElemento.Location = new System.Drawing.Point(201, 184);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new System.Drawing.Size(100, 23);
            txtElemento.TabIndex = 4;
            // 
            // lwElementos
            // 
            lwElementos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lwElementos.HideSelection = false;
            lwElementos.Location = new System.Drawing.Point(201, 213);
            lwElementos.Name = "lwElementos";
            lwElementos.Size = new System.Drawing.Size(225, 52);
            lwElementos.TabIndex = 6;
            lwElementos.UseCompatibleStateImageBehavior = false;
            lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(80, 277);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(119, 15);
            lblFecha.TabIndex = 15;
            lblFecha.Text = "Fecha de Nacimiento";
            lblFecha.Click += label4_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new System.Drawing.Point(226, 271);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new System.Drawing.Size(200, 23);
            dtpFecha.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(226, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(177, 28);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Perfil Persona";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new System.Drawing.Point(113, 306);
            lblColor.Name = "lblColor";
            lblColor.Size = new System.Drawing.Size(82, 15);
            lblColor.TabIndex = 18;
            lblColor.Text = "Color Favorito";
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Location = new System.Drawing.Point(201, 300);
            cbColor.Name = "cbColor";
            cbColor.Size = new System.Drawing.Size(225, 23);
            cbColor.TabIndex = 8;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = System.Drawing.Color.LightCoral;
            btnPerfil.Location = new System.Drawing.Point(307, 407);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new System.Drawing.Size(119, 31);
            btnPerfil.TabIndex = 12;
            btnPerfil.Text = "Ver Perfil";
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(640, 497);
            Controls.Add(btnPerfil);
            Controls.Add(cbColor);
            Controls.Add(lblColor);
            Controls.Add(lblTitulo);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(lwElementos);
            Controls.Add(txtElemento);
            Controls.Add(btnAgregar);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(capPuesto);
            Controls.Add(capEdad);
            Controls.Add(capApellido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblSaludar);
            Controls.Add(capNombre);
            Controls.Add(lblNombre);
            Controls.Add(Boton);
            ForeColor = System.Drawing.SystemColors.ControlText;
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(656, 536);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Boton;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox capNombre;
        private System.Windows.Forms.Label lblSaludar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capApellido;
        private System.Windows.Forms.TextBox capEdad;
        private System.Windows.Forms.TextBox capPuesto;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Button btnPerfil;
    }
}
