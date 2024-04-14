using Intern_Fullstack_developer_ATON_LLC_Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Intern_Fullstack_developer_ATON_LLC_Domain
{
    public class FullStackContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }

        public FullStackContext(DbContextOptions<FullStackContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedUsers(modelBuilder);
            SeedClients(modelBuilder);
        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {
            var users = new List<User>();
            for (int i = 1; i <= 20; i++)
            {
                users.Add(new User($"Пользователь {i}", $"user{i}", $"password{i}") { Id = i });
            }
            modelBuilder.Entity<User>().HasData(users);
        }

        private void SeedClients(ModelBuilder modelBuilder)
        {
            var clients = new List<Client>();
            var random = new Random();
            for (int i = 1; i <= 200; i++)
            {
                var responsiblePersonId = random.Next(1, 21);
                clients.Add(Client.Create(i, i, $"Фамилия {i}", $"Имя {i}", $"Отчество {i}", new DateTime(1980, 1, 1).AddMonths(i), $"123456789{i}", responsiblePersonId));
            }
            modelBuilder.Entity<Client>().HasData(clients);
        }
    }
}