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
                .AddTransient<IStartupLoader, StartupLoader>()
                .AddTransient<IApplicationBuilder, ApplicationBuilder>();
        }
        public ITransferHost Build()
        {
            return new TransferHost(services, _startType);
        }
        public ITransferHostBuilder UserServer(IServerFactory factory)
        {
            services.AddSingleton<IServerFactory>(factory);
            return this;
        }
        public ITransferHostBuilder UserStartup(Type startupType)
        {
            this._startType = startupType;
            return this;
        }
    }
}
