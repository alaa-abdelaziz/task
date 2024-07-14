using APIs.Model;
using Microsoft.EntityFrameworkCore;
using APIs.Model;
using APIs.DTO;
namespace APIs.Repository
{
    public class GovernateAndCityRepo : IGovernateAndCityRepo
    {
        UserContext Context;
        public GovernateAndCityRepo(UserContext Context)
        {
              this.Context = Context;         

}

        public List<GovernorateDto> getdata()
        {
            return Context.Governorate
                  .Select(g => new GovernorateDto
                  {
                      Id = g.Id,
                      Name = g.Name,
                      cities = g.cities.Select(c => new CityDto
                      {
                          Id = c.Id,
                          Name = c.Name,
                          GovernorateId = c.GovernorateId
                      }).ToList()
                  }).ToList();

        }
    }
}
