using System.ComponentModel.DataAnnotations.Schema;

namespace APIs.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Governorate")]
        public int GovernorateId { get; set; }
        public Governorate Governorate { get; set; }
    }
}
