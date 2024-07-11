using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models.Core.DTO;
using Models.Core.Models;

namespace Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController(UserManager<AppUser> userManager) : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager = userManager;

        [HttpPost("/Register")]
        public async Task<IActionResult> PostUser(UserDTO userDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // mapping 
                    AppUser userModel = new()
                    {
                        FirstName = userDTO.FirstName,
                        LastName = userDTO.LastName,
                        Address = userDTO.Address,
                        PasswordHash = userDTO.Password,
                        UserName = userDTO.UserName,
                        Email = userDTO.Email
                    };
                    IdentityResult result = await _userManager.CreateAsync(userModel);
                    if (result.Succeeded)
                    {
                        return Ok(userModel);
                    }
                    else return BadRequest(result.Errors);
                }
            }
            catch { }
            return Ok();
        }


    }
}
