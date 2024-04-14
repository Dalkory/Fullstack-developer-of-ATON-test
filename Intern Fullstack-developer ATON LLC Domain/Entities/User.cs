namespace Intern_Fullstack_developer_ATON_LLC_Domain.Entities
{
    public class User : Entity
    {
        public string FullName { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        public User(string fullName, string login, string password)
        {
            FullName = fullName;
            Login = login;
            Password = password;
        }
    }
}