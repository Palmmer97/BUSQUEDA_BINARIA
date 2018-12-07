using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSQUEDABINARIA
{
    class Program
    {




////        Búsqueda binaria

////Este metodo compara el elemento central del arreglo con el valor buscado, si estos coinciden finaliza la busqueda,
//        en cambio si no ocurre asi el elemento buscado 
////sera mayor o menor en sentido esctricto que el central del arreglo. Si el elemento buscado es mayor se procede a 
//hacer busqeuda binaria en el subarray superior, si
////el elemento buscado es menor que el contenido de la casilla central, se debe cambiar el segmento a considerarel 
//segmento que esta ala izquierda del sitio central.

////Para utilizar este algoritmo, el array debe estar ordenado. La búsqueda binaria consiste en dividir el array por su
//elemento medio en dos subarrays más 
////pequeños, y comparar el elemento con el del centro. Si coinciden, la búsqueda se termina. Si el elemento es menor,
//debe estar (si está) en el primer subarray,
//// y si es mayor está en el segundo. 
        static void Main(string[] args)
        {
        perro:
            Console.Title = "METODO BUSQUEDA BINARIA Alejandro Lopez Garcia 16210545";
            Console.Clear();
            Console.WriteLine(@"Seleccione el ejercicio
1.- -BUSQUEDA NUMEROS  (1)
2.- BUSQUEDA NOMBRES (2)
3.- Salir (3)");
            int a = int.Parse(Console.ReadLine());

            BUSQUEDA OBJ = new BUSQUEDA();


            if (a == 1)
            {
                Console.Title = "BUSQUEDA BINARIA DE NUMEROS RANDOM";
                OBJ.INSERCION();
                OBJ.DESPLIEGE();
                Console.WriteLine("QUE NUMERO DESEAS?: ");
                int PAL = int.Parse(Console.ReadLine());
                OBJ.MTODO_DE_BUSQUEDA(PAL);
                OBJ.METODO_DE_ORDENAMIENTO();
                Console.WriteLine("\n\nTeclee cualquier tecla");
                Console.ReadKey();
                goto perro;
            }
            if (a == 2)
            {
                Console.Title = "BUSQUEDA DE NOMBRES DE CIUDADES";
                OBJ.INGRESAR();
                OBJ.DESPLEGAR();
                Console.WriteLine("CIUDAD BUSCA?: ");
                string PAL = Console.ReadLine();
                OBJ.METODO_DE_BUSQUEDA(PAL);
                OBJ.METODODEORDENAMIENTO();
                Console.ReadKey();
                Console.WriteLine("\n\nTeclee cualquier tecla");
                Console.ReadKey();
                goto perro;


            }
            if (a == 3)
            {

                Console.WriteLine("Teclee cualquier tecla");
                Console.Clear();

            }
        }
    }
}
