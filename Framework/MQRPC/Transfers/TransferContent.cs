
using System;
using System.Collections.Generic;
using System.Text;


/*===================================================
* 类名称: TransferContent
* 类描述: 传输的内容
* 创建人: hongyichao
* 创建时间: 2019/6/11 18:07:11
* 修改人: 洪移潮
* 修改时间:
* 版本： @version 1.0
=====================================================*/
namespace Framework.MQRPC.Transfers
{
    /// <summary>
    /// 目前已字符串进行传输,后期改为protof协议方式
    /// </summary>
    public class TransferContent
    {
        /// <summary>
        /// 传输内容头信息
        /// </summary>
        public TransferContentHeaders Headers { get; }
        public TransferRequest TransferRequest { get; }
        public TransferResponse TransferResponse { get; }
        /// <summary>
        /// 传输的内容信息
        /// </summary>
        public String Content { get; }
    }
}
