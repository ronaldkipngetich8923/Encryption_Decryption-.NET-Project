// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello!");
Console.WriteLine("-------------------------------");

var chars = new string[] { "PIX" };

// Ask the user to choose an operator.
Console.WriteLine("Choose your Option from the following list:");

Console.WriteLine("\tEN - Encryption");
Console.WriteLine("\tDE - Decryption");
Console.Write("Your option? ");
string option = Console.ReadLine();

Console.WriteLine("Enter the word you wish to decrypte");
string word = Console.ReadLine();


if (option == "EN")
{
    foreach (var item in chars)
    {
        word = word.Insert(0, item);
    }
    Console.WriteLine("Encrypted word is:" + word);
}
else if (option == "DE")
{
    foreach (var item in chars)
    {
        word = word.Replace(item, string.Empty);
    }
    Console.WriteLine("Decrypted word is: " + word);
}