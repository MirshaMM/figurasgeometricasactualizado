using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figurasgeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)//este boton muestra una ventana al usuario para que sepa que los datos que ingreso se guardaron
        {
            {
                if (cuadrado.Checked)
                {
                    MessageBox.Show("Se guardaron los datos de cuadrado");
                }
                if (triangulo.Checked)
                {
                    MessageBox.Show("Se guardaron los datos de triangulo");
                }
                if (rectangulo.Checked)
                {
                    MessageBox.Show("Se guardaron los datos de rectangulo");
                }
                if (polireg.Checked)
                {
                    MessageBox.Show("Se guardaron los datos de pligono regular");
                }
                if (poliirreg.Checked)
                {
                    MessageBox.Show("Se guardaron los datos de poligono irregular");
                }
                if (circulo.Checked)
                {
                    MessageBox.Show("Se guardaron los datos de circulo");
                }
                if (cubo.Checked)
                {
                    MessageBox.Show("Se guardaron los datos de cubo");
                }
                if (prisma.Checked)
                {
                    MessageBox.Show("Se guardaron los datos de prisma");
                }
                if (esfera.Checked)
                {
                    MessageBox.Show("Se guardaron los datos de esfera");
                }              
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            cuadrado.Checked = false;
            triangulo.Checked = false;
            rectangulo.Checked = false;
            polireg.Checked = false;
            poliirreg.Checked = false;
            circulo.Checked = false;
            cubo.Checked = false;
            prisma.Checked = false;
            esfera.Checked = false;
        }

        private void dibujar_Click(object sender, EventArgs e)
        {
            if (cuadrado.Checked)
            {
                string rutaImagen = "E:\\Usurios\\Desktop\\figurasgeometricasactualizado-master\\figurasgeometricasactualizado-master\\figuras\\cuadrado.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (triangulo.Checked)
            {
                string rutaImagen = "E:\\Usurios\\Desktop\\figurasgeometricasactualizado-master\\figurasgeometricasactualizado-master\\figuras\\triangulo.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (circulo.Checked)
            {
                string rutaImagen = "E:\\Usurios\\Desktop\\figurasgeometricasactualizado-master\\figurasgeometricasactualizado-master\\figuras\\circulo.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (cubo.Checked)
            {
                string rutaImagen = "E:\\Usurios\\Desktop\\figurasgeometricasactualizado-master\\figurasgeometricasactualizado-master\\figuras\\cubo.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (esfera.Checked)
            {
                string rutaImagen = "E:\\Usurios\\Desktop\\figurasgeometricasactualizado-master\\figurasgeometricasactualizado-master\\figuras\\esfera.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (poliirreg.Checked)
            {
                string rutaImagen = "E:\\Usurios\\Desktop\\figurasgeometricasactualizado-master\\figurasgeometricasactualizado-master\\figuras\\poligono irreg.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (polireg.Checked)
            {
                string rutaImagen = "E:\\Usurios\\Desktop\\figurasgeometricasactualizado-master\\figurasgeometricasactualizado-master\\figuras\\poligono.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (prisma.Checked)
            {
                string rutaImagen = "E:\\Usurios\\Desktop\\figurasgeometricasactualizado-master\\figurasgeometricasactualizado-master\\figuras\\poligono.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (rectangulo.Checked)
            {
                string rutaImagen = "E:\\Usurios\\Desktop\\figurasgeometricasactualizado-master\\figurasgeometricasactualizado-master\\figuras\\rectangulo.png";
                imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
        }
    }
}
