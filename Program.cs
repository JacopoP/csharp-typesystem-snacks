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

//int sum = 0, count = 0;

//for (int i = 2; i <= 10; i++)
//{
//    sum += i;
//    count++;
//}

//Console.WriteLine($"La somma è {sum}, la media è {sum / count}");



//Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

//int n;

//Console.WriteLine("inserisci un numero");

//n = Convert.ToInt32(Console.ReadLine());

//if (n % 2 == 0)
//    Console.WriteLine($"Hai inserito il numero {n}");
//else
//    Console.WriteLine($"Un numero pari vicino a quello inserito è {n + 1}");



//In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

//string[] list = { "Marco", "Giovanni", "Filippo" };
//bool invited = false;

//Console.WriteLine("Come ti chiami?");

//string name = Console.ReadLine();

//foreach (string person in list)
//    if(!invited)
//        invited = name == person;

//if (invited)
//    Console.WriteLine("Benvenuto"!);
//else
//    Console.WriteLine("Spicante, ma non sei invitato");



//Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

//int[] numbers = new int[6];

//Console.WriteLine("Inserisci 6 numeri");
//for (int i = 0; i < 6; i++)
//{
//    int n = Convert.ToInt32(Console.ReadLine());
//    if (n %2 != 0)
//        numbers[i] = n;
//}



//Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

//int[] numeri = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 56, 1,  95, 12, 33};
//int sum = 0;

//for (int i = 0; i < numeri.Length; i++)
//    if (i % 2 == 0)
//        sum += numeri[i];

//Console.WriteLine(sum);




//Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50. Random

//int[] numeri = new int[1000];
//int sum = 0, count=0;

//while (sum < 50)
//{
//    numeri[count] = Convert.ToInt32(Console.ReadLine());
//    sum += numeri[count];
//    count++;
//}

//Console.WriteLine("Grazie!");




//Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.

//Random rnd = new Random();

//Console.WriteLine("Inserisci un numero");

//int N = Convert.ToInt32(Console.ReadLine());

//int[][] arrays = new int[N][];

//for (int i = 0; i < N; i++)
//{
//    arrays[i] = new int[10];
//    for (int j = 0; j < 10; j++)
//        arrays[i][j] = rnd.Next(1, 100);

//    Console.WriteLine($"Array {i}:");
//    foreach (int x in arrays[i])
//        Console.Write(x + " ");
//    Console.WriteLine("");
//}




//Dare la possibilità di inserire due parole. Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.

//Console.WriteLine("Inserisci una parola");

//string word1 = Console.ReadLine();

//Console.WriteLine("Inseriscine un'altra");

//string word2 = Console.ReadLine();

//if (sameLength(word1, word2))
//    Console.WriteLine(word1 + " " + word2);
//else if (word1.Length > word2.Length) 
//    Console.WriteLine(word1);
//else
//    Console.WriteLine(word2);

//static bool sameLength(string word1, string word2)
//{
//    return word1.Length == word2.Length;
//}




//Scrivere una funzione per verificare se un numero è pari o dispari. Quindi chiedere un numero all'utente e comunicargli se è pari o dispari.

static bool isEven(int n)
{
    if (n % 2 == 0)
        return true; 
    return false;
}

Console.WriteLine("Inserisci un numero");

int num = Convert.ToInt32(Console.ReadLine());

if (isEven(num))
    Console.WriteLine("Hai inserito un numero pari");
else
    Console.WriteLine("Hai inserito un numero dispari");