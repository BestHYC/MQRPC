using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：MQServerFactory  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/9 15:54:45
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC
{
    public class MQServerFactory : IServerFactory
    {
        private readonly IConnectionFactory _factory;
        public MQServerFactory()
        {
        }
        public ITransferServer Create()
        {
            return new MQServer(_factory);
        }
    }
}
