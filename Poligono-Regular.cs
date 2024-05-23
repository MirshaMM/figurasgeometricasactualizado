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
    }
}
