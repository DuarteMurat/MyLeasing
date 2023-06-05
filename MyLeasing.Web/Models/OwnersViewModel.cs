using Microsoft.AspNetCore.Http;
using MyLeasing.Web.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyLeasing.Web.Models
{
    public class OwnersViewModel : Owner
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
