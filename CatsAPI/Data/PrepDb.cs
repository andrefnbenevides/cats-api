using CatsAPI.Models;

namespace CatsAPI.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if(!context.Cats.Any())
            {
                Console.WriteLine("--> Seeding data for cats.");
                context.Cats.AddRange(
                    new Cat(){
                        Id = 1,
                        AverageHeight = 30,
                        AverageLength = 60,
                        AverageLifespan = 12.5M,
                        AverageWeight = 4,
                        PlaceOfOrigin = "Africa",
                        Species = "Persian",
                        GroomingTips = "You should groom the persian cat daily to avoid problems with tangled hair" 
                    }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have cat data.");
            }
        }
    }
}