// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.WriteLine("Inserisci due numeri: ");
double num1, num2;

double.TryParse(Console.ReadLine(), out num1);

double.TryParse(Console.ReadLine(), out num2);

if (num1 > num2)
    Console.WriteLine($"Il numero maggiore è {num1}");
else if (num1 < num2)
    Console.WriteLine($"Il numero maggiore è {num2}");
else
    Console.WriteLine("Hai inserito 2 numeri uguali");