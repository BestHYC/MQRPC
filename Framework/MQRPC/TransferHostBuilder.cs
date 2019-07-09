using Framework.IOCApplication;
using System;
using System.Collections.Generic;
using System.Text;
using IServiceProvide = Framework.IOCApplication.IServiceProvider;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：TransferHostBuilder  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/8 17:51:22
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC
{
    public class TransferHostBuilder : ITransferHostBuilder
    {
        private IServiceCollection services;
        private Type _startType;
        public TransferHostBuilder()
        {
            services = new ServiceCollection()
                .AddTransient<IStattupLoader, StartupLoader>()
                .AddTransient<IApplicationBuilderFactory, ApplicationBuilderFactory>();
        }
        public ITransferHost Build()
        {
            throw new NotImplementedException();
        }

        public ITransferHostBuilder UserServer(IServerFactory factory)
        {
            throw new NotImplementedException();
        }

        public ITransferHostBuilder UserStartup(Type startupType)
        {
            throw new NotImplementedException();
        }
    }
}
