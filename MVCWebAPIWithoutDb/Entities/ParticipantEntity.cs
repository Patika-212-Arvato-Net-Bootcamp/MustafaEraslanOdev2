namespace MVCWebAPIWithoutDb.Entities
{
    public class ParticipantEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public string Surname { get; set; }

        public int Phone { get; set; }

    }
}
