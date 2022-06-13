using CatsAPI.Models;

namespace CatsAPI.Data
{
    public class CatRepo : ICatRepo
    {
        private readonly AppDbContext _context;

        public CatRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateCat(Cat cat)
        {
            if(cat == null)
            {
                throw new ArgumentNullException(nameof(Cat));
            }

            _context.Cats.Add(cat);
        }

        public IEnumerable<Cat> GetAllCats()
        {
            return _context.Cats.ToList();
        }

        public Cat? GetCatById(int id)
        {
            return _context.Cats.FirstOrDefault(s => s.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}