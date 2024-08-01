using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Repository.Interface.IAccountRepo;
using Radhey.Repository.Interface.IAccountRepo.IIdentity_By_EFC__Repo.IUser_Login_With_Identity_By_EFC__Repo;

using Radhey.DAL.IdentityTables;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;


namespace Radhey.Repository.Implementation.AccountRepo.Identity_By_EFC__Repo.User_Login_With_Identity_By_EFC__Repo
{
    public class User_Login_With_Identity_By_EFC__Repo : IUser_Login_With_Identity_By_EFC__Repo
    {


        private readonly ICustomUserManager _userManager;
        private readonly ICustomSignInManager _signInManager;




        public User_Login_With_Identity_By_EFC__Repo(
                                 ICustomUserManager userManager
                               , ICustomSignInManager signInManager
                                )
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }








        #region UserLogin

        public async Task<ResponseComModel<object>> UserLogin(UserLoginReqModel userLoginReq)
        {
            ResponseComModel<object> response = new ResponseComModel<object>();

            TblApplicationUser tblApplicationUser = new TblApplicationUser();

            var chkUserEmail = await _userManager.GetFindByEmailAsync(userLoginReq.Email).ConfigureAwait(false);

            if (chkUserEmail != null)
            {
                var chkPass = await _userManager.GetCheckPasswordAsync(chkUserEmail, userLoginReq.Password).ConfigureAwait(false);



                if (chkPass)
                {
                    //var userLogin = await _signInManager.GetPasswordSignInAsync(chkUserEmail, userLoginReq.Password, false, false);
                    var userLogin = await _signInManager.GetPasswordSignInAsync(userLoginReq.Email, userLoginReq.Password, false, false);


                    response.StatusCode = 200;
                    response.Data = userLoginReq.Email;
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
