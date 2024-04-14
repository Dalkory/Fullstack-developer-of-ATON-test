using System;

namespace Intern_Fullstack_developer_ATON_LLC_Domain.Entities
{
    public class Client : Entity
    {
        public int AccountNumber { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string TIN { get; private set; } // ИНН
        public int? ResponsiblePersonId { get; private set; }
        public User ResponsiblePerson { get; private set; }
        public string Status { get; set; } = "Не в работе";

        private Client() { }

        public static Client Create(int id, int accountNumber, string lastName, string firstName, string middleName, DateTime birthDate, string tin, int? responsiblePersonId)
        {
            return new Client
            {
                Id = id,
                AccountNumber = accountNumber,
                LastName = lastName,
                FirstName = firstName,
                MiddleName = middleName,
                BirthDate = birthDate,
                TIN = tin,
                ResponsiblePersonId = responsiblePersonId
            };
        }

        public void AssignResponsiblePerson(User responsiblePerson)
        {
            ResponsiblePerson = responsiblePerson;
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
        }
    }
}