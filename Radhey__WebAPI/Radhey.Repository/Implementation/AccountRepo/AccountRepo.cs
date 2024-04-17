using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Identity;
using Radhey.DAL.IdentityTables;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;
using Radhey.Repository.Interface.IAccountRepo;





namespace Radhey.Repository.Implementation.AccountRepo
{
    public class AccountRepo : IAccountRepo
    {
        private readonly ICustomUserManager _userManager;
        private readonly ICustomSignInManager _signInManager;








        public AccountRepo(
                            ICustomUserManager userManager
                           , ICustomSignInManager signInManager
                          )
        {
            this._userManager = userManager;
            this._signInManager = signInManager;    
        }

        #region User Registration

        #region UserRegistration => CreateAsync(User)
        public async Task<ResponseComModel> UserRegistrationCreateAsync(UserRegistrationReqModel userRegistrationReq)
        {
            ResponseComModel response = new ResponseComModel();

            TblApplicationUser User = new TblApplicationUser()
            {
                FirstName = userRegistrationReq.FirstName,
                LastName = userRegistrationReq.LastName,
                UserName = userRegistrationReq.Email,
                Email = userRegistrationReq.Email,
                PasswordHash = userRegistrationReq.Password,
                PhoneNumber = userRegistrationReq.Phone
            };

            var saveResult = await _userManager.GetCreateAsync(User).ConfigureAwait(false);

            if (saveResult.Succeeded)
            {
                response.StatusCode = 200;
            }
            else
            {
                response.StatusCode = 400;
            }

            return response;

        }

        #endregion

        #region UserRegistration => CreateAsync(User,userRegistrationReq.Password)
        public async Task<ResponseComModel> UserRegistrationCreateAsyncWithPassword(UserRegistrationReqModel userRegistrationReq)
        {
            ResponseComModel response = new ResponseComModel();

            TblApplicationUser User = new TblApplicationUser()
            {
                FirstName = userRegistrationReq.FirstName,
                LastName = userRegistrationReq.LastName,
                UserName = userRegistrationReq.Email,
                Email = userRegistrationReq.Email,
                PasswordHash = userRegistrationReq.Password,
                PhoneNumber = userRegistrationReq.Phone
            };

            var saveResult = await _userManager.GetCreateAsync(User,userRegistrationReq.Password).ConfigureAwait(false);
            
            if (saveResult.Succeeded)
            {
                response.StatusCode = 200;
            }
            else
            {
                response.StatusCode = 400;
            }

            return response;
            
        }

        #endregion

        #endregion


        #region UserLogin

        public async Task<ResponseComModel> UserLogin(UserLoginReqModel userLoginReq)
        {
            ResponseComModel response = new ResponseComModel();

            TblApplicationUser tblApplicationUser = new TblApplicationUser();

            var chkUserEmail = await _userManager.GetFindByEmailAsync(userLoginReq.Email).ConfigureAwait(false);
        
            if (chkUserEmail != null)
            {
                var chkPass = await _userManager.GetCheckPasswordAsync(chkUserEmail, userLoginReq.Password).ConfigureAwait(false);



                if (chkPass)
                {
                    //var userLogin = await _signInManager.PasswordSignInAsync(chkUserEmail, userLoginReq.Password, false, false);
                    var userLogin = await _signInManager.GetPasswordSignInAsync(userLoginReq.Email, userLoginReq.Password, false, false);
                    
                    
                    response.StatusCode = 200;

                }
                else
                {
                    response.StatusCode = 400;
                    response.StatusMessage = "Password is Wrong.";
                }
            }
            else
            {
                response.StatusCode = 401;
                response.StatusMessage = "Please Check your Email";
            }

            return response;
        }


        #endregion


    }










}
