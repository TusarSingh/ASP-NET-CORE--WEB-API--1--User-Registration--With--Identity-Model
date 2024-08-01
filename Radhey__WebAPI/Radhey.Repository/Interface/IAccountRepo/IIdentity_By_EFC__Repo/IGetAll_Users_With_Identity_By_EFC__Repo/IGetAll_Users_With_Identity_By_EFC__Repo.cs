using Radhey.Model.CommonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radhey.Repository.Interface.IAccountRepo.IIdentity_By_EFC__Repo.IGetAll_Users_With_Identity_By_EFC__Repo
{
    public interface IGetAll_Users_With_Identity_By_EFC__Repo
    {
        public Task<ResponseComModel<object>> GetAllUser();



    }
}
