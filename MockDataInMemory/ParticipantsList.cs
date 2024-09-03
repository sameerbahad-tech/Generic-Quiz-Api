using Quiz_Api.Models;

namespace Quiz_Api.MockDataInMemory
{
    public static class ParticipantsList
    {
        public static List<Participant> GenerateMockParticipants()
        {
            return new List<Participant>
            {
                new Participant { ParticipantId = 1, Name = "John Doe", Email = "john@example.com", Score = 100, TimeTaken = 50 },
                new Participant { ParticipantId = 2, Name = "Kate Sena", Email = "jane@example.com", Score = 90, TimeTaken = 60 }
            };
        }
    }
}
