using MVCWebAPIWithoutDb.Entities;

namespace MVCWebAPIWithoutDb.Helper
{
    public class ParticipantService : IParticipantService
    {
        List<ParticipantEntity> participantEntities = new List<ParticipantEntity> {
        new ParticipantEntity {Id= 1, Name = "Mustafa" ,Surname="eraslan",Phone="5073671226"},
        new ParticipantEntity {Id= 2,Name = "Ehlullah", Surname="karakurt",Phone="5554442323" },
        new ParticipantEntity {Id= 3,Name = "Hasan" ,Surname="callak",Phone="5556663434"}
        };


        public void AddParticipant(ParticipantEntity entity)
        {
            participantEntities.Add(entity);
        }

        public void DeleteParticipant(ParticipantEntity entity)
        {
            participantEntities.Remove(entity);
        }

        public List<ParticipantEntity> GetParticipantList()
        {
            return participantEntities;
        }
    }
}
