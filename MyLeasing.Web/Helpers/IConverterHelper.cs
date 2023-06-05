using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Models;

namespace MyLeasing.Web.Helpers
{
    public interface IConverterHelper
    {
        Owner ToOwner(OwnersViewModel model, string path, bool isNew);

        OwnersViewModel ToOwnerViewModel(Owner owner);
    }
}
