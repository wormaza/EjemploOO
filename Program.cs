using System;
using TodoEjemplo1;
using TodoEjemplo2;

namespace EjemploOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJEMPLOS OO - INF 236 ---");
            Console.WriteLine("Seleccionar alguna de las siguientes opciones:");
            Console.WriteLine("1: Definción de un objeto");
            Console.WriteLine("2: Herencia y polimorfismo");
            Console.WriteLine("0: Salir");

            bool read = true;
            int opcion = 0;

            do{
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
                    default: break;
                }
            }while(read);
            Console.WriteLine("--- FIN DEL EJEMPLO ---");
        }
    }
}
