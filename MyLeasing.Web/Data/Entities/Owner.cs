using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner : IEntity
    {
        public int Id { get; set; }

        [Required]
        public string Document { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [MaxLength(9), Display(Name = "Cell Phone")]
        public string PhoneNumber { get; set; }

        [MaxLength(9), Display(Name = "Home Phone")]
        public string Fixed_PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Display(Name = "Name")]
        public string CompleteName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public User User { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(ImageUrl))
                {
                    return null;
                }

                return $"https://localhost:44327{ImageUrl.Substring(1)}";
            }
        }
    }
}
