using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;



using Radhey.BAL.Interface.IAccountBAL;
using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;
using Microsoft.IdentityModel.Tokens;
using System.Xml;

namespace Radhey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAccountBAL _accountBAL;



        public AccountController(IAccountBAL accountBAL)
        {
            this._accountBAL = accountBAL;
        }


        [HttpPost]
        [Route("UserRegistration")]
        public async Task<IActionResult> UserRegistration(UserRegistrationReqModel userRegistrationReq)
        {
            ResponseComModel apiResponse = new ResponseComModel();
            
            if (userRegistrationReq != null)
            {
                apiResponse = await _accountBAL.UserRegistration(userRegistrationReq).ConfigureAwait(false);
            
                switch (apiResponse.StatusCode)
                {
                        case 200:   apiResponse = new ResponseComModel()
                        {
                            StatusCode = 200,
                            IsSuccess = true,
                            StatusMessage = "User Registration Successfully"
                        };
                        return Ok(apiResponse);
                        
                        case 400:   apiResponse = new ResponseComModel()
                            {
                            StatusCode = 400,
                            IsSuccess = false,
                            StatusMessage = "User Registration Failed"
                        };
                        return BadRequest(apiResponse);
                    
                        default:   apiResponse = new ResponseComModel()
                        {
                            StatusCode = 500,
                            IsSuccess = false,
                            StatusMessage = "Internal Server Error"
                        };
                        return Ok(apiResponse);       
                }            
            }
            else
            {
                apiResponse = new ResponseComModel()
                {
                    StatusCode = 500,
                    IsSuccess = false,
                    StatusMessage = "Internal Server Error"
                };
                return Ok(apiResponse);
            }
        }

























    }
}
