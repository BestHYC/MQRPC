using Framework.IOCApplication;
using System;
using System.Collections.Generic;
using System.Text;
using IServiceProvider = Framework.IOCApplication.IServiceProvider;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：TransferHost  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/8 17:38:41
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC
{
    public class TransferHost : ITransferHost
    {
        private IServiceProvider serviceProvider;
        private IServiceCollection serviceCollection;
        private Type startupType;
        public TransferHost(IServiceCollection appServices, Type startupType)
        {
            this.serviceProvider = appServices.BuildServiceProvider();
            this.startupType = startupType;
            serviceCollection = appServices;
        }
        public void Run()
        {
            IApplicationBuilder application = serviceProvider.GetRequiredService<IApplicationBuilder>();
            IStartupLoader start = serviceProvider.GetRequiredService<IStartupLoader>();
            //注入中间件
            start.GetConfigureDelegate(startupType)();
            //注入服务
            start.GetConfigureServices(startupType)(serviceCollection);
            ITransferServer transfer = 
                serviceProvider.GetRequiredService<IServerFactory>().Create();
            transfer.Start(new HostApplication(application.Build()));
        }
    }
}
