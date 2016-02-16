namespace Orleans4Net.Client{
    #region Using

    using System;

    using Orleans;

    using Sample.Interfaces;

    #endregion

    internal class Program{

        private static void Main(string[] args){
            GrainClient.Initialize();

            while (true){
                Console.WriteLine("Press Key.......");
                string mobileNumber = Console.ReadLine();
                IUserService userService = GrainClient.GrainFactory.GetGrain<IUserService>(0);
                Console.WriteLine(userService.Exist(mobileNumber).Result);
            }
        }

    }

}