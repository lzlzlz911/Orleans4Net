namespace Sample.Interfaces{
    #region Using

    using System.Threading.Tasks;

    using Orleans;

    #endregion

    public interface IUserService : IGrainWithIntegerKey{

        Task<bool> Exist(string mobileNumber);

    }

}