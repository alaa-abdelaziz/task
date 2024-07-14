using APIs.Model;

namespace APIs.DTO
{
    public class GovernorateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CityDto> cities { get; set; }
    }
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GovernorateId { get; set; }      
    }
    }
