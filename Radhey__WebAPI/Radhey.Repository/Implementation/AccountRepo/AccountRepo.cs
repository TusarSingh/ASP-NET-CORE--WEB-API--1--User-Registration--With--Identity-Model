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

        private readonly UserManager<TblApplicationUser> _userManager;
        








        public AccountRepo(UserManager<TblApplicationUser> userManager)
        {
                this._userManager = userManager;    
        }



        #region 
        //public async Task<ResponseComModel> UserRegistration(UserRegistrationReqModel userRegistrationReq)
        //{
        //    ResponseComModel response = new ResponseComModel();

        //    TblApplicationUser User = new TblApplicationUser()
        //    {
        //        FirstName = userRegistrationReq.FirstName,
        //        LastName = userRegistrationReq.LastName,
        //        UserName = userRegistrationReq.Email,
        //        Email = userRegistrationReq.Email,
        //        PasswordHash = userRegistrationReq.Password,
        //        PhoneNumber = userRegistrationReq.Phone
        //    };

        //    var saveResult = await _userManager.CreateAsync(User).ConfigureAwait(false);

        //    if (saveResult.Succeeded)
        //    {
        //        response.StatusCode = 200;
        //    }
        //    else
        //    {
        //        response.StatusCode = 400;
        //    }

        //    return response;
            
        //}

        #endregion
        public async Task<ResponseComModel> UserRegistration(UserRegistrationReqModel userRegistrationReq)
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

            var saveResult = await _userManager.CreateAsync(User,userRegistrationReq.Password).ConfigureAwait(false);

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







    }










}
