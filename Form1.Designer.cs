
namespace figurasgeometricas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.medida = new System.Windows.Forms.TextBox();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.EXPORTAR = new System.Windows.Forms.Button();
            this.DIBUJAR = new System.Windows.Forms.Button();
            this.INFORMACION = new System.Windows.Forms.Button();
            this.esfera = new System.Windows.Forms.RadioButton();
            this.prisma = new System.Windows.Forms.RadioButton();
            this.polir = new System.Windows.Forms.RadioButton();
            this.cubo = new System.Windows.Forms.RadioButton();
            this.rectangulo = new System.Windows.Forms.RadioButton();
            this.circulo = new System.Windows.Forms.RadioButton();
            this.triangulo = new System.Windows.Forms.RadioButton();
            this.polii = new System.Windows.Forms.RadioButton();
            this.cuadrado = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.RichTextBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.medida);
            this.groupBox1.Controls.Add(this.GUARDAR);
            this.groupBox1.Controls.Add(this.CALCULAR);
            this.groupBox1.Controls.Add(this.LIMPIAR);
            this.groupBox1.Controls.Add(this.EXPORTAR);
            this.groupBox1.Controls.Add(this.DIBUJAR);
            this.groupBox1.Controls.Add(this.INFORMACION);
            this.groupBox1.Controls.Add(this.esfera);
            this.groupBox1.Controls.Add(this.prisma);
            this.groupBox1.Controls.Add(this.polir);
            this.groupBox1.Controls.Add(this.cubo);
            this.groupBox1.Controls.Add(this.rectangulo);
            this.groupBox1.Controls.Add(this.circulo);
            this.groupBox1.Controls.Add(this.triangulo);
            this.groupBox1.Controls.Add(this.polii);
            this.groupBox1.Controls.Add(this.cuadrado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // medida
            // 
            this.medida.Location = new System.Drawing.Point(362, 134);
            this.medida.Name = "medida";
            this.medida.Size = new System.Drawing.Size(66, 20);
            this.medida.TabIndex = 17;
            // 
            // GUARDAR
            // 
            this.GUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GUARDAR.Location = new System.Drawing.Point(434, 132);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(80, 23);
            this.GUARDAR.TabIndex = 16;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.UseVisualStyleBackColor = false;
            // 
            // CALCULAR
            // 
            this.CALCULAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CALCULAR.Location = new System.Drawing.Point(434, 165);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(80, 23);
            this.CALCULAR.TabIndex = 15;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = false;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LIMPIAR.Location = new System.Drawing.Point(350, 165);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(68, 23);
            this.LIMPIAR.TabIndex = 14;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = false;
            // 
            // EXPORTAR
            // 
            this.EXPORTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EXPORTAR.Location = new System.Drawing.Point(244, 165);
            this.EXPORTAR.Name = "EXPORTAR";
            this.EXPORTAR.Size = new System.Drawing.Size(85, 23);
            this.EXPORTAR.TabIndex = 13;
            this.EXPORTAR.Text = "EXPORTAR";
            this.EXPORTAR.UseVisualStyleBackColor = false;
            this.EXPORTAR.Click += new System.EventHandler(this.EXPORTAR_Click);
            // 
            // DIBUJAR
            // 
            this.DIBUJAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DIBUJAR.Location = new System.Drawing.Point(148, 165);
            this.DIBUJAR.Name = "DIBUJAR";
            this.DIBUJAR.Size = new System.Drawing.Size(72, 23);
            this.DIBUJAR.TabIndex = 12;
            this.DIBUJAR.Text = "DIBUJAR";
            this.DIBUJAR.UseVisualStyleBackColor = false;
            this.DIBUJAR.Click += new System.EventHandler(this.DIBUJAR_Click);
            // 
            // INFORMACION
            // 
            this.INFORMACION.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.INFORMACION.Location = new System.Drawing.Point(32, 165);
            this.INFORMACION.Name = "INFORMACION";
            this.INFORMACION.Size = new System.Drawing.Size(93, 23);
            this.INFORMACION.TabIndex = 11;
            this.INFORMACION.Text = "INFORMACIÓN";
            this.INFORMACION.UseVisualStyleBackColor = false;
            this.INFORMACION.Click += new System.EventHandler(this.INFORMACION_Click);
            // 
            // esfera
            // 
            this.esfera.AutoSize = true;
            this.esfera.Location = new System.Drawing.Point(447, 93);
            this.esfera.Name = "esfera";
            this.esfera.Size = new System.Drawing.Size(67, 17);
            this.esfera.TabIndex = 10;
            this.esfera.TabStop = true;
            this.esfera.Text = "ESFERA";
            this.esfera.UseVisualStyleBackColor = true;
            // 
            // prisma
            // 
            this.prisma.AutoSize = true;
            this.prisma.Location = new System.Drawing.Point(362, 93);
            this.prisma.Name = "prisma";
            this.prisma.Size = new System.Drawing.Size(66, 17);
            this.prisma.TabIndex = 9;
            this.prisma.TabStop = true;
            this.prisma.Text = "PRISMA";
            this.prisma.UseVisualStyleBackColor = true;
            // 
            // polir
            // 
            this.polir.AutoSize = true;
            this.polir.Location = new System.Drawing.Point(368, 60);
            this.polir.Name = "polir";
            this.polir.Size = new System.Drawing.Size(136, 17);
            this.polir.TabIndex = 8;
            this.polir.TabStop = true;
            this.polir.Text = "POLÍGONO REGULAR";
            this.polir.UseVisualStyleBackColor = true;
            // 
            // cubo
            // 
            this.cubo.AutoSize = true;
            this.cubo.Location = new System.Drawing.Point(283, 93);
            this.cubo.Name = "cubo";
            this.cubo.Size = new System.Drawing.Size(55, 17);
            this.cubo.TabIndex = 7;
            this.cubo.TabStop = true;
            this.cubo.Text = "CUBO";
            this.cubo.UseVisualStyleBackColor = true;
            // 
            // rectangulo
            // 
            this.rectangulo.AutoSize = true;
            this.rectangulo.Location = new System.Drawing.Point(252, 60);
            this.rectangulo.Name = "rectangulo";
            this.rectangulo.Size = new System.Drawing.Size(99, 17);
            this.rectangulo.TabIndex = 6;
            this.rectangulo.TabStop = true;
            this.rectangulo.Text = "RECTÁNGULO";
            this.rectangulo.UseVisualStyleBackColor = true;
            // 
            // circulo
            // 
            this.circulo.AutoSize = true;
            this.circulo.Location = new System.Drawing.Point(193, 93);
            this.circulo.Name = "circulo";
            this.circulo.Size = new System.Drawing.Size(72, 17);
            this.circulo.TabIndex = 5;
            this.circulo.TabStop = true;
            this.circulo.Text = "CÍRCULO";
            this.circulo.UseVisualStyleBackColor = true;
            // 
            // triangulo
            // 
            this.triangulo.AutoSize = true;
            this.triangulo.Location = new System.Drawing.Point(140, 60);
            this.triangulo.Name = "triangulo";
            this.triangulo.Size = new System.Drawing.Size(88, 17);
            this.triangulo.TabIndex = 4;
            this.triangulo.TabStop = true;
            this.triangulo.Text = "TRIÁNGULO";
            this.triangulo.UseVisualStyleBackColor = true;
            // 
            // polii
            // 
            this.polii.AutoSize = true;
            this.polii.Location = new System.Drawing.Point(31, 93);
            this.polii.Name = "polii";
            this.polii.Size = new System.Drawing.Size(147, 17);
            this.polii.TabIndex = 3;
            this.polii.TabStop = true;
            this.polii.Text = "POLIGONO IRREGULAR";
            this.polii.UseVisualStyleBackColor = true;
            // 
            // cuadrado
            // 
            this.cuadrado.AutoSize = true;
            this.cuadrado.Location = new System.Drawing.Point(31, 60);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(86, 17);
            this.cuadrado.TabIndex = 2;
            this.cuadrado.TabStop = true;
            this.cuadrado.Text = "CUADRADO";
            this.cuadrado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESA MEDIDA DEL LADO, ARTISTA, RADIO, ETC.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSTRUCTOR DE FIGURAS GEOMETRICAS";
            // 
            // texto
            // 
            this.texto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.texto.Location = new System.Drawing.Point(284, 237);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(265, 202);
            this.texto.TabIndex = 1;
            this.texto.Text = "";
            // 
            // imagen
            // 
            this.imagen.InitialImage = global::figurasgeometricas.Properties.Resources.triangulo;
            this.imagen.Location = new System.Drawing.Point(12, 238);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(249, 201);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 2;
            this.imagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton circulo;
        private System.Windows.Forms.RadioButton triangulo;
        private System.Windows.Forms.RadioButton polii;
        private System.Windows.Forms.RadioButton cuadrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton prisma;
        private System.Windows.Forms.RadioButton polir;
        private System.Windows.Forms.RadioButton cubo;
        private System.Windows.Forms.RadioButton rectangulo;
        private System.Windows.Forms.TextBox medida;
        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Button EXPORTAR;
        private System.Windows.Forms.Button DIBUJAR;
        private System.Windows.Forms.Button INFORMACION;
        private System.Windows.Forms.RadioButton esfera;
        private System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.PictureBox imagen;
    }
}

