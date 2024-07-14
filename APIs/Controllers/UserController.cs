using APIs.DTO;
using APIs.Model;
using APIs.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo userRepo;

        private IspRepo _spRepo;

        private JWToptions _JWToptions;
        private IConfiguration _configuration;
        public UserController(IUserRepo userRepo, IspRepo _spRepo, JWToptions jWToptions , IConfiguration _configuration)
        {
            this.userRepo = userRepo;
            this._spRepo = _spRepo;
            this._JWToptions = jWToptions;
            this._configuration = _configuration;
        }

        [HttpGet]
       // [Authorize(Roles = "user@example.com")]
        public async Task<IActionResult> getusers()
        {
            // var user = User.Identity.Name;
            // Console.WriteLine(user);

            //var username = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;

            //if (string.IsNullOrEmpty(username))
            //{
            //    return Unauthorized();
            //}
            var u = await userRepo.getuser();
            Console.WriteLine(u);
            return Ok(u);
        }


        [HttpPost]
        public IActionResult UserRegistration(RegistrationDTO userDto)
        {

            if (ModelState.IsValid == true)
            {
                userRepo.UserRegistration(userDto);

                return Ok(new { mas = "succ" });
            }
            else { return BadRequest(ModelState); }
        }

        [HttpPut("alla/{id:alpha}/{fName}")]

        public async Task<IActionResult> updateWithSP(int id, string fName)
        {

            try
            {
                await _spRepo.spAsync(id, fName);
            }
            catch (Exception e)
            {

            }
            return Ok();
        }




        [HttpPost("login")]

        public async Task<IActionResult> authen([FromBody] LoginDTO loginDto)
        {
            var exist = await userRepo.login(loginDto);

            if (exist == null)
            {
                return Unauthorized();
            }
            else

            {
                var handler = new JwtSecurityTokenHandler();



                var authClaims = new List<Claim>
                {
                  // new Claim(ClaimTypes.Name, exist.FirstName),
                    new Claim(ClaimTypes.Role ,"user@example.com"),
                   new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:signinkey"]));


                var token = new JwtSecurityToken(
                    
                    issuer: _configuration["JWT:issuer"],
                    audience: _configuration["JWT:audience"],
                     expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );




        
                var accessToken = handler.WriteToken(token);

                return Ok(accessToken);
            }











        }

    }

}