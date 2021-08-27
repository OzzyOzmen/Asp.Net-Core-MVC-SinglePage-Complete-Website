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
    public class UsersService
    {
        UsersRepository usersRepository;

        public UsersService()
        {
            if (usersRepository==null)
            {
                usersRepository = new UsersRepository();
            }
        }

        public void AddUsersService(UsersDTO entity)
        {
            Users users = new Users
            {
                Name = entity.Name,
                Surname = entity.Surname,
                Phone = entity.Phone,
                Email = entity.Email,
                UserName = entity.UserName,
                Password = entity.Password
            };

            usersRepository.Add(users);
        }

        public void UpdateUsersService(UsersDTO entity)
        {
            var result = usersRepository.GetAll().Where(x => x.UserId == entity.UserId).FirstOrDefault();

            result.Name = entity.Name;
            result.Surname = entity.Surname;
            result.Phone = entity.Phone;
            result.Email = entity.Email;
            result.UserName = entity.UserName;
            result.Password = entity.Password;

            usersRepository.Update(result);
        }

        public void DeleteUsersService(UsersDTO entity)
        {
            var result = usersRepository.GetAll().Where(x => x.UserId == entity.UserId).FirstOrDefault();

            result.Name = entity.Name;
            result.Surname = entity.Surname;
            result.Phone = entity.Phone;
            result.Email = entity.Email;
            result.UserName = entity.UserName;
            result.Password = entity.Password;

            usersRepository.Delete(result);
        }
        public bool DeleteUsersServiceByID(int id)
        {
            return usersRepository.DeletebyEntity(x=>x.UserId==id);
        }

        public IEnumerable<UsersDTO> GetUsersService()
        {
            return usersRepository.GetAll().Select(x => new UsersDTO
            {
                UserId = x.UserId,
                Name = x.Name,
                Surname = x.Surname,
                Phone = x.Phone,
                Email = x.Email,
                UserName = x.UserName,
                Password = x.Password
            }).ToList();
        }
    }
}
