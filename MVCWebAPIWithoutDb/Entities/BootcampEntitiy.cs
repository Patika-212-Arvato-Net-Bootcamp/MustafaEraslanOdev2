namespace MVCWebAPIWithoutDb.Entities
{
    public class BootcampEntity
    {
        public BootcampEntity()
        {

        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }


    }
}
