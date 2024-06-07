using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucles_parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PUNTO UNO, SUMAR NUMEROS 

            int numeros = 0;
            char selec;
            int suma = 0;

            do
            {
                Console.WriteLine("ingrese los numeros ");
                numeros = int.Parse(Console.ReadLine());
                suma = suma + numeros;

                Console.WriteLine(" desea ingresar otro numero? presione S si es afirmativo o N si desea salir ");
                selec = char.Parse(Console.ReadLine());

            } while (selec != 'n');

            Console.WriteLine(" la suma de sus numeros es " + suma);

            // PUNTO DOS, CONTAR HASTA UN NUMERO 

            int num3 = 0;
            int cont2 = 0;


            Console.WriteLine(" ingrese el numero hasta donde desea contar");
            num3 = int.Parse(Console.ReadLine());

            do
            {

                Console.WriteLine(cont2);
                cont2++;

            } while (cont2 <= num3);

            //PUNTO TRES, CONVERTIR TEMPERATURAS 

            double celsius;
            double faren;
            char son;

            do
            {
                Console.WriteLine(" ingrese en celsius la temperatura a comvertir");
                celsius = double.Parse(Console.ReadLine());
                faren = celsius * 1.8 + 32;
                Console.WriteLine(" la temperatura en fahremheit es " + faren);
                Console.WriteLine(" desea hacer otra conversion? precione s para continuar o n para salir");
                son = char.Parse(Console.ReadLine());






            } while (son != 'n');

            //PUNTO CUATRO, CONTADOR DE VOCALES   








            // PUNTO CINCO, CALCULADORA BASICA  

            double num1 = 0;
            double num2 = 0;
            char operac;
            char opcion;

            do
            {
                Console.WriteLine(" ingrese el primer numero ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ingrese el segundo numero");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" elija la operacion que desea realizar s ( suma) r ( resta) m (multiplic)  d ( division) ");
                operac = char.Parse(Console.ReadLine());

                if (operac == 's')
                {
                    Console.WriteLine(" la suma de los numeros es " + num1 + num2);
                }
                else if (operac == 'r')
                {
                    Console.WriteLine(" la resta de los numero es " + (num1 - num2));
                }
                else if (operac == 'm')
                {
                    Console.WriteLine(" la multiplicacion de los numero es " + (num1 * num2));
                }
                else if (operac == 'd')
                {
                    Console.WriteLine(" la division de los numero es " + (num1 / num2));
                }
                else
                    Console.WriteLine(" la opcion es invalida");

                Console.WriteLine(" desea hacer otra conversion? precione 1 para continuar o 2 para salir");
                opcion = char.Parse(Console.ReadLine());

            } while (opcion != '2');

            // PUNTO SEIS, NUMERO PAR O IMPAR

            int numero;

            do
            {
                Console.WriteLine("ingrese el numero que quiere verificar");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0) { Console.WriteLine(" el numero es par"); }
                else { Console.WriteLine(" el numero es impar"); }

            } while (numero != 0);

            Console.WriteLine(" fin del bucle");

            // PUNTO SIETE, VALIDAR EDAD

            int edad = 0;
            int mayor = 18;


            do
            {
                Console.Write("ingrese la edad o presione 0 para salir :  ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= mayor)
                {
                    Console.WriteLine(" es mayor de edad");
                }
                else if (edad <= 0)
                {

                }
                else
                {
                    Console.WriteLine(" usted es menor de edad");
                }



            } while (edad != 0);



            // PUNTO OCHO, DETERMINAR LONGITUD DE UNA CADENA

            string texto;
            int cont8 = 1;

            Console.WriteLine(" ingrese la oracion");
            texto = Console.ReadLine();
            do
            {
                cont8++;


            } while (cont8 < texto.Length);

            Console.WriteLine(" la cantidad de caracteres en la oracion es de : " + cont8);

            //PUNTO NUEVE, CALCULAR EL AREA DE UN CIRCULO

            double radio;
            double area;



            do
            {
                Console.Write(" para sabe el area, ingrese el radio o 0 para salir:  ");
                radio = Convert.ToDouble(Console.ReadLine());

                area = 3.14 * (radio * radio);
                Console.WriteLine(" el area del circulo es " + area);

            } while (radio != 0);
            if (radio == 0)
            {
                Console.WriteLine(" fin de la operacion");

            }

            // PUNTO DIEZ, CONVERTIR TEXTO A MAYUSCULAS ( lo hice con ayuda de internet no lo puedo compilar no encuentro el error)

            string text;
            string textoMay = "";
            int cont10 = 0;
            int op;

            Console.WriteLine(" ingrese el texto en minusculas");
            text = Console.ReadLine();

            do
            {
                textoMay += char.ToUpper(text[cont10]);
                cont10++;


                Console.WriteLine(" su texto en mayusculas es : " + textoMay );



                Console.WriteLine(" ingrese 1 para salir o 2 para continuar");
                op = Convert.ToInt32(Console.ReadLine());
            } while (cont10 < text.Length);



            //PUNTO ONCE, ENCONTRAR EL MAYOR DE TRES NUMEROS

            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            int opcion11;



            do
            {
                Console.WriteLine(" ingrese el primer numero ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ingrese el segundo numero ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ingrese el tercer numero ");
                num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine(" el numero mayor es " + num1);
                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine(" el numero mayor es " + num2);
                }
                else
                {
                    Console.WriteLine(" el numero mayor es " + num3);
                }

                Console.WriteLine(" si desea terminar la operaciones precione 0 ");
                opcion11 = int.Parse(Console.ReadLine());


            } while (opcion11 != 0);

            // PUNTO DOCE, CALCULAR EL PROMEDIO N DE NUMEROS

            int numeros = 0;
            int suma= 0;
            int cont12 = 0;
            int promedio11 = 0;
            int opcion12;

            do
            {
                Console.Write(" ingrese los numeros : ");
                numeros= Convert.ToInt32(Console.ReadLine());

                suma = suma + numeros;

                cont12++;



                Console.Write(" precione 0 para hacer la opeacion del promedio con los numeros que ingreso o 1 para seguir : ");
                opcion12 = Convert.ToInt32(Console.ReadLine());
            } while( opcion12 != 0 );

            
            promedio11 = suma / cont12++;

            Console.WriteLine($" la suma de los numeros es {suma} ");
            Console.WriteLine($" el promedio es  {promedio11}");


            // PUNTO TRECE, JUEGO DE ADIVINAR UN NUMERO

            Random random = new Random();
            int numSec = random.Next(1, 101);

            
            int intentos = 0;
            int numero = 0;
            int op13 ;

            do

            {


                do
                {
                    Console.Write(" ingrese un numero para saber el numero secreto : ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero < numSec)
                    {
                        Console.WriteLine(" el numero secreto es mayor ");
                    }
                    else if (numero > numSec)
                    {
                        Console.WriteLine(" el numero secreto es menor");
                    }
                    else
                    {
                        Console.WriteLine(" Felicidades adivinaste el numero secreto!!");
                    }


                } while (numero != numSec);

                Console.WriteLine(" si quiere volver a jugar precione 0");
                op13 = int.Parse(Console.ReadLine());

            } while (op13 == 0);


            //PUNTO CATORCE, VERIFICAR SI UN NUMERO ES PRIMO 

            // MUCHOS PROBLEMAS A LA HORA DE HACER QUE EL COGIDO VERIFIQUE SI EL NUMERO ES PRIMO, NO LO PUDE HACER FUNCIONAR.

            int numEnt= 0;
            bool numPrimo = true;
            int divissor = 2;

            

            do
            {
                Console.WriteLine(" ingrese un numero para saber si es primo");
                numEnt = Convert.ToInt32(Console.ReadLine());

                if (numEnt % divissor == 0 )

                {
                    numPrimo = false; break;
                   
                }
                else if (numPrimo)
                {
                    Console.WriteLine("El número " + numEnt + " es primo.");
                }
                else
                {
                    Console.WriteLine("El número " + numEnt + " no es primo.");
                }

            } while (true);

            // PUNTO QUINCE, REVERSAR UNA CADENA DE TEXTO

            // problemas para resolver el ejercicio.

            string textOrig;
            

            do
            {
                Console.WriteLine(" ingrese la cadena de texto o escribe salir para terminar");
                textOrig = Console.ReadLine();

                if ( textOrig.ToLower() == "salir")
                {
                    Console.WriteLine(" saliste del programa..."); break;
                }
               // string textInvert = inverttext(textOrig);

            }while (true);






















        }
    }
}

