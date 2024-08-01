using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radhey.Repository.Interface.IAccountRepo.IIdentity_By_EFC__Repo.IUser_Login_With_Identity_By_EFC__Repo
{
    public interface IUser_Login_With_Identity_By_EFC__Repo
    {
        public Task<ResponseComModel<object>> UserLogin(UserLoginReqModel userLoginReq);
    }
}
