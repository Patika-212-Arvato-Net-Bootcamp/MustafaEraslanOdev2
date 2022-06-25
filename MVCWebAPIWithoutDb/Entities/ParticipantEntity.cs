namespace MVCWebAPIWithoutDb.Entities
{
    public class ParticipantEntity
    {
        public Guid Id { get; set; } //participant için id ve parametlerimi tanımladım.
        public string Name { get; set; }
        
        public string Surname { get; set; }

        public int Phone { get; set; }

    }
}
