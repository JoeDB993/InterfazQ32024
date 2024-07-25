

using System.ComponentModel.Design;

namespace InterfazQ32024
{
    public class Operacion : IOperaciones, IArea 
    {
        public double N1;
        public double N2;

        public double Division()
        {
            return N1/N2;
        }

        public double Multiplicacion()
        {
            return N1*N2;
        }

        public double Resta()
        {
            return N1-N2;
        }

        public double Suma()
        {
            return N1 + N2;
        }
       

        public double Cuadrado()
        {
            return N1 * N2;
        }

        public double Triangulo()
        {
            return (N1 + N2)/2;
        }

        public void Imprimir()
        {
            Console.WriteLine($"La suma es: {Suma()}");
            Console.WriteLine($"La resta es: {Resta()}");
            Console.WriteLine($"La multiplicación es: {Multiplicacion()}");
            Console.WriteLine($"La división es: {Division()}");
            if (N1 == N2)
            {
                Console.WriteLine($"El área del cuadrado es: {Cuadrado()}");
            }
            else
            {
                Console.WriteLine($"El área del rectángulo es: {Cuadrado()}");
            }
            Console.WriteLine($"El área del triángulo es: {Triangulo()}");

        }
    }
 }

