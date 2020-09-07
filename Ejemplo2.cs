using System;
using TransversalEjemplo;

namespace TodoEjemplo2
{
    public class Ejemplo2
    {
        public Ejemplo2(){}

        public void Ejecutar()
        {
            Console.WriteLine("* EJEMPLO 2: Herencia y Polimorfismo*");
            Console.WriteLine("Paso 1: Analizar las estructuras de las clase CuadradoBase y TrianguloBase");
            Transversales.Continuar();

            Console.WriteLine("Paso 2: Tenemos las clases definidas, a probar ... ");
            
            #region IMPLEMENTACION PARTE 1

            CuadradoBase cuadrado1 = new CuadradoBase(2,2,Transversales.Color.Azul);
            TrianguloEquilateroBase triangulo1 = new TrianguloEquilateroBase(2.5,3,Transversales.Color.Rojo);

            Console.WriteLine("\nCuadrado de: Perimetro es {0}, Area es {1} y color es {2}",cuadrado1.GetPerimetro(),cuadrado1.GetArea(),cuadrado1.GetColor());
            Console.WriteLine("\nTriangulo de: Perimetro es {0}, Area es {1} y color es {2}",triangulo1.GetPerimetro(),triangulo1.GetArea(),triangulo1.GetColor());
            
            #endregion

            #region IMPLEMENTACION PARTE 2

            Transversales.Continuar();
            
            Console.WriteLine("Pero, hay cosas 'comunes' y otras no tanto ... vea las definiciones de la parte 2 ");
            Transversales.Continuar();
            Console.WriteLine("Crearemos diferentes instancias de cada clase");
            Transversales.Continuar();

            FiguraGeometrica f = new FiguraGeometrica(1,1,Transversales.Color.Amarillo);
            Cuadrado c1 = new Cuadrado(2,Transversales.Color.Verde);
            TrianguloEquilatero t1 = new TrianguloEquilatero(3,Transversales.Color.Rojo);

            Console.WriteLine("Cuadrado de: Perimetro es {0}, Area es {1} y color es {2}",c1.GetPerimetro(),c1.GetArea(),c1.GetColor());
            Console.WriteLine("\nTriangulo de: Perimetro es {0}, Area es {1} y color es {2}",t1.GetPerimetro(),t1.GetArea(),t1.GetColor());

            Transversales.Continuar();
            
            #endregion

            #region IMPLEMENTACION POLIMORFISMO 2
            Console.WriteLine("--> Diferentes implementaciones del mismo metodo heredado: Polimorfismo dinamico");
            Transversales.Continuar();
            
            Console.WriteLine("\nPolimorfismo estatico:");
            EjemploPolimorfismoEstatico();
            EjemploPolimorfismoEstatico(8);
            Transversales.Continuar();
            Console.WriteLine("-> Nombre para f");
            ObtenerNombre(f);
            Transversales.Continuar();
            Console.WriteLine("-> Nombre para c1");
            ObtenerNombre(c1);
            Transversales.Continuar();
            Console.WriteLine("-> Nombre para t1");
            ObtenerNombre(t1);
            Transversales.Continuar();
            #endregion

            Console.WriteLine("\n* FIN EJEMPLO 2 *");
            Transversales.Continuar();
        }

        #region POLIMORFISMO
        public void EjemploPolimorfismoEstatico()
        {
            Console.WriteLine("\nEjemplo polimorfismo estatico");
        }
        public void EjemploPolimorfismoEstatico(int i)
        {
            Console.WriteLine("\nEjemplo polimorfismo estatico, {0}",i);
        }
        public void ObtenerNombre(FiguraGeometrica input)
        {
            Console.WriteLine("El nombre es:{0}", input.Nombre);
        }

        #endregion
    }

    #region PARTE 1

    public class CuadradoBase
    {
        public double Altura {get;set;}
        public double Base {get;set;}
        public Transversales.Color Color {get;set;} 
        public CuadradoBase(double Altura, double Base, Transversales.Color Color)
        {
            this.Altura = Altura;
            this.Base = Base;
            this.Color = Color;
        }

        public double GetPerimetro() => 4*Base;
        public double GetArea() => Math.Pow(Base,2);
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

    public class TrianguloEquilateroBase
    {
        public double Altura {get;set;}
        public double Base {get;set;}
        public Transversales.Color Color {get;set;} 
        public TrianguloEquilateroBase(double Altura, double Base, Transversales.Color Color)
        {
            this.Altura = Altura;
            this.Base = Base;
            this.Color = Color;
        }

        public double GetPerimetro() => 3*Base;
        public double GetArea() => (Base*Altura/2);
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

    #region PARTE 2
    public class FiguraGeometrica
    {
        public double Altura {get;set;}
        public double Base {get;set;}
        public Transversales.Color Color {get;set;}
        public string Nombre {get;set;} = "Figura";
        public FiguraGeometrica(){} 
        public FiguraGeometrica(double Altura, double Base, Transversales.Color Color)
        {
            this.Altura = Altura;
            this.Base = Base;
            this.Color = Color;
        }
        public virtual double GetPerimetro() => 0;
        public virtual double GetArea() => 0;
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