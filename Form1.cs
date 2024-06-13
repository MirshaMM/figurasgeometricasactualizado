using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void guardar_Click(object sender, EventArgs e)//este boton muestra una ventana al usuario para que sepa que los datos que ingreso se guardaron
        {
            MessageBox.Show("DATOS GUARDOS" + GUARDAR.Text, "Datos de alumno",
       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            texto.Clear();
            imagen.Image = (figurasgeometricas.Properties.Resources.cuadrado);
            medida.Clear();
            cuadrado.Checked = false;
            triangulo.Checked = false;
            rectangulo.Checked = false;
            esfera.Checked = false;
            circulo.Checked = false;
            cubo.Checked = false;
            prisma.Checked = false;
            polii.Checked = false;
            polir.Checked = false;
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

         private void INFORMACION_Click(object sender, EventArgs e)
        {
            if (cuadrado.Checked)
            {
                texto.Text = "Figura seleccionada: Cuadrado, " + "\n" +
                    "Sus datos son:" + "\n" +
                    "Longitud del lado: "
                    + medida.Text;
            }
            else if (triangulo.Checked)
            {
                texto.Text = "Figura seleccionada Triangulo, " +
                    "Sus datos son:"
                    + medida.Text;
            }
            else if (rectangulo.Checked)
            {
                texto.Text = "Figura seleccionada Rectangulo, " +
                    "Sus datos son:"
                    + medida.Text;
            }
            else if (polir.Checked)
            {
                texto.Text = "Figura seleccionada Poligono Regular, " +
                    "Sus datos son:"
                    + medida.Text;
            }
            else if (polii.Checked)
            {
                texto.Text = "Figura seleccionada Poligono Irregular, " +
                    "Sus datos son:"
                    + medida.Text;
            }
            else if (circulo.Checked)
            {
                texto.Text = "Figura seleccionada Círculo, " +
                    "Sus datos son:"
                    + medida.Text;
            }
            else if (cubo.Checked)
            {
                texto.Text = "Figura seleccionada Cubo, " +
                    "Sus datos son:"
                    + medida.Text;
            }
            else if (prisma.Checked)
            {
                texto.Text = "Figura seleccionada Prisma, " +
                    "Sus datos son:"
                    + medida.Text;
            }
            else if (esfera.Checked)
            {
                texto.Text = "Figura seleccionada Esfera, " +
                    "Sus datos son:"
                    + medida.Text;
            }
        }

        private void EXPORTAR_Click(object sender, EventArgs e)
        {
            try //EXCEPCIÓN
            {
                string fileName =
                    @"E:\Usurios\Desktop\figurasgeometricasactualizado-master\figurasgeometricasactualizado-master\datosg\info.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //  writer.WriteLine("Este es un dato nuevo desde guardar");
                writer.WriteLine("Datos: " + texto.Text);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar los Datos", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (MessageBox.Show("¿Quieres salir de la aplicacion?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            if (cuadrado.Checked)
            {
                texto.Text = texto.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                    + "\n";
            }
            else if (triangulo.Checked)
            {
                texto.Text = texto.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (rectangulo.Checked)
            {
                texto.Text = texto.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                      + "\n";
            }
            else if (polir.Checked)
            {
                texto.Text = texto.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                    + "\n";
            }
            else if (polii.Checked)
            {
                texto.Text = texto.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (circulo.Checked)
            {
                texto.Text = texto.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (cubo.Checked)
            {
                texto.Text = texto.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                   + "\n";
            }
            else if (prisma.Checked)
            {
                texto.Text = texto.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                  + "\n";
            }
            else if (esfera.Checked)
            {
                texto.Text = texto.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                   + "\n";
            }
        }

        private void DIBUJAR_Click(object sender, EventArgs e)
        {
            if (cuadrado.Checked)
            {
                imagen.Image = (figurasgeometricas.Properties.Resources.cuadrado);
            }
            else if (triangulo.Checked)
            {
                imagen.Image = (figurasgeometricas.Properties.Resources.triangulo);
            }
            else if (rectangulo.Checked)
            {
                imagen.Image = (figurasgeometricas.Properties.Resources.rectangulo);
            }
            else if (polir.Checked)
            {
                imagen.Image = (figurasgeometricas.Properties.Resources.poligono);
            }
            else if (polii.Checked)
            {
                imagen.Image = (figurasgeometricas.Properties.Resources.poligonoirreg);
            }
            else if (circulo.Checked)
            {
                imagen.Image = (figurasgeometricas.Properties.Resources.circulo);
            }
            else if (cubo.Checked)
            {
                imagen.Image = (figurasgeometricas.Properties.Resources.cubo);
            }
            else if (prisma.Checked)
            {
                imagen.Image = (figurasgeometricas.Properties.Resources.prisma);
            }
            else if (esfera.Checked)
            {
                imagen.Image = (figurasgeometricas.Properties.Resources.esfera);
            }
        }
    }
}
