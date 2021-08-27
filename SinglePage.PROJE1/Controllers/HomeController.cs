using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SinglePage.DTO;
using SinglePage.SERVICE;

namespace SinglePage.PROJE1.Controllers
{
    public class HomeController : Controller
    {
        AboutUsService aboutUsService;
        ContactsService contactsService;
        ReferencesService referencesService;
        ReviewsServices reviewsServices;
        ServicesService servicesService;
        TeamsService teamsService;
        UsersService usersService;
        WhatWeDoService whatWeDoService;

        public HomeController()
        {
            if (aboutUsService==null)
            {
                aboutUsService = new AboutUsService();
            }

            if (contactsService==null)
            {
                contactsService = new ContactsService();
            }

            if (referencesService==null)
            {
                referencesService = new ReferencesService();
            }

            if (reviewsServices==null)
            {
                reviewsServices = new ReviewsServices();
            }

            if (servicesService==null)
            {
                servicesService = new ServicesService();
            }

            if (teamsService==null)
            {
                teamsService = new TeamsService();
            }

            if (usersService==null)
            {
                usersService = new UsersService();
            }

            if (whatWeDoService==null)
            {
                whatWeDoService = new WhatWeDoService();
            }
        }

        [HttpGet]
        public IActionResult Index()
        {
            var aboutUsResult = aboutUsService.GetAboutUsService().ToList();
            var referencesResult = referencesService.GetReferencesService().ToList();
            var reviewsResult = reviewsServices.GetReviewsServices().ToList();
            var servicesResult = servicesService.GetServicesService().ToList();
            var teamsResult = teamsService.GetTeamsService().ToList();
            var usersResult = usersService.GetUsersService().ToList();
            var whatWeDoResult = whatWeDoService.GetWhatWeDoService().ToList();

            AllTableDTO allTableDTO = new AllTableDTO();
            allTableDTO.aboutUsDTOs = aboutUsResult;
            allTableDTO.referencesDTOs = referencesResult;
            allTableDTO.reviewsDTOs = reviewsResult;
            allTableDTO.servicesDTOs = servicesResult;
            allTableDTO.teamsDTOs = teamsResult;
            allTableDTO.usersDTOs = usersResult;
            allTableDTO.whatWeDoDTOs = whatWeDoResult;
            return View(allTableDTO);
        }

        [HttpPost]
        public IActionResult Index(ContactsDTO entity)
        {
            contactsService.AddContactsService(entity);
            return Index();
        }
    }
}
