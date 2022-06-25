namespace MVCWebAPIWithoutDb.Entities
{
    public class BootcampEntity
    {
        public BootcampEntity()
        {

        }
        public Guid Id { get; set; } = Guid.NewGuid(); // bootcamp unique bir değer generate ettim ve parametreleirmi tanımladım.
        public string Name { get; set; }
        public string Description { get; set; }


    }
}
