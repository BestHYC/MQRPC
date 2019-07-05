using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;


/* ==============================================================================
 * 当前网站:$webnamespace$ 
 * 功能描述：TransferRequest  
 * 创 建 者：Administrator
 * 创建日期：2019/6/26 14:32:42
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC.Transfers
{
    /// <summary>
    /// 当前的请求集合解析
    /// </summary>
    public sealed class TransferRequest
    {
        private TransferCollection _collection;
        public TransferRequest(TransferCollection collection)
        {
            _collection = collection;
        }
        /// <summary>
        /// 针对请求发起多种查询参数索引
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string key]
        {
            get
            {
                return Params[key];
            }
        }
        public bool IsAuthenticated { get; }
        public string Path { get; }
        public NameValueCollection Params { get; }
        public Uri UriReference { get; }
        public Uri Url { get; }
        public string UserHostAddress { get; }
        public string UserHostName { get; }
        public NameValueCollection QueryString { get; }
        public NameValueCollection Headers { get; }
    }
}
