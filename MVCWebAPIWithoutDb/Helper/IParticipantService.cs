using MVCWebAPIWithoutDb.Entities;

namespace MVCWebAPIWithoutDb.Helper
{
    public interface IParticipantService
    {
        List<ParticipantEntity> GetParticipantList();

        void AddParticipant(ParticipantEntity entity);

        void DeleteParticipant(ParticipantEntity entity);
    }
}
