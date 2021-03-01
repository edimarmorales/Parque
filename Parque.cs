using System;

namespace parque
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PARQUE DE DIVERSIONES JUNGLA!!");
            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Ingrese Nombre y Apellido");
            Console.ReadLine();

            Console.WriteLine("-----------------------------------------------------------");
            int edad;
            double estatura=0.0;
           

            Console.WriteLine("Ingrese Edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------");

            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad, no puede ingresar al parque");
            }
            else
            {
                Console.WriteLine("ingrese su estatura");
                estatura = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------------------------------------");
            if (estatura < 1.5)
            {
                Console.WriteLine("Su estatura no es la indicada para ingresar al parque pero puede ir a la montaña, el martillo, y los carritos chocones");
            }
            else
            {
                Console.WriteLine("Puede ir a la montaña, el martillo, y los carritos chocones y el gusanito");

            }


            Console.ReadKey();
        }
    }
}
