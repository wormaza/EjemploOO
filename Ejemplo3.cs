using System;
using TransversalEjemplo;

namespace TodoEjemplo3
{
    public class Ejemplo3
    {
        public Ejemplo3(){}

        public void Ejecutar()
        {
            Console.WriteLine("* EJEMPLO 3: Clases Abstractas *");
            Console.WriteLine("En estricto rigor, 'Figura geometrica' es una representacion, un concepto");
            Console.WriteLine("No tiene sentido crear instancias de esta");
            Console.WriteLine("Paso 1: Ver como se definen");
            Transversales.Continuar();

            #region PARTE 1
            Console.WriteLine("Paso 2: Tenemos las clases definidas, a probar ... ");
            Transversales.Continuar();

            //FiguraGeometrica f = new FiguraGeometrica(1,1,Transversales.Color.Amarillo);
            Cuadrado c1 = new Cuadrado(2,Transversales.Color.Verde);
            TrianguloEquilatero t1 = new TrianguloEquilatero(3,Transversales.Color.Rojo);
            
            Console.WriteLine("Cuadrado de: Perimetro es {0}, Area es {1} y color es {2}",c1.GetPerimetro(),c1.GetArea(),c1.GetColor());
            Console.WriteLine("\nTriangulo de: Perimetro es {0}, Area es {1} y color es {2}",t1.GetPerimetro(),t1.GetArea(),t1.GetColor());

            Transversales.Continuar();
            #endregion

            #region PARTE 2
            Console.WriteLine("Paso 3: ¿Que pasa con el último ejemplo del polimorfismo?");
            Transversales.Continuar();

            Console.WriteLine("-> Nombre para c1");
            ObtenerNombre(c1);
            Transversales.Continuar();
            Console.WriteLine("-> Nombre para t1");
            ObtenerNombre(t1);
            Transversales.Continuar();
            #endregion

            Console.WriteLine("\n* FIN EJEMPLO 3 *");
            Transversales.Continuar();

        }

        #region POLIMORFISMO
        public void ObtenerNombre(FiguraGeometrica input)
        {
            Console.WriteLine("\n El nombre es:{0}", input.Nombre);
        }
        #endregion

    }

   #region PARTE 2

    public abstract class FiguraGeometrica
    {
        public double Altura {get;set;}
        public double Base {get;set;}
        public Transversales.Color Color {get;set;}
        public string Nombre {get;set;}
        public FiguraGeometrica(){} 
        public FiguraGeometrica(double Altura, double Base, Transversales.Color Color)
        {
            this.Altura = Altura;
            this.Base = Base;
            this.Color = Color;
        }
        public abstract double GetPerimetro();
        public abstract double GetArea();
        public string GetColor()
        {
            switch((int)Color)
            {
                case (int)Transversales.Color.Amarillo: return "Soy amarillo";
                                                        
                case (int)Transversales.Color.Azul: return "Soy azul";
                                                        
                case (int)Transversales.Color.Rojo: return "Soy rojo";
                                                        
                case (int)Transversales.Color.Verde: return "Soy verde";
                                                        
                default: return "No se que color es";
                                                        
            }
        }
    }

    public class Cuadrado:FiguraGeometrica
    {
        public double Lado {get;set;}
        public Cuadrado(double Altura,double Base,Transversales.Color Color):base(Altura,Base,Color)
        {
            this.Lado = Altura;
            Nombre = "Cuadrado";
        }
        public Cuadrado(double Lado,Transversales.Color Color):base()
        {
            this.Altura = Lado;
            this.Base = Lado;
            this.Color = Color;
            this.Lado = Lado;
            Nombre = "Cuadrado";
        }

        public override double GetPerimetro() => 4*Lado;
        public override double GetArea() => Math.Pow(Altura,2);
    }
    
    public class TrianguloEquilatero:FiguraGeometrica
    {
        public TrianguloEquilatero(double Altura,double Base,Transversales.Color Color):base(Altura,Base,Color)
        { 
            Nombre = "Triangulo";
        }
        public TrianguloEquilatero(double Base,Transversales.Color Color):base()
        {
            this.Altura = Math.Sqrt(3)*Base/2;
            this.Base = Base;
            this.Color = Color;
            Nombre = "Triangulo";
        }

        public override double GetPerimetro() => 3*Base;
        public override double GetArea() => Altura*Base/2;
    }
    
    #endregion


}