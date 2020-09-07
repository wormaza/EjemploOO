using System;
using TransversalEjemplo;

namespace TodoEjemplo1
{
    public class Ejemplo1
    {
        public Ejemplo1(){}

        public void RunEjemplo1()
        {
            Console.WriteLine("* EJEMPLO 1: Creando un objeto *");
            Console.WriteLine("Paso 1: Revisar la estructura de la clase 'cuadrado'");
            Transversales.Continuar();
            Console.WriteLine("Paso 2: Creemos una instancia de la clase, de color rojo y de lado 8");
            Transversales.Continuar();

            #region PARTE 1
            
            Cuadrado cuadrado1 = new Cuadrado(8,Transversales.Color.Rojo);
            
            Console.WriteLine(String.Format("Su permitro es:{0}",cuadrado1.GetPerimetro()));
            Console.WriteLine(String.Format("Su area es:{0}",cuadrado1.GetArea()));
            cuadrado1.GetColor();

            #endregion
            
            Console.WriteLine("\nA la instancia de la clase, la llamamos Objeto");
            Transversales.Continuar();
            Console.WriteLine("Paso 3: Creemos otra instancia de la clase, de color verde y de lado 1");
            Transversales.Continuar();
            
            #region PARTE 2
            
            Cuadrado cuadrado2 = new Cuadrado(1,Transversales.Color.Verde);
            
            Console.WriteLine(String.Format("Perimetro cuadrado 2 es:{0}",cuadrado2.GetPerimetro()));
            Console.WriteLine(String.Format("Area cuadrado 2 es:{0}",cuadrado2.GetArea()));
            cuadrado2.GetColor();

            Console.WriteLine(String.Format("\nPerimetro cuadrado 2 es:{0} vs Perimetro cuadrado 1 que es: {1}"
                             ,cuadrado2.GetPerimetro(),cuadrado1.GetPerimetro()));

            #endregion
            
            Console.WriteLine("\nTenemos multiples instancias (objetos), de la misma clase");
            Console.WriteLine("\n* FIN EJEMPLO 1 *");
            Transversales.Continuar();
        }
    }

    public class Cuadrado
    {
        public int Lado {get;set;}
        public Transversales.Color Color {get;set;} 
        public Cuadrado(int Lado, Transversales.Color Color)
        {
            this.Lado = Lado;
            this.Color = Color;
        }

        public int GetPerimetro() => 4*Lado;
        public int GetArea() => (int)Math.Pow(Lado,2);
        public void GetColor()
        {
            switch((int)Color)
            {
                case (int)Transversales.Color.Amarillo: Console.WriteLine("Soy amarillo");
                                                        break;
                case (int)Transversales.Color.Azul: Console.WriteLine("Soy azul");
                                                        break;
                case (int)Transversales.Color.Rojo: Console.WriteLine("Soy rojo");
                                                        break;
                case (int)Transversales.Color.Verde: Console.WriteLine("Soy verde");
                                                        break;
                default: Console.WriteLine("No se que color es");
                                                        break;

            }
        }
    }
}