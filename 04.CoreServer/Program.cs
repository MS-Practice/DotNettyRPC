using Coldairarrow.DotNettyRPC;
using Common;
using Common.Imps;
using Common.Interfaces;
using System;

namespace _04.CoreServer
{
    class Program
    {
        static void Main(string[] args)
        {
            RPCServer rPCServer = new RPCServer(39999);
            rPCServer.RegisterService<IBasicDataRpcService, BasicDataRpcService>();
            rPCServer.RegisterService<IHello, Hello>();
            rPCServer.Start();

            Console.ReadLine();
        }
    }
}
