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
    public class ReferencesService
    {
        ReferencesRepository referencesRepository;

        public ReferencesService()
        {
            if (referencesRepository==null)
            {
                referencesRepository = new ReferencesRepository();
            }
        }

        public void AddReferencesService(ReferencesDTO entity)
        {
            References references = new References
            {
                ReferencePhoto = entity.ReferencePhoto,
                ReferenceTitle = entity.ReferenceTitle,
                ReferenceLink = entity.ReferenceLink,
                ReferenceCategory = entity.ReferenceCategory
            };

            referencesRepository.Add(references);
        }

        public void UpdateReferencesService(ReferencesDTO entity)
        {
            var result = referencesRepository.GetAll().Where(x => x.ReferenceId == entity.ReferenceId).FirstOrDefault();

            result.ReferencePhoto = entity.ReferencePhoto;
            result.ReferenceTitle = entity.ReferenceTitle;
            result.ReferenceLink = entity.ReferenceLink;
            result.ReferenceCategory = entity.ReferenceCategory;

            referencesRepository.Update(result);
        }

        public void DeleteReferencesService(ReferencesDTO entity)
        {
            var result = referencesRepository.GetAll().Where(x => x.ReferenceId == entity.ReferenceId).FirstOrDefault();

            result.ReferencePhoto = entity.ReferencePhoto;
            result.ReferenceTitle = entity.ReferenceTitle;
            result.ReferenceLink = entity.ReferenceLink;
            result.ReferenceCategory = entity.ReferenceCategory;

            referencesRepository.Delete(result);
        }
        public bool DeleteReferencesServiceByID(int id)
        {
            return referencesRepository.DeletebyEntity(x => x.ReferenceId == id);
        }

        public IEnumerable<ReferencesDTO> GetReferencesService()
        {
            return referencesRepository.GetAll().Select(x => new ReferencesDTO
            {
                ReferenceId = x.ReferenceId,
                ReferencePhoto = x.ReferencePhoto,
                ReferenceTitle = x.ReferenceTitle,
                ReferenceLink = x.ReferenceLink,
                ReferenceCategory = x.ReferenceCategory
            }).ToList();
        }
    }
}
