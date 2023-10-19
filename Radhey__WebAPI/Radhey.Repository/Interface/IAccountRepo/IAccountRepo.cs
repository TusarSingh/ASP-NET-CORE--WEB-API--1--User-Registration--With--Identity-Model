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

        public Task<ResponseComModel> UserRegistration(UserRegistrationReqModel userRegistrationReq);

        public Task<ResponseComModel> UserLogin(UserLoginReqModel userLoginReq);





    }
}
