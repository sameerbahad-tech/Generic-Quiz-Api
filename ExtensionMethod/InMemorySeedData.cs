using Quiz_Api.MockDataInMemory;
using Quiz_Api.Models;

namespace Quiz_Api.ExtensionMethod
{
    public static class InMemorySeedData
    {
        public static void SeedInMemoryDatabase(this IApplicationBuilder app, IConfiguration configuration) 
        {
            var databaseType = configuration["DatabaseType"];
            if (databaseType == "InMemory")
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<QuizDbContext>();
                    context.Participants.AddRange(ParticipantsList.GenerateMockParticipants());
                    context.Questions.AddRange(ReactInterviewQuestions.GenerateMockReactQuestions());
                    context.Questions.AddRange(CSharpInterviewQuestions.GenerateMockCSharpQuestions());
                    context.SaveChanges();
                }
            }
        }
    }
}
