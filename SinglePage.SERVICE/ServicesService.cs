using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinglePage.DTO;
using SinglePage.ORM.Data;
using SinglePage.REPOSITORY;

namespace SinglePage.SERVICE
{
    public class ServicesService
    {
        ServicesRepository servicesRepository;

        public ServicesService()
        {
            if (servicesRepository==null)
            {
                servicesRepository = new ServicesRepository();
            }
        }

        public void AddServicesService(ServicesDTO entity)
        {
            Services services = new Services
            {
                ServicesPhoto = entity.ServicesPhoto,
                ServicesTitle = entity.ServicesTitle = entity.ServicesTitle,
                ServicesDescription = entity.ServicesDescription
            };

            servicesRepository.Add(services);
        }

        public void UpdateServicesService(ServicesDTO entity)
        {
            var result = servicesRepository.GetAll().Where(x => x.ServicesId == entity.ServicesId).FirstOrDefault();

            result.ServicesPhoto = entity.ServicesPhoto;
            result.ServicesTitle = entity.ServicesTitle;
            result.ServicesDescription = entity.ServicesDescription;

            servicesRepository.Update(result);
        }

        public void DeleteServicesService(ServicesDTO entity)
        {
            var result = servicesRepository.GetAll().Where(x => x.ServicesId == entity.ServicesId).FirstOrDefault();

            result.ServicesPhoto = entity.ServicesPhoto;
            result.ServicesTitle = entity.ServicesTitle;
            result.ServicesDescription = entity.ServicesDescription;

            servicesRepository.Delete(result);
        }
        public bool DeleteServicesServiceByID(int id)
        {
            return servicesRepository.DeletebyEntity(x => x.ServicesId == id);
        }

        public IEnumerable<ServicesDTO> GetServicesService()
        {
            return servicesRepository.GetAll().Select(x => new ServicesDTO
            {
                ServicesId = x.ServicesId,
                ServicesPhoto = x.ServicesPhoto,
                ServicesTitle = x.ServicesTitle,
                ServicesDescription = x.ServicesDescription
            }).ToList();
        }
    }
}
