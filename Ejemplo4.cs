using System;
using TransversalEjemplo;

namespace TodoEjemplo4
{
    public class Ejemplo4
    {
        public Ejemplo4(){}

        public void Ejecutar()
        {
            Console.WriteLine("* EJEMPLO 4: Interfaces *");
            Console.WriteLine("Solo definiremos comportamiento");
            Console.WriteLine("Paso 1: Ver las definiciones");
            Transversales.Continuar();

            #region PARTE 1
            Console.WriteLine("Paso 2: Tenemos las clases definidas, a probar ... ");
            Transversales.Continuar();

            Cuadrado c1 = new Cuadrado(2,Transversales.Color.Verde);
            TrianguloEquilatero t1 = new TrianguloEquilatero(3,Transversales.Color.Rojo);
            
            Console.WriteLine("Cuadrado de: Perimetro es {0}, Area es {1} y color es {2}",c1.GetPerimetro(),c1.GetArea(),c1.GetColor());
            Console.WriteLine("\nTriangulo de: Perimetro es {0}, Area es {1} y color es {2}",t1.GetPerimetro(),t1.GetArea(),t1.GetColor());

            Transversales.Continuar();
            #endregion

            #region PARTE 2
            Console.WriteLine("Paso 3: Un uso adicional de la intrrfaz");
            Transversales.Continuar();

            Console.WriteLine("-> Nombre para c1");
            ObtenerNombre(c1);
            Transversales.Continuar();
            Console.WriteLine("-> Nombre para t1");
            ObtenerNombre(t1);
            Transversales.Continuar();
            #endregion

            Console.WriteLine("\n* FIN EJEMPLO 4 *");
            Transversales.Continuar();

        }
        #region POLIMORFISMO
        public void ObtenerNombre(IFiguraGeometrica input)
        {
            Console.WriteLine("\n El nombre es:{0}", input.GetNombre());
        }
        #endregion
    }
    #region PARTE 2

    public interface IFiguraGeometrica
    {
        double GetPerimetro();
        double GetArea();
        string GetColor();
        string GetNombre();
    }
    public class Cuadrado:IFiguraGeometrica
    {
        public double Lado {get;set;}
        public Transversales.Color Color {get;set;}
        public Cuadrado(double Lado,Transversales.Color Color)
        {
            this.Color = Color;
            this.Lado = Lado;
        }
        public double GetPerimetro() => 4*Lado;
        public double GetArea() => Math.Pow(Lado,2);
        public string GetNombre() => "Cuadrado";
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
    public class TrianguloEquilatero:IFiguraGeometrica
    {
        public double Base {get;set;}
        private double Altura {get;set;}
        public Transversales.Color Color {get;set;}
        public TrianguloEquilatero(double Base,Transversales.Color Color):base()
        {
            this.Altura = Math.Sqrt(3)*Base/2;
            this.Base = Base;
            this.Color = Color;
        }
        public double GetPerimetro() => 3*Base;
        public double GetArea() => Altura*Base/2;
        public string GetNombre() => "Triangulo";
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
    
    #endregion
}