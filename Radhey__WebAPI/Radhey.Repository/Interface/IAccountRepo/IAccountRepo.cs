using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

namespace Radhey.Repository.Interface.IAccountRepo
{
    public interface IAccountRepo
    {

        public Task<ResponseComModel> UserRegistrationCreateAsync(UserRegistrationReqModel userRegistrationReq);
        public Task<ResponseComModel> UserRegistrationCreateAsyncWithPassword(UserRegistrationReqModel userRegistrationReq);

        public Task<ResponseComModel<object>> UserLogin(UserLoginReqModel userLoginReq);

        public Task<ResponseComModel<object>> GetAllUser();



    }
}
