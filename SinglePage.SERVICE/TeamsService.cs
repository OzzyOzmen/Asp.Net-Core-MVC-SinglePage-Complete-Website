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
    public class TeamsService
    {
        TeamsRepository teamsRepository;

        public TeamsService()
        {
            if (teamsRepository==null)
            {
                teamsRepository = new TeamsRepository();
            }
        }

        public void AddTeamsService(TeamsDTO entity)
        {
            Teams teams = new Teams
            {
                TeamPhoto = entity.TeamPhoto,
                TeamTitle = entity.TeamTitle,
                TeamMemberName = entity.TeamMemberName,
                TeamMemberSurName = entity.TeamMemberSurName,
                AboutTeamMember = entity.AboutTeamMember,
                TeamFacebookLink = entity.TeamFacebookLink,
                TeamTwitterLink = entity.TeamTwitterLink,
                TeamLinkedInLink = entity.TeamLinkedInLink
            };

            teamsRepository.Add(teams);
        }

        public void UpdateTeamsService(TeamsDTO entity)
        {
            var result = teamsRepository.GetAll().Where(x => x.TeamId == entity.TeamId).FirstOrDefault();

            result.TeamPhoto = entity.TeamPhoto;
            result.TeamTitle = entity.TeamTitle;
            result.TeamMemberName = entity.TeamMemberName;
            result.TeamMemberSurName = entity.TeamMemberSurName;
            result.AboutTeamMember = entity.AboutTeamMember;
            result.TeamFacebookLink = entity.TeamFacebookLink;
            result.TeamTwitterLink = entity.TeamTwitterLink;
            result.TeamLinkedInLink = entity.TeamLinkedInLink;

            teamsRepository.Update(result);
        }

        public void DeleteTeamsService(TeamsDTO entity)
        {
            var result = teamsRepository.GetAll().Where(x => x.TeamId == entity.TeamId).FirstOrDefault();

            result.TeamPhoto = entity.TeamPhoto;
            result.TeamTitle = entity.TeamTitle;
            result.TeamMemberName = entity.TeamMemberName;
            result.TeamMemberSurName = entity.TeamMemberSurName;
            result.AboutTeamMember = entity.AboutTeamMember;
            result.TeamFacebookLink = entity.TeamFacebookLink;
            result.TeamTwitterLink = entity.TeamTwitterLink;
            result.TeamLinkedInLink = entity.TeamLinkedInLink;

            teamsRepository.Delete(result);
        }
        public bool DeleteTeamsServiceByID(int id)
        {
            return teamsRepository.DeletebyEntity(x => x.TeamId == id);
        }

        public IEnumerable<TeamsDTO> GetTeamsService()
        {
            return teamsRepository.GetAll().Select(x => new TeamsDTO
            {
                TeamId = x.TeamId,
                TeamPhoto = x.TeamPhoto,
                TeamTitle = x.TeamTitle,
                TeamMemberName = x.TeamMemberName,
                TeamMemberSurName = x.TeamMemberSurName,
                AboutTeamMember = x.AboutTeamMember,
                TeamFacebookLink = x.TeamFacebookLink,
                TeamTwitterLink = x.TeamTwitterLink,
                TeamLinkedInLink = x.TeamLinkedInLink
            }).ToList();
        }
    }
}
