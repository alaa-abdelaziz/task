using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIs.Model
{
    public class UserAddress
    {
        public int Id { get; set; }
        [Required]
        public string Governate { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [MaxLength(200)]
        public string Street { get; set; }

        [Required]
        public string BuildingNumber { get; set; }

        [Required]
        public int FlatNumber { get; set; }


        [ForeignKey("Users")]
        public int userID { get; set; }
        public virtual User Users { get; set; }
    }
}
