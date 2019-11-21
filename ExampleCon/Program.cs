using System;
using System.Data;
using System.Data.SqlClient;

namespace ExampleCon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Enter Encrypted Word:");

            string userName = Console.ReadLine();
            DataLayer dataLayer = new DataLayer();
            dataLayer.insertData(userName);
        

            var str = userName;
            var charsToRemove = new string[] { "PIX" };
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);

                Console.WriteLine("This is the Decrypted Word:   " + str);
                Console.WriteLine("-------------------------------");
            }
            dataLayer.insertData_(str);
            Console.WriteLine("This is the Decrypted Word=====:   " + str);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Encrypted Word is: " + userName);
        }

     
}   
}
