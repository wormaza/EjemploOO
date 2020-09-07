using System;
using TodoEjemplo1;
using TodoEjemplo2;
using TodoEjemplo3;
using TodoEjemplo4;

namespace EjemploOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJEMPLOS OO - INF 236 ---");
            
            bool read = true;
            int opcion = 0;

            do{
                Console.WriteLine("Seleccionar alguna de las siguientes opciones:");
                Console.WriteLine("1: Definción de un objeto");
                Console.WriteLine("2: Herencia y polimorfismo");
                Console.WriteLine("3: Clases abstractas");
                Console.WriteLine("4: Interfaces");
                Console.WriteLine("0: Salir");
                Console.WriteLine("Indique su opcion:");
                var op = Console.ReadLine();
                read = int.TryParse(op,out opcion);
                if(!read || opcion == 0)
                    break;
                
                switch(opcion)
                {
                    case 1: (new Ejemplo1()).Ejecutar();
                            break;
                    case 2: (new Ejemplo2()).Ejecutar();
                            break;
                    case 3: (new Ejemplo3()).Ejecutar();
                            break;
                    case 4: (new Ejemplo4()).Ejecutar();
                            break;                        
                    default: break;
                }
            }while(read);
            Console.WriteLine("--- FIN DEL EJEMPLO ---");
        }
    }
}
