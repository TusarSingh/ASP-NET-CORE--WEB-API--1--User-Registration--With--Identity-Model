using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Repository.Interface.IAccountRepo;
using Radhey.Repository.Interface.IAccountRepo.IIdentity_By_EFC__Repo.IGetAll_Users_With_Identity_By_EFC__Repo;

using Radhey.Model.CommonModel;


namespace Radhey.Repository.Implementation.AccountRepo.Identity_By_EFC__Repo.GetAll_Users_With_Identity_By_EFC__Repo
{
    public class GetAll_Users_With_Identity_By_EFC__Repo : IGetAll_Users_With_Identity_By_EFC__Repo
    {
        private readonly ICustomUserManager _customUserManager;
        private readonly ICustomSignInManager _customSignInManager;


        public GetAll_Users_With_Identity_By_EFC__Repo(
                                 ICustomUserManager customUserManager,
                                 ICustomSignInManager customSignInManager
                                )
        {
            _customUserManager = customUserManager;
            _customSignInManager = customSignInManager;
        }


        #region GetAllUser
        public async Task<ResponseComModel<object>> GetAllUser()
        {
            ResponseComModel<object> response = new ResponseComModel<object>();

            response = await _customUserManager.GetUser().ConfigureAwait(false);

            return response;

        }


        #endregion





    }
}
