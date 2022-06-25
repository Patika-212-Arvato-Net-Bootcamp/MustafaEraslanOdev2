using MVCWebAPIWithoutDb.Entities;

namespace MVCWebAPIWithoutDb.Helper
{
    public interface IBootcampService
    {
        List<BootcampEntity> GetBootcampList();

        void AddBootCamp(BootcampEntity bootcamp);

        void DeleteBootCamp(BootcampEntity bootcamp);
    }
}
