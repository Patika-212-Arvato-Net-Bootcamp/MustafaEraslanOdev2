using MVCWebAPIWithoutDb.Entities;
using MVCWebAPIWithoutDb.Helper;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MVCWebAPIWithoutDb.Helper
{
    public class BootcampService : IBootcampService
    {
        List<BootcampEntity> bootcampEntities = new List<BootcampEntity> {
        new BootcampEntity {Id= 1, Description = "Arvato Bootcamp", Name = "arvato dotnet" },
        new BootcampEntity {Id= 2, Description = "Arvato Bootcamp_1", Name = "arvato dotnet_1" },
        new BootcampEntity {Id= 3, Description = "Arvato Bootcamp_2", Name = "arvato dotnet_2" }
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
        //public void UpdateBootCamp(BootcampEntity bootcamp)
        //{
        //    var bootCamp = bootcampEntities.FirstOrDefault(x => x.Id == bootcamp.Id);

        //    bootCamp.Name = bootcamp.Name;
        //    bootCamp.Description = bootcamp.Description;

        //    bootcampEntities.Update()
            
        //}
    }
}