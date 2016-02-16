namespace Orleans4Net.Server{
    #region Using

    using System;

    using Orleans.Runtime.Host;

    #endregion

    internal class Program{

        private static void Main(string[] args){
            using (SiloHost host = new SiloHost("Default")){
                host.LoadOrleansConfig();
                host.InitializeOrleansSilo();
                host.StartOrleansSilo();

                Console.WriteLine("Start--------");
                Console.ReadLine();

                host.StopOrleansSilo();
            }
        }

    }

}