using APIs.DTO;
using APIs.Model;
using Microsoft.EntityFrameworkCore;


namespace APIs.Repository
{
    
    public class UserRepository : IUserRepo
    {

        UserContext c;
        public UserRepository(UserContext c) {

            this.c = c;
        }

        public async Task< List<User>> getuser()
        {
            return await c.Users.ToListAsync();
        }

        public void UserRegistration(RegistrationDTO userDto)
        {
            User user = new User()
            {
                FirstName = userDto.FirstName,
                MiddleName = userDto.MiddleName,
                LastName = userDto.LastName,
                password= userDto.password,
                BirthDate = userDto.BirthDate,
                MobileNumber = userDto.MobileNumber,
                Email = userDto.Email,
                Addresses = new List<UserAddress>()
            };

            foreach (var addressDto in userDto.address)
            {
                var address = new UserAddress
                {
                    Governate = addressDto.Governate,
                    City = addressDto.City,
                    Street = addressDto.Street,
                    BuildingNumber = addressDto.BuildingNumber,
                    FlatNumber = addressDto.FlatNumber
                };
                user.Addresses.Add(address);
            }


            c.Users.Add(user);
            c.SaveChanges();



            // مش شغال 

            //var userCount = c.UserCounts.FirstOrDefault();
            //if (userCount != null)
            //{
            //    userCount.Count++;
            //    c.UserCounts.Update(userCount);
            //    c.SaveChanges();
            //}


        }


        public async Task<User> login (LoginDTO loginDto)
        {
            
         return  await c.Users.FirstOrDefaultAsync(e =>  e.Email == loginDto.Email && e.password ==loginDto.password);
            //if (c != null)
            //{
            //    return " true";
            //}
            //else
            //{
            //    return "false";
            //}
        }
    }
}
