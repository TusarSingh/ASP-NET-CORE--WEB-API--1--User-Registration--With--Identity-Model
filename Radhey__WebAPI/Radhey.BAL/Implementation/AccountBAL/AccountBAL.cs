using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Microsoft.AspNetCore.Identity;
using Radhey.BAL.Interface.IAccountBAL;
using Radhey.DAL.IdentityTables;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;
using Radhey.Repository;
using Radhey.Repository.Interface;
using Radhey.Repository.Interface.IAccountRepo;



namespace Radhey.BAL.Implementation.AccountBAL
{
    public class AccountBAL : IAccountBAL
    {

        public readonly IAccountRepo _accountRepo;



        public AccountBAL(IAccountRepo accountRepo)
        {
            this._accountRepo = accountRepo;
        }


        #region User Registration

        #region User Registration Create Async => CreateAsync(User)
        public async Task<ResponseComModel> UserRegistrationCreateAsync(UserRegistrationReqModel userRegistrationReq)
        {
            var response = new ResponseComModel();

            response = await _accountRepo.UserRegistrationCreateAsync(userRegistrationReq).ConfigureAwait(false);

            return response;

        }

        #endregion

        #region User Registration Create Async With Password => CreateAsync(User,userRegistrationReq.Password)

        public async Task<ResponseComModel> UserRegistrationCreateAsyncWithPassword(UserRegistrationReqModel userRegistrationReq)
        {
            var response = new ResponseComModel();

            response = await _accountRepo.UserRegistrationCreateAsyncWithPassword(userRegistrationReq).ConfigureAwait(false);

            return response;

        }

        #endregion

        #endregion

        #region UserLogin

        public async Task<ResponseComModel<object>> UserLogin(UserLoginReqModel userLoginReq)
        {
            ResponseComModel<object> response = new ResponseComModel<object>();

            response = await _accountRepo.UserLogin(userLoginReq).ConfigureAwait(false);

            return response;
        }

        #endregion


        #region GetAllUser

        public async Task<ResponseComModel<object>> GetAllUser()
        {
            ResponseComModel<object> response = new ResponseComModel<object>();

            response = await _accountRepo.GetAllUser().ConfigureAwait(false);

            return response;

        }

        #endregion
    }
}
