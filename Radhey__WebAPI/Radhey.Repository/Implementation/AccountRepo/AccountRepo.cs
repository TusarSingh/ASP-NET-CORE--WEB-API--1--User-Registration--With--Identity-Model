using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Repository.Interface.IAccountRepo;
using Radhey.Repository.Interface.IAccountRepo.IIdentity_By_EFC__Repo.IGetAll_Users_With_Identity_By_EFC__Repo;
using Radhey.Repository.Interface.IAccountRepo.IIdentity_By_EFC__Repo.IUser_Login_With_Identity_By_EFC__Repo;
using Radhey.Repository.Interface.IAccountRepo.IIdentity_By_EFC__Repo.IUser_Registration_With_Identity_By_EFC__Repo;


using Microsoft.AspNetCore.Identity;
using Radhey.DAL.DatabaseContext;
using Radhey.DAL.IdentityTables;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;




namespace Radhey.Repository.Implementation.AccountRepo
{
    public class AccountRepo : IAccountRepo
    {
        
        private readonly IUser_Registration_With_Identity_By_EFC__Repo _user_Registration_With_Identity_By_EFC__Repo;
        private readonly IUser_Login_With_Identity_By_EFC__Repo _user_Login_With_Identity_By_EFC__Repo;
        private readonly IGetAll_Users_With_Identity_By_EFC__Repo _getAll_Users_With_Identity_By_EFC__Repo;




        public AccountRepo(
                            IUser_Registration_With_Identity_By_EFC__Repo user_Registration_With_Identity_By_EFC__Repo,
                            IUser_Login_With_Identity_By_EFC__Repo user_Login_With_Identity_By_EFC__Repo,
                            IGetAll_Users_With_Identity_By_EFC__Repo getAll_Users_With_Identity_By_EFC__Repo
                          )
        {
            this._user_Registration_With_Identity_By_EFC__Repo = user_Registration_With_Identity_By_EFC__Repo;
            this._user_Login_With_Identity_By_EFC__Repo = user_Login_With_Identity_By_EFC__Repo;
            this._getAll_Users_With_Identity_By_EFC__Repo = getAll_Users_With_Identity_By_EFC__Repo;
        }





        #region User Registration

        #region User Registration Create Async => CreateAsync(User)
        public async Task<ResponseComModel> UserRegistrationCreateAsync(UserRegistrationReqModel userRegistrationReq)
        {
            ResponseComModel response = new ResponseComModel();

            response = await _user_Registration_With_Identity_By_EFC__Repo.UserRegistrationCreateAsync(userRegistrationReq).ConfigureAwait(false);

            return response;

        }

        #endregion

        #region User Registration Create Async With Password => CreateAsync(User,userRegistrationReq.Password)
        public async Task<ResponseComModel> UserRegistrationCreateAsyncWithPassword(UserRegistrationReqModel userRegistrationReq)
        {
            ResponseComModel response = new ResponseComModel();

            response = await _user_Registration_With_Identity_By_EFC__Repo.UserRegistrationCreateAsyncWithPassword(userRegistrationReq).ConfigureAwait(false);

            return response;

        }

        #endregion

        #endregion


        #region UserLogin

        public async Task<ResponseComModel<object>> UserLogin(UserLoginReqModel userLoginReq)
        {
            ResponseComModel<object> response = new ResponseComModel<object>();

            response = await _user_Login_With_Identity_By_EFC__Repo.UserLogin(userLoginReq).ConfigureAwait(false);;

            return response;
        }

        #endregion

        #region GetAllUser
        public async Task<ResponseComModel<object>> GetAllUser()
        {
            ResponseComModel<object> response = new ResponseComModel<object>();

            response = await _getAll_Users_With_Identity_By_EFC__Repo.GetAllUser().ConfigureAwait(false);

            return response;
        }

        #endregion

    }










}
