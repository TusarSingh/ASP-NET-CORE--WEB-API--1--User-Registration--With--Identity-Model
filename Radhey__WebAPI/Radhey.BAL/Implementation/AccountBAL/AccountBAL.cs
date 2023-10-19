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



        public async Task<ResponseComModel> UserRegistration(UserRegistrationReqModel userRegistrationReq)
        {
            var response = new ResponseComModel();

            response = await _accountRepo.UserRegistration(userRegistrationReq).ConfigureAwait(false);
            
            return response;

        }




        public async Task<ResponseComModel> UserLogin(UserLoginReqModel userLoginReq)
        {
            ResponseComModel response;

            response = await _accountRepo.UserLogin(userLoginReq).ConfigureAwait(false);

            return response;
        }






    }
}
