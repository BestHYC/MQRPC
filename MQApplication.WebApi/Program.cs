using Framework.MQRPC;

namespace MQApplication.WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            TransferHostBuilder hostBuilder = new TransferHostBuilder();
            hostBuilder.UserStartup(typeof(Startup))
                .UserServer(new MQServerFactory());
            hostBuilder.Build().Run();
        }
    }
}
