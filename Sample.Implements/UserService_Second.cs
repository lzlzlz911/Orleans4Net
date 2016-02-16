namespace Sample.Implements{
    #region Using

    using System.Threading.Tasks;

    using Interfaces;

    using Orleans;

    #endregion

    public class UserService_Second : Grain, IUserService
    {

        public Task<bool> Exist(string mobileNumber){
            #region IUserService

            return Task.FromResult(mobileNumber == "888888");

            #endregion
        }

    }

}