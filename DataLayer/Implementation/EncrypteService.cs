using DataLayer.Contracts;

namespace DataLayer.Implementation
{
    public class EncrypteService : IEncrypte
    {
        private readonly ProjectDbContext _context;

        public EncrypteService(ProjectDbContext context)
        {
            _context = context;
        }
        public string add(string word)
        {
            var exists = _context.Encryptes.Any(x => x.Word == word);
            if (exists)
                return word;
            else
                _context.Add(word);
            return word;
        }
    }
}
