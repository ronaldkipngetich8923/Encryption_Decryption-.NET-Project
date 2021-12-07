using DataLayer.Contracts;

namespace Encrypte
{
    public class Operation
    {
        private readonly IEncrypte _encrypte;
        private readonly IDecrypte _decrypte;

        public Operation()
        {
        }

        public Operation(IEncrypte encrypte, IDecrypte decrypte)
        {
            _encrypte = encrypte;
            _decrypte = decrypte;
        }
        public string doOperaton(string option, string word)
        {
            var chars = new string[] { "PIX" };

            switch (option)
            {
                case "EN":
                    {
                        foreach (var item in chars)
                        {
                            word = word.Insert(0, item);
                        }
                        if (word.Length > 0)
                            _encrypte.add(word);

                        Console.WriteLine("Encrypted word is:" + word);
                        break;
                    }

                case "DE":
                    {
                        foreach (var item in chars)
                        {
                            word = word.Replace(item, string.Empty);
                        }
                        _decrypte.add(word);
                        Console.WriteLine("Decrypted word is: " + word);
                        break;
                    }
            }
            return word;
        }
    }
}
