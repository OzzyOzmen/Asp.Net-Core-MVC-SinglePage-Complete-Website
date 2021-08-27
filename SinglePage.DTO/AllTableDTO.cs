using System.Collections.Generic;

namespace SinglePage.DTO
{
    public class AllTableDTO
    {
        public IEnumerable<AboutUsDTO> aboutUsDTOs { get; set; }
        public IEnumerable<ReferencesDTO> referencesDTOs { get; set; }
        public IEnumerable<ReviewsDTO> reviewsDTOs { get; set; }
        public IEnumerable<ServicesDTO> servicesDTOs { get; set; }
        public IEnumerable<TeamsDTO> teamsDTOs { get; set; }
        public IEnumerable<UsersDTO> usersDTOs { get; set; }
        public IEnumerable<WhatWeDoDTO> whatWeDoDTOs { get; set; }
    }
}
