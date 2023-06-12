using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Models;

namespace MyLeasing.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public Owner ToOwner(OwnersViewModel model, string path, bool isNew)
        {
            return new Owner
            {
                Id = isNew ? 0 : model.Id,
                Document = model.Document,
                ImageUrl = path,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Fixed_PhoneNumber = model.Fixed_PhoneNumber,
                User = model.User,
            };
        }

        public OwnersViewModel ToOwnerViewModel(Owner owner)
        {
            return new OwnersViewModel
            {
                Document = owner.Document,
                Id = owner.Id,
                FirstName = owner.FirstName,
                LastName = owner.LastName,
                Fixed_PhoneNumber = owner.Fixed_PhoneNumber,
                PhoneNumber = owner.PhoneNumber,
                Address = owner.Address,
                ImageUrl = owner.ImageUrl,
                User = owner.User,
            };
        }

        public Lessee ToLessee(LesseesViewModel model, string path, bool isNew)
        {
            return new Lessee
            {
                Id = isNew ? 0 : model.Id,
                ImageURL = path,
                Address = model.Address,
                Cell_Phone = model.Cell_Phone,
                Document = model.Document,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Fixed_Phone = model.Fixed_Phone,
                User = model.User,
            };
        }

        public LesseesViewModel ToLesseeViewModel(Lessee lessee)
        {
            return new LesseesViewModel
            {
                Document = lessee.Document,
                Id = lessee.Id,
                FirstName = lessee.FirstName,
                LastName = lessee.LastName,
                Fixed_Phone = lessee.Fixed_Phone,
                Cell_Phone = lessee.Cell_Phone,
                Address = lessee.Address,
                ImageURL = lessee.ImageURL,
                User = lessee.User,
            };
        }
    }
}
