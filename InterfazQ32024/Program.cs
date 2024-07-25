
using InterfazQ32024;

Operacion operacion = new Operacion();
Console.WriteLine("Ingrese el primer número: ");
bool validN1 = double.TryParse(Console.ReadLine(), out operacion.N1); 


Console.WriteLine("Ingrese el segundo número: ");
bool validN2 = double.TryParse(Console.ReadLine(), out operacion.N2);

if (validN1 && validN2)
{
    if ( operacion.N2 != 0)
    {
        operacion.Imprimir();
    }
    else
    {
        Console.WriteLine("El segundo número no puede ser 0."); 
    }
}

else
{
    Console.WriteLine("Uno de los valores, o los valores ingresados no tiene el formato correcto");
}
