using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    internal class Cubo:Figura//la clase cubo es hija de la clase figura
    {
        public Cubo(float lado1)
        {
            this.Lado1 = lado1;

        }
        public override float area() //calcula el area 
        {
            return (Lado1 * Lado1) * 6; //primero se multiplica lado por lado para sacar el area de la cara
        }                              //luego se multiplica 6 veces porque un cubo tiene 6 caras
        public override float perimetro()//aqui se calcula el perimetro
        {
            return Lado1 * 12;//se multiplica por 12 porque un cubo tiene 12 aristas en total
        }
        public override float volumen()//aquí se calcula el volumen porque es una figura tridimensional
        {                              //se usa la medida del lado para el ancho, alto y profundidad
                                       //se multiplica acho * altro * profundidad
            return Lado1 * Lado1 * Lado1;
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
