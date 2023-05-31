using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        
        [Required]
        public string Document { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [MaxLength(9), Display(Name = "Cell Phone")]
        public string PhoneNumber { get; set; }
        
        [MaxLength(9), Display(Name = "Home Phone")]
        public string Fixed_PhoneNumber { get; set; }
        
        [Required]
        public string Address { get; set; }
    }
}
