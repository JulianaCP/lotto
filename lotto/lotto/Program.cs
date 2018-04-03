using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto
{
    class Program
    {

        static ArrayList listaNumerosEscogidosEnLotto = new ArrayList();
        static ArrayList listaNumerosEscogidosPorUsuario = new ArrayList();

        static void Main(string[] args)
        {

            llenarArrayUsuario();
            Console.WriteLine("Cantidad Secuencias hasta encontrar \n\n");
            comprobarNumerosIguales();
            Console.WriteLine("\n\n Cantidad Secuencias hasta 100 \n\n");
            cantidadRepeticionesCicloHasta100();

        }

 


        static void llenarArrayUsuario()
        {
            listaNumerosEscogidosPorUsuario.Add(4);
            listaNumerosEscogidosPorUsuario.Add(6);
            listaNumerosEscogidosPorUsuario.Add(14);
            listaNumerosEscogidosPorUsuario.Add(20);
            listaNumerosEscogidosPorUsuario.Add(3);

        }

        static void comprobarNumerosIguales()
        {
            int cantSecuencias = 0;
            int cantNumerosRepetidos = 0;
            while (true)
            {

               
                cantNumerosRepetidos = 0;
                llenarArrayNumerosEscogidosEnLotto();
                foreach(int contNumUsuario in listaNumerosEscogidosPorUsuario)
                {
                    foreach(int contNumLotto in listaNumerosEscogidosEnLotto)
                    {
                        if(contNumUsuario==contNumLotto)
                        {
                        
                            cantNumerosRepetidos++;
                        }
                        
                    }
                 
                }

                cantSecuencias++;
                if (cantNumerosRepetidos == 5)
                {
                    Console.WriteLine("Pego los 5 numeros");
                    break;
                }
            }

           
            
            Console.WriteLine("cantidad secuencias: " + cantSecuencias);


        }

        static void llenarArrayNumerosEscogidosEnLotto()
        {
            listaNumerosEscogidosEnLotto.Clear();

            Random ramdom = new Random();
            int numero;

            for(int i=0; i<5; i++)
            {
                numero = ramdom.Next(1, 35);
                listaNumerosEscogidosEnLotto.Add(numero);
            }



        }

        static int cantSecuenciasTotales = 0;
        static void cantidadRepeticionesCicloHasta100()
        {
            int numeroDeRepeticion = 0;

         
            int cantNumerosRepetidos = 0;
            for (int i = 0; i < 100; i++)
            {
                

                while (true)
                {


                    cantNumerosRepetidos = 0;
                    llenarArrayNumerosEscogidosEnLotto();
                    foreach (int contNumUsuario in listaNumerosEscogidosPorUsuario)
                    {
                        foreach (int contNumLotto in listaNumerosEscogidosEnLotto)
                        {
                            
                            if (contNumUsuario == contNumLotto)
                            {

                                cantNumerosRepetidos++;
                            }

                        }

                    }

                    cantSecuenciasTotales++;
                    if (cantNumerosRepetidos == 5)
                    {
                        Console.WriteLine("Pego los 5 numeros ");
                        
                        break;
                    }
                }
                numeroDeRepeticion++;
                Console.WriteLine("ciclo numero: " + numeroDeRepeticion +"\n");

            }
            int media = cantSecuenciasTotales / 100;
            Console.WriteLine("cantidad total de repeticiones en 100: " + cantSecuenciasTotales + "\n\n");
            Console.WriteLine("Media de la ejecucion de 100: " + media);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
