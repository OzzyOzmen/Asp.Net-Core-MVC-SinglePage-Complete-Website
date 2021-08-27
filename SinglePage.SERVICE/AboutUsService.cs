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
    public class AboutUsService
    {
        AboutUsRepository aboutUsRepository;

        public AboutUsService()
        {
            if (aboutUsRepository==null)
            {
                aboutUsRepository = new AboutUsRepository();
            }
        }

        public void AddAboutUsService(AboutUsDTO entity)
        {
            AboutUs aboutUs = new AboutUs
            {
                AboutUsPhoto = entity.AboutUsPhoto,
                AboutUsTitle = entity.AboutUsTitle,
                AboutUsDescription = entity.AboutUsDescription
            };

            aboutUsRepository.Add(aboutUs);
        }

        public void UpdateAboutUsService(AboutUsDTO entity)
        {
            var result = aboutUsRepository.GetAll().Where(x => x.AboutUsId == entity.AboutUsId).FirstOrDefault();

            result.AboutUsPhoto = entity.AboutUsPhoto;
            result.AboutUsTitle = entity.AboutUsTitle;
            result.AboutUsDescription = entity.AboutUsDescription;

            aboutUsRepository.Update(result);
        }

        public void DeleteAboutUsService(AboutUsDTO entity)
        {
            var result = aboutUsRepository.GetAll().Where(x => x.AboutUsId == entity.AboutUsId).FirstOrDefault();

            result.AboutUsPhoto = entity.AboutUsPhoto;
            result.AboutUsTitle = entity.AboutUsTitle;
            result.AboutUsDescription = entity.AboutUsDescription;

            aboutUsRepository.Delete(result);
        }
        public bool DeleteAboutUsServiceByID(int id)
        {
            return aboutUsRepository.DeletebyEntity(x => x.AboutUsId == id);
        }

        public IEnumerable<AboutUsDTO> GetAboutUsService()
        {
            return aboutUsRepository.GetAll().Select(x => new AboutUsDTO
            {
                AboutUsId = x.AboutUsId,
                AboutUsPhoto = x.AboutUsPhoto,
                AboutUsTitle = x.AboutUsTitle,
                AboutUsDescription = x.AboutUsDescription
            }).ToList();
        }
    }
}
