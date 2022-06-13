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
            if(!context.Conditions.Any())
            {
                Console.WriteLine("--> Seeding data for conditions.");
                context.Conditions.AddRange(
                    new Condition(){
                        Id = 1,
                        Name = "Dermatological ",
                        Description = "primary seborrhoea, idiopathic periocular crusting, dermatophytosis (ringworm), Facial fold pyoderma, idiopathic facial dermatitis (a.k.a. dirty face syndrome), multiple epitrichial cysts (eyelids)"
                    }
                );
            }
            else
            {
                Console.WriteLine("--> We already have conditions data.");
            }

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
                        Conditions = context.Conditions,
                        PlaceOfOrigin = "Africa",
                        Species = "Persian",
                        GroomingTips = "You should groom the persian cat daily to avoid problems with tangled hair" 
                    }
                );
            }
            else
            {
                Console.WriteLine("--> We already have cat data.");
            }
        }
    }
}