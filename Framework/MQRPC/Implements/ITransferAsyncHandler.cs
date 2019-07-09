using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Framework.MQRPC
{
    public interface ITransferAsyncHandler
    {
        TransferBaseContext CreateContext();
        //
        // 摘要:
        //     启动异步 HTTP 处理程序调用。
        //
        // 参数:
        //   context:
        //     System.Web.ITransferAsyncHandler 提供对内部服务器对象的引用的对象 (例如， Request, ，Response, ，Session, ，和
        //     Server) 用于处理 HTTP 请求。
        //
        //   cb:
        //     System.AsyncCallback 调用异步方法调用完成时。 如果 cb 是 null, ，不会调用的委托。
        //
        //   extraData:
        //     处理请求所需的所有未知额外数据。
        //
        // 返回结果:
        //     System.IAsyncResult 包含有关状态的进程的信息。
        Task ProcessRequestAsync(TransferBaseContext context);
    }
}
