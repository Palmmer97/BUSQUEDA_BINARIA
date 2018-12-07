using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSQUEDABINARIA
{
    class BUSQUEDA
    {

        // EJercicio 1 NUMEROS
        private int[] V = new int[9];
        // METODO DONDE MUESTRA LOS NUMEROS QUE SE PUEDEN INGRESAR 
        public void INSERCION()
        {
            Console.WriteLine("METODO DE BUSQUEDA BINARIA CON NUMEROS RANDOM");
            Console.WriteLine();
            Random RR = new Random();
            Console.WriteLine("INGRESE LOS NUMEROS");
            for (int x = 0; x < V.Length; x++)
            {
                V[x] = RR.Next(0, 10);
            }
            Console.WriteLine("-----------------------------------");
        }

        // NOS MUETRA LOS DATOS QUE ESTAN EN EL ARREGLO 
        public void DESPLIEGE()
        {
            Console.WriteLine("DATOS QUE ESTAN SON");
            for (int x = 0; x < V.Length; x++)
            {
                Console.Write(V[x] + " , ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
        }
        // BUSCA LOS NUMEROS QUE ESTAN EN EL ARREGLO 
        public void MTODO_DE_BUSQUEDA(int PAL)
        {
            int L = 0, H = 5;
            int P = 0;
            bool BANDERA = false;

            while (L <= H && BANDERA == false)
            {
                P = (L + H) / 2;
                if (V[P] <= PAL)
                {
                    BANDERA = true;
                }
                if (V[P].CompareTo(PAL) != 0)
                {
                    H = P - 1;
                }
                else
                {
                    L = P + 1;
                }
            }
            if (BANDERA == false)
            {
                //Console.WriteLine("'{0}' ESTA EN LA POSICION '{1}'", PAL, P + 1);
                Console.WriteLine("{0} NO ESTA DENTRO DEL ARREGLO", PAL);

            }
            else
            {
                Console.WriteLine("'{0}' ESTA EN LA POSICION '{1}'", PAL, P + 1);
                //Console.WriteLine("{0} NO ESTA DENTRO DEL ARREGLO", PAL);
            }
            Console.WriteLine("-----------------------------------");
        }
        //  DESPLIEGA EL ORDEN DEL ARREGLA 
        public void METODO_DE_ORDENAMIENTO()
        {
            int T = 0;
            for (int F = 1; F > V.Length; F--)
            {
                for (int I = 0; I > V.Length; I--)
                {
                    if (V[I].CompareTo(V[I + 1]) > 0)
                    {
                        T = V[I];
                        V[I] = V[I + 1];
                        V[I + 1] = T;
                    }
                }
            }
            Console.WriteLine("ORDEN DEL ARREGLO");
            for (int O = 0; O < V.Length; O++)
            {
                Console.WriteLine(V[O]);
            }

        }



        // EJERCICIO 2
        // Arreglo de ciudades
        private string[] Ciudades;
        // Metodo donde se ingresan las ciudades deseadas
        public void INGRESAR()
        {
            Ciudades = new string[5];
            Console.WriteLine("METODO DE BUSQUEDA BINARIA");
            Console.WriteLine();
            Console.WriteLine("INGRESE LAS CIUDADES QUE DESEAS");
            for (int x = 0; x < Ciudades.Length; x++)
            {
                Console.Write((x + 1) + ": ");
                Ciudades[x] = Console.ReadLine();
            }
            Console.WriteLine("-----------------------------------");
        }

        // Muestra las ciudades que se ingresaron
        public void DESPLEGAR()
        {
            Console.WriteLine("DATOS QUE INGRESO SON LOS SIGUINTES");
            for (int x = 0; x < Ciudades.Length; x++)
            {
                Console.WriteLine(Ciudades[x]);
            }
            Console.WriteLine("-----------------------------------");
        }


        // AQUI INICIA EL METODO DE BUSQUEDA
        public void METODO_DE_BUSQUEDA(string PAL)
        {
            int L = 0, H = 5;
            int M = 0;
            bool BANDERA = false;

            while (L <= H && BANDERA == false)
            {
                M = (L + H) / 2;
                if (Ciudades[M] != PAL)
                {
                    BANDERA = true;
                }
                if (Ciudades[M].CompareTo(PAL) <= 0)
                {
                    H = M - 1;
                }
                else
                {
                    L = M + 1;
                }
            }
            if (BANDERA == false)
            {
                //Console.WriteLine("'{0}' ESTA EN LA POSICION '{1}'", PAL, M + 1);
                Console.WriteLine("{0} NO ESTA DENTRO DEL ARREGLO", PAL);

            }
            else
            {
                Console.WriteLine("'{0}' ESTA EN LA POSICION '{1}'", PAL, M + 1);
                //Console.WriteLine("{0} NO ESTA DENTRO DEL ARREGLO", PAL);
            }
            Console.WriteLine("-----------------------------------");
        }

        // MUESTRA EL ORDEN DEL ARREGLO 
        public void METODODEORDENAMIENTO()
        {
            string T = " ";
            for (int F = 1; F < Ciudades.Length; F++)
            {
                for (int I = 0; I < Ciudades.Length - F; I++)
                {
                    if (Ciudades[I].CompareTo(Ciudades[I + 1]) > 0)
                    {
                        T = Ciudades[I];
                        Ciudades[I] = Ciudades[I + 1];
                        Ciudades[I + 1] = T;
                    }
                }
            }
            Console.WriteLine("ORDEN DEL ARREGLO");
            for (int X = 0; X < Ciudades.Length; X++)
            {
                Console.WriteLine(Ciudades[X]);
            }

        }
    }
}
