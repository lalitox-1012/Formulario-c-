namespace Formulario_c_
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
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.tbedad = new System.Windows.Forms.TextBox();
            this.tbestatura = new System.Windows.Forms.TextBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(393, 21);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 22);
            this.tbnombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "EDAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ESTATURA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "TELEFONO:";
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(393, 88);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(100, 22);
            this.tbapellido.TabIndex = 6;
            // 
            // tbedad
            // 
            this.tbedad.Location = new System.Drawing.Point(393, 144);
            this.tbedad.Name = "tbedad";
            this.tbedad.Size = new System.Drawing.Size(100, 22);
            this.tbedad.TabIndex = 7;
            // 
            // tbestatura
            // 
            this.tbestatura.Location = new System.Drawing.Point(396, 195);
            this.tbestatura.Name = "tbestatura";
            this.tbestatura.Size = new System.Drawing.Size(100, 22);
            this.tbestatura.TabIndex = 8;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(396, 240);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(100, 22);
            this.tbtelefono.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemenino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Location = new System.Drawing.Point(214, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 103);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENERO";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(149, 39);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(98, 20);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "FEMENINO";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 39);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(106, 20);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "MASCULINO";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // bttGuardar
            // 
            this.bttGuardar.BackColor = System.Drawing.Color.SpringGreen;
            this.bttGuardar.Location = new System.Drawing.Point(214, 438);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(112, 23);
            this.bttGuardar.TabIndex = 11;
            this.bttGuardar.Text = "GUARDAR";
            this.bttGuardar.UseVisualStyleBackColor = false;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.BackColor = System.Drawing.Color.Red;
            this.bttCancelar.Location = new System.Drawing.Point(363, 438);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(130, 23);
            this.bttCancelar.TabIndex = 12;
            this.bttCancelar.Text = "CANCELAR";
            this.bttCancelar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(844, 499);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbestatura);
            this.Controls.Add(this.tbedad);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.TextBox tbedad;
        private System.Windows.Forms.TextBox tbestatura;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttCancelar;
    }
}

