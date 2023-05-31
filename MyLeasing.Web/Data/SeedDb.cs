using System.Threading.Tasks;
using System;
using System.Linq;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        private Random _random;

        public SeedDb(DataContext context)
        {
            _context = context;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            if (!_context.owners.Any())
            {
                AddOwner("Afonso", "Exemplo1");
                AddOwner("Miguel", "Exemplo2");
                AddOwner("Ricardo", "Exemplo3");
                AddOwner("Jose", "Exemplo4");
                AddOwner("Diogo", "Exemplo5");
                AddOwner("Rafael", "Exemplo6");
                AddOwner("Bruno", "Exemplo7");
                AddOwner("Duarte", "Exemplo8");
                AddOwner("Carlos", "Exemplo9");
                AddOwner("Joel", "Exemplo10");
                await _context.SaveChangesAsync();
            }
        }

        private void AddOwner(string firstname, string lastname)
        {
            _context.owners.Add(new Owner
            {
                Document = "12345678",
                FirstName = firstname,
                LastName = lastname,
                Fixed_PhoneNumber ="123456789",
                PhoneNumber = "987654321",
                Address = "Sintra",
            });
        }
    }
}
