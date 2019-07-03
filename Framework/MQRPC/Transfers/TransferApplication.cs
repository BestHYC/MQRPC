using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：TransferApplication  
 * 创 建 者：Best_Hong
 * 创建日期：2019/6/26 16:10:37
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC
{
    public class TransferApplication: ITransferAsyncHandler
    {
        /// <summary>
        /// 通过profocal协议传输具体字段,依旧会以流的形式传值
        /// </summary>
        /// <param name="stream"></param>
        public TransferApplication(Stream stream)
        {
        }
        public TransferRequest Request { get; }
        public TransferResponse Response { get; }
        public TransferContext Context { get; }
        //
        // 摘要:
        //     作为执行的 HTTP 管道链中的第一个事件发生，当 ASP.NET 的请求做出响应。
        public event EventHandler BeginRequest;
        //
        // 摘要:
        //     当安全模块已建立的用户标识时出现.
        public event EventHandler AuthenticateRequest;
        //
        // 摘要:
        //     安全模块已验证用户身份验证时发生。
        public event EventHandler AuthorizeRequest;
        //
        // 摘要:
        //     ASP.NET 将内容发送到客户端之前发生。
        public event EventHandler PreSendRequestContent;
        //
        // 摘要:
        //     已释放与请求相关联的托管的对象时发生。
        public event EventHandler RequestCompleted;

        public IAsyncResult BeginProcessRequest(TransferContext context, AsyncCallback cb, object extraData)
        {
            throw new NotImplementedException();
        }

        public void EndProcessRequest(IAsyncResult result)
        {
            throw new NotImplementedException();
        }
    }
}
