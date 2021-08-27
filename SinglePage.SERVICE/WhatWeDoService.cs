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
    public class WhatWeDoService
    {
        WhatWeDoRepository whatWeDoRepository;

        public WhatWeDoService()
        {
            if (whatWeDoRepository==null)
            {
                whatWeDoRepository = new WhatWeDoRepository();
            }
        }

        public void AddWhatWeDoService(WhatWeDoDTO entity)
        {
            WhatWeDo whatWeDo = new WhatWeDo
            {
                WhatWeDoTitle = entity.WhatWeDoTitle,
                WhatWeDoDescription = entity.WhatWeDoDescription,
                WhatWeDoLink = entity.WhatWeDoLink
            };

            whatWeDoRepository.Add(whatWeDo);
        }

        public void UpdateWhatWeDoService(WhatWeDoDTO entity)
        {
            var result = whatWeDoRepository.GetAll().Where(x => x.WhatWeDoId == entity.WhatWeDoId).FirstOrDefault();

            result.WhatWeDoTitle = entity.WhatWeDoTitle;
            result.WhatWeDoDescription = entity.WhatWeDoDescription;
            result.WhatWeDoLink = entity.WhatWeDoLink;

            whatWeDoRepository.Update(result);
        }

        public void DeleteWhatWeDoService(WhatWeDoDTO entity)
        {
            var result = whatWeDoRepository.GetAll().Where(x => x.WhatWeDoId == entity.WhatWeDoId).FirstOrDefault();

            result.WhatWeDoTitle = entity.WhatWeDoTitle;
            result.WhatWeDoDescription = entity.WhatWeDoDescription;
            result.WhatWeDoLink = entity.WhatWeDoLink;

            whatWeDoRepository.Delete(result);
        }
        public bool DeleteWhatWeDoServiceByID(int id)
        {
            return whatWeDoRepository.DeletebyEntity(x => x.WhatWeDoId == id);
        }

        public IEnumerable<WhatWeDoDTO> GetWhatWeDoService()
        {
            return whatWeDoRepository.GetAll().Select(x => new WhatWeDoDTO
            {
                WhatWeDoId = x.WhatWeDoId,
                WhatWeDoTitle = x.WhatWeDoTitle,
                WhatWeDoDescription = x.WhatWeDoDescription,
                WhatWeDoLink = x.WhatWeDoLink
            }).ToList();
        }
    }
}
