using Newtonsoft.Json;
using System;


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
        private TransferCollection _TransferCollection;
        /// <summary>
        /// 内容会以二进制转为字符串的形式传值,
        /// 通过profocal协议传输具体字段
        /// content包含当前对象的所有值
        /// 此方法内不做任何字段处理,只保存在dictionary中
        /// </summary>
        /// <param name="content"></param>
        public TransferApplication(String content)
        {
            _TransferCollection = JsonConvert.DeserializeObject<TransferCollection>(content);
        }
        public TransferBaseContext CreateContext()
        {
            TransferContext context = new TransferContext(_TransferCollection);
            return context;
        }
        public IAsyncResult BeginProcessRequest(TransferBaseContext context, AsyncCallback cb, object extraData)
        {
            throw new NotImplementedException();
        }

        public void EndProcessRequest(IAsyncResult result)
        {
            throw new NotImplementedException();
        }
    }
}
