﻿// See https://aka.ms/new-console-template for more information



//L’utente inserisce due numeri in successione. Il software stampa il maggiore.

//Console.WriteLine("Inserisci due numeri: ");
//double num1, num2;

//double.TryParse(Console.ReadLine(), out num1);

//double.TryParse(Console.ReadLine(), out num2);

//if (num1 > num2)
//    Console.WriteLine($"Il numero maggiore è {num1}");
//else if (num1 < num2)
//    Console.WriteLine($"Il numero maggiore è {num2}");
//else
//    Console.WriteLine("Hai inserito 2 numeri uguali");



//L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.

//Console.WriteLine("Scrivi due parole: ");

//string? str1 = Console.ReadLine(), str2 = Console.ReadLine();

//if (str1.Length > str2.Length)
//    Console.WriteLine($"{str2} {str1}");
//else if (str2.Length > str1.Length)
//    Console.WriteLine($"{str1} {str2}");
//else
//    Console.WriteLine("Hai inserito 2 parole di egual lunghezza");



//Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

//int sum = 0;

//Console.WriteLine("Inserisci 10 numeri");

//for (int i = 0; i<10; i++)
//{
//    sum += int.Parse(Console.ReadLine());
//}

//Console.WriteLine($"La somma dei numeri inseriti è {sum}");




//Calcola la somma e la media dei numeri da 2 a 10.

int sum = 0, count = 0;

for (int i = 2; i <= 10; i++)
{
    sum += i;
    count++;
}

Console.WriteLine($"La somma è {sum}, la media è {sum / count}");