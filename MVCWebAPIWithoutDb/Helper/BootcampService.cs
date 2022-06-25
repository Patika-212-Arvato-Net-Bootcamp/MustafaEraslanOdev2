using MVCWebAPIWithoutDb.Entities;
using MVCWebAPIWithoutDb.Helper;

namespace MVCWebAPIWithoutDb.Helper
{
    public class BootcampService : IBootcampService
    {
        List<BootcampEntity> bootcampEntities = new List<BootcampEntity> {
        new BootcampEntity { Description = "Arvato Bootcamp", Name = "arvato dotnet" },
        new BootcampEntity { Description = "Arvato Bootcamp_1", Name = "arvato dotnet_1" },
        new BootcampEntity { Description = "Arvato Bootcamp_2", Name = "arvato dotnet_2" }

        };
        public List<BootcampEntity> GetBootcampList()
        {
            return bootcampEntities;
        }
        public void AddBootCamp(BootcampEntity bootcamp)
        {
            bootcampEntities.Add(bootcamp);
        }
        public void DeleteBootCamp(BootcampEntity bootcamp)
        {
            bootcampEntities.Remove(bootcamp);
        }

    }
}