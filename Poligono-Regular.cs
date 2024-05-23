using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    class Poligono_Regular:Figura //la clase poligono regular es hija de la clase figura --> (clase principal/papá)
    {
        //declarar dos valores float para guardar numero de lados
        //y el apotema privados para usarse solo en esta clase
        private float apo, n;
        public float Apo //valor apotema existente o real
        {
            set 
            {
                //pregunta si el apotema (es el numero del centro del poligono) <0
                if (value <= 0)
                {
                    apo = 0; //manda el valor a 0
                } //NO EXISTEN APOTEMAS NEGATIVOS
                else 
                {
                    apo = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return apo; //regresa o cacha el valor de la variable apotema
            }
        }
        public float N //validar el numero de lados <5
        {
            set 
            {
                //pregunta si el numero de lados (n) >5
                if (value < 5)
                {
                    n = 5; //manda el valor a 0   
                }//NO EXISTEN APOTEMAS NEGATIVOS
                else
                {
                    n = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return n; //regresa o cacha el valor de la variable lado1
            }
        }
        //usamos el constructor de la clase poligono regular
        public Poligono_Regular (float lado, float apo, float n)
        {//radio se va a leer de la caja de texto con
            //usando el boton guardar
            Lado1 = lado1;
            Apo = apo;
            N = n;
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estas
        public float area(float peri) //modelo sobrecargado que recibe el perimetro y lo utiliza
        {
            return (peri * apo) / 2;
        }
        public override float perimetro ()//metodo con variable de paso qeu guarda el perimetro
        {
            float peri;
            peri = n * Lado1;
            return peri;
        }
        public override float volmen ()
        {
           throw new Not.ImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
         public override float area ()
        {
           throw new Not.ImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
