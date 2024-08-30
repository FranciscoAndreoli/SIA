using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace agenteReactivoSimple
{
    internal class AgenteReactivoSimple
    {
        Dictionary<int, string> dict = new Dictionary<int, string>(){
            {1, "Coca-Cola"},
            {2, "Snickers"},
            {3, "M&M's"},
            {4, "Galletas Oreo"},
            {5, "KitKat"},
            {6, "Gomitas de osito"},
            {7, "Chicles"},
            {8, "Papitas Lays"},
            {9, "Milka"},
            {10, "Skittles"}
        };

        public AgenteReactivoSimple()
        {
            PrintMenu();
            Actuar();
        }

        public void PrintMenu()
        {
            Console.WriteLine("Bienvenido al expendio de golosinas. Ingrese un valor del menú!");
            foreach (var candy in dict)
            {
                Console.WriteLine($"{candy.Key}: {candy.Value}");
            }
        }

        public void Actuar()
        {

            int value = 0;
            do
            {
                Console.WriteLine("\nTu selección: ");
                bool success = int.TryParse(Console.ReadLine(), out value);
               if(success && dict.ContainsKey(value))
               {
                    string money;
                    Console.WriteLine($"Elegiste: {dict[value]}. Sin embargo, nada es gratis en esta vida. Ingresá 200 pesos: ");
                    do
                    {
                        money = Console.ReadLine();
                        if (money == "200") { Console.WriteLine($"Tu {dict[value]} fue servido. Gracias y adiós!"); } else { Console.WriteLine("Tenías una tarea: Ingresar 200 pesos. Intentalo de nuevo: "); }
                    
                    } while (money != "200");
                    
                }
               else
               {
                    Console.WriteLine("Error al elegir una bebida. Intentalo de nuevo");
               }
            } while (value > 10 || value < 1);
            
        }
    }
}
