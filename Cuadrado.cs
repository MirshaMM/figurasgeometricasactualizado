using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    class Cuadrado: Figura//la clase cuadrado es hija de la clase figura
    {
        public Cuadrado(float lado1)
        {
            this.Lado1 = lado1;

        }
        public override float area() //calcula el area del cubo con los valores que haya ingresado el usuario
        {
            return Lado1 * Lado1; //se multiplica el lado para saber el area de la cara
        }
        public override float perimetro() //calcula el perimetro del cubo con los valores que haya ingresado el usuario
        {
            return Lado1 * 4;//la medida del lado se multiplica 4 veces o también se puede sumer 4 veces
        }
        public override float volumen()//calcula el volumen del cubo con los valores que haya ingresado el usuario
        {//no se puede calcular el volumen de un cuadrado porque solo tiene 2 dimensiones
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
