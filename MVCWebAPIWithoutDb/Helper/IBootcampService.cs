using MVCWebAPIWithoutDb.Entities;

namespace MVCWebAPIWithoutDb.Helper
{
    public interface IBootcampService
    {
        List<BootcampEntity> GetBootcampList();
    }
}
