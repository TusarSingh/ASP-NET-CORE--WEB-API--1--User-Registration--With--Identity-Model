using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;



namespace Radhey.BAL.Interface.IAccountBAL
{
    public interface IAccountBAL
    {

        public Task<ResponseComModel> UserRegistration(UserRegistrationReqModel userRegistrationReq);


    }
}
