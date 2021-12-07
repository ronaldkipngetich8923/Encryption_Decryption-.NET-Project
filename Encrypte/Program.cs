// See https://aka.ms/new-console-template for more information

using Encrypte;

Console.WriteLine("Hello!");
Console.WriteLine("-------------------------------");

// Ask the user to choose an operator.
Console.WriteLine("Choose your Option from the following list:");

Console.WriteLine("\tEN - Encryption");
Console.WriteLine("\tDE - Decryption");
Console.Write("Your option? ");
string option = Console.ReadLine();

Console.WriteLine("Enter the word you wish to decrypte");
string word = Console.ReadLine();

var op = new Operation();
op.doOperaton(option, word);

