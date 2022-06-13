using CatsAPI.Models;

namespace CatsAPI.Data
{
    public interface ICatRepo
    {
        bool SaveChanges();
        IEnumerable<Cat> GetAllCats();
        Cat? GetCatById(int id);
        void CreateCat(Cat cat);
    }
}