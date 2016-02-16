namespace Sample.Implements{
    #region Using

    using System.Threading.Tasks;

    using Interfaces;

    using Orleans;

    #endregion

    public class UserService : Grain, IUserService{

        public Task<bool> Exist(string mobileNumber){
            #region IUserService

            return Task.FromResult(mobileNumber == "666666");

            #endregion
        }

    }

}