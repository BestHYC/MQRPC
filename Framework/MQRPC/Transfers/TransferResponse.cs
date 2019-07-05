using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


/* ==============================================================================
 * 当前网站:$webnamespace$ 
 * 功能描述：TransferResponse  
 * 创 建 者：Administrator
 * 创建日期：2019/6/26 15:10:22
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC
{
    /// <summary>
    /// 当前请求的返回值信息
    /// </summary>
    public sealed class TransferResponse
    {
        public TransferCollection _collection;
        public TransferResponse(TransferCollection collection)
        {
            _collection = collection;
        }
        public Stream OutputStream { get; }
    }
}
