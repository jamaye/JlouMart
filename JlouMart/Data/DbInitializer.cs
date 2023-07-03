using JlouMart.Models;
using System.Linq;

namespace JlouMart.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FeedbackContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Respondents.
            if (context.Respondents.Any())
            {
                return;   // DB has been seeded
            }

            var Respondents = new Respondent[]
            {
            //new Respondent{ID="NA",Name="North America", Email="syjanilou@yahoo.com", Message="Hello There!"},
            //new Respondent{ID="SA",Name="South America", Email="syjani@yahoo.com", Message="Hello!"}

            };
            foreach (Respondent s in Respondents)
            {
                context.Respondents.Add(s);
            }
            context.SaveChanges();
        }
    }
}
