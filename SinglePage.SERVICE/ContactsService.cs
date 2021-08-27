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
    public class ContactsService
    {
        ContactsRepository contactsRepository;

        public ContactsService()
        {
            if (contactsRepository==null)
            {
                contactsRepository = new ContactsRepository();
            }
        }

        public void AddContactsService(ContactsDTO entity)
        {
            Contacts contacts = new Contacts
            {
                ContactName = entity.ContactName,
                ContactSurName = entity.ContactSurName,
                ContactPhone = entity.ContactPhone,
                ContactEmail = entity.ContactEmail,
                ContactMessage = entity.ContactMessage
            };

            contactsRepository.Add(contacts);
        }

        public void UpdateContactsService(ContactsDTO entity)
        {
            var result = contactsRepository.GetAll().Where(x => x.ContactId == entity.ContactId).FirstOrDefault();

            result.ContactName = entity.ContactName;
            result.ContactSurName = entity.ContactSurName;
            result.ContactPhone = entity.ContactPhone;
            result.ContactEmail = entity.ContactEmail;
            result.ContactMessage = entity.ContactMessage;

            contactsRepository.Update(result);
        }

        public void DeleteContactsService(ContactsDTO entity)
        {
            var result = contactsRepository.GetAll().Where(x => x.ContactId == entity.ContactId).FirstOrDefault();

            result.ContactName = entity.ContactName;
            result.ContactSurName = entity.ContactSurName;
            result.ContactPhone = entity.ContactPhone;
            result.ContactEmail = entity.ContactEmail;
            result.ContactMessage = entity.ContactMessage;

            contactsRepository.Delete(result);
        }
        public bool DeleteContactsServiceByID(int id)
        {
            return contactsRepository.DeletebyEntity(x=>x.ContactId==id);
        }

        public IEnumerable<ContactsDTO> GetContactsService()
        {
            return contactsRepository.GetAll().Select(x => new ContactsDTO
            {
                ContactId = x.ContactId,
                ContactName = x.ContactName,
                ContactSurName = x.ContactSurName,
                ContactPhone = x.ContactPhone,
                ContactEmail = x.ContactEmail,
                ContactMessage = x.ContactMessage
            }).ToList();
        }
    }
}
