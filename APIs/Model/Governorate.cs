

namespace APIs.Model
{
    public class Governorate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<City> cities { get; set; }
    }
}
