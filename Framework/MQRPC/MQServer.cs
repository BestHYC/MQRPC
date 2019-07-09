using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：IMQServer  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/9 15:34:11
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC
{
    public class MQServer : ITransferServer
    {
        public MQServer(IConnectionFactory conn)
        {

        }
        public void Start<TContext>(IHostApplication<TContext> application)
        {
            throw new NotImplementedException();
        }
    }
}
