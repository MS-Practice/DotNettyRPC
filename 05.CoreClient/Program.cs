using Coldairarrow.DotNettyRPC;
using Common.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace _05.CoreClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IBasicDataRpcService client = RPCClientFactory.GetClient<IBasicDataRpcService>("127.0.0.1", 39999);
            string content = string.Join(",", client.GetAllStages().Select(p => p.StageName));
            Console.WriteLine("完成,返回内容：" + content);
            Console.ReadLine();
        }
    }
}
