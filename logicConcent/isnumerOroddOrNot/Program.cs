var numberString = string.Empty;
do
{
    Console.WriteLine("ingrese numero o 's' para salir: ");
    numberString = Console.ReadLine();
    if (numberString == "S")
    {
        continue;
    }

    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El numero {numberInt}, es par.");
        }
        else
        {
            Console.WriteLine($"El numero {numberInt}, es impar.");
        }

    }
    else
    {
        Console.WriteLine($"lo que ingresastee {numberString}, no es un numero entero.");
    }
} while (numberString != "s");








