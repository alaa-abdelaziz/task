using APIs.DTO;
using APIs.Model;

namespace APIs.Repository
{
    public interface IUserRepo
    {
       
         Task< List<User>> getuser();
        void UserRegistration(RegistrationDTO registrationDTO);
          Task<User> login(LoginDTO loginDto);
    }
}
