﻿namespace actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* 1)	Escribir un programa que permita el ingreso de tres números enteros e informe cuál es el más grande.*/
            
            bool continuar = true;

            while (continuar) 
            { 

                System.Console.WriteLine("Digite el primer numero");
                int n1 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite el segundo numero");
                int n2 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite el tercer numero");
                int n3 = int.Parse(Console.ReadLine());


                    if (n1 > n2 && n1 > n3)
                    {
                    Console.WriteLine(n1 + " es el numero Mayor ");
                    }
                    else if (n2 > n1 && n2 > n3) 
                    {
                    Console.WriteLine(n2 + " es el numero Mayor ");
                    }
                    else
                    {
                    Console.WriteLine(n3 + " es el numero Mayor ");
                    }


                    //NUEVO INGRESO

                bool respuestaValida = false;

                while (!respuestaValida)
                {
                    Console.WriteLine("¿Desea calcular el Mayor de otros 3 numeros?");
                    string respuesta = Console.ReadLine();

                    //Excepcion si se ingresa respuesta != si o no
                    try
                    {
                        if (respuesta.ToLower() == "si") //toLower = convertimos todo a MINUSCULA y 
                        {                                //facilitamos el manejo de la variable
                        respuestaValida = true;
                        }
                        else if (respuesta.ToLower() == "no")
                        {
                        respuestaValida = true;
                        continuar = false;
                        }
                        else
                        {
                        throw new Exception("La respuesta debe ser 'si' o 'no'. Por favor, ingrese una respuesta válida.");
                        }
                    }
                    catch (Exception ex)
                    {
                    Console.WriteLine(ex.Message);
                    }
                }
            }
        }

    }
}
