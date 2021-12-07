using DataLayer.Contracts;

namespace DataLayer.Implementation
{
    public class DecryptionService : IDecrypte
    {
        private readonly ProjectDbContext _context;

        public DecryptionService(ProjectDbContext projectDbContext)
        {
            _context = projectDbContext;
        }
        public string add(string word)
        {
            var exists = _context.Decryptes.Any(x => x.Word == word);
            if (!exists)
                _context.Add(word);
            return word;
        }
    }
}
