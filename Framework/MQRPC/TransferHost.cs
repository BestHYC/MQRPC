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
        private Type startupType;
        public TransferHost(IServiceCollection appServices, Type startupType)
        {
            this.serviceProvider = appServices.BuildServiceProvider();
            this.startupType = startupType;
        }
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
