using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    class Esfera:Figura //la clase esfera es hija de clase figura
    {
        {
        //usamos el constructor de la clse padre
        public Circulo(float radio)
        {//radio se va a leer de la caja de texto con
            //usando el boton guardar
            Lado1 = radio;
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estos
        public override float area()
        {
            return 4* 3.1416F * (Lado1 * Lado1);//formula para sacar el area
            //agregamos F al final de un numero cuando es una constante no definida en una variable previamnete
            //asi el programa sabe qeu es un #
        }
        public override float perimetro()
        {
              throw new NotImplementedException();
            //ESTA ES UNA EXCEPCION DEFAULT DEL SISTEMA
        }
        public override float volumen()
        {
          return 4/3*3.1416F * (Lado1*Lado1*Lado1); //esta es la dormula para sacar el volumen de una esfera
        }
    }
}
