using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：HostApplication  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/9 14:47:57
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC
{
    public class HostApplication:IHostApplication<TransferContext>
    {
        public RequestDelegate Application { get; }

        public object AsyncState => throw new NotImplementedException();

        public WaitHandle AsyncWaitHandle => throw new NotImplementedException();

        public bool CompletedSynchronously => throw new NotImplementedException();

        public bool IsCompleted => throw new NotImplementedException();

        public HostApplication(RequestDelegate application)
        {
            this.Application = application;
        }
        public void DisposeContext(TransferContext context, Exception exception)
        {
        }
    }
}
