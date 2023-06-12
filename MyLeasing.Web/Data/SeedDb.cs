using System.Threading.Tasks;
using System;
using System.Linq;
using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Helpers;
using Microsoft.AspNetCore.Identity;

namespace MyLeasing.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        private readonly IUserHelper _userHelper;

        private Random _random;


        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await _userHelper.GetUSerByEmailAsync("duartemurat@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Duarte",
                    LastName = "Marques",
                    Email = "duartemurat@gmail.com",
                    UserName = "duartemurat@gmail.com",
                    PhoneNumber = "214524731",
                    Document = "87654321",
                };

                var result = await _userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if (!_context.owners.Any())
            {
                AddOwner("Joel", "Exemplo" ,user);
                AddOwner("Afonso", "Exemplo", user);
                AddOwner("Miguel", "Exemplo", user);
                AddOwner("Ricardo", "Exemplo", user);
                AddOwner("Jose", "Exemplo", user);
                AddOwner("Diogo", "Exemplo", user);
                AddOwner("Rafael", "Exemplo", user);
                AddOwner("Bruno", "Exemplo", user);
                AddOwner("Duarte", "Exemplo", user);
                AddOwner("Carlos", "Exemplo", user);
                await _context.SaveChangesAsync();
            }

            if (!_context.lessee.Any())
            {
                AddLessee("Anabela", "Exemplo", user);
                AddLessee("Ana", "Exemplo", user);
                AddLessee("Mariana", "Exemplo", user);
                AddLessee("Joana", "Exemplo", user);
                AddLessee("Susana", "Exemplo", user);

                await _context.SaveChangesAsync();
            }
        }

        private void AddOwner(string firstname, string lastname, User user)
        {
            _context.owners.Add(new Owner
            {
                Document = "12345678",
                FirstName = firstname,
                LastName = lastname,
                Fixed_PhoneNumber ="123456789",
                PhoneNumber = "987654321",
                Address = "Sintra",
                User = user,
            });
        }

        private void AddLessee(string firstname, string lastname, User user)
        {
            _context.lessee.Add(new Lessee
            {
                Document = "12345678",
                FirstName = firstname,
                LastName = lastname,
                Fixed_Phone = "123456789",
                Cell_Phone = "987654321",
                Address = "Sintra",
                User = user,
            });
        }
    }
}
