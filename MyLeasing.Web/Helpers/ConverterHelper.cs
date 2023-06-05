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
    }
}
