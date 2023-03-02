using System;

class Parcial
{
    static void Main()
    {
        try
        {
            //Variables

            int numero,i=2;
            long factorial = 1;

            //Pedir al usuario ingresar un número

            Console.WriteLine("> Ingresa un número entero positivo mayor que 0: ");
            numero = int.Parse(Console.ReadLine());

            //Ciclo  while cuando el número ingresado es menor a 0

            while (numero < 1)
            {
                Console.WriteLine("> Error: el número debe ser mayor a 0: " );
                numero = int.Parse(Console.ReadLine());
            }

            //Calcular factorial del número ingresado

            do
            {
                factorial *= i;
                i++;
            } 
            while (i <= numero);

            //Imprimir en la pantalla todos los números enteros positivos menores o iguales a N divisibles entre 3

            Console.Write("> Numeros menores o iguales a {0} que son divisibles entre 3:\n", numero);

            for (int j = 1; j <= numero; j++)
            {
                if (j % 3 == 0)
                {
                Console.Write(j+ "\n");
                }
            }

            //Imprimir en la pantalla todos los números enteros positivos menores o iguales a N divisibles entre 5

            Console.Write("> Numeros menores o iguales a {0} que son divisibles entre 5:\n", numero);

            for (int k = 1; k <= numero; k++)
            {
                if (k % 5 == 0)
                {
                    Console.Write(k + "\n");
                }
            }

            //Imprimir una secuencia de numeros que comienze en 1 y se incremente en 2 hasta que sea mayor al numero ingresado

            Console.Write("> Secuencia de números hasta que sea mayor a {0}:\n", numero);

            for (int l = 1; l < numero+2;l+=2)
            {
                Console.Write(l + "\n");
            }

            //Imprimir el factorial del número

            Console.Write("> Factorial de {0} = {1}",numero,factorial);

            //Fin del programa
        } 
        catch
        {
            Console.WriteLine("> Error: ingrese datos válidos.");
        }
    }
    
}

