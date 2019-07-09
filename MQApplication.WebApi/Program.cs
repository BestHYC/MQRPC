using Framework.MQRPC;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQApplication.WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            TransferHostBuilder hostBuilder = new TransferHostBuilder();
            hostBuilder.UserStartup(typeof(Startup))
                .UserServer(new MQServerFactory(new ConnectionFactory()));
            hostBuilder.Build().Run();
        }
    }
}
