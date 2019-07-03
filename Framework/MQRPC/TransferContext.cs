
using System;
using System.Collections.Generic;
using System.Text;


/*===================================================
* 类名称: TransferContext
* 类描述: 接受传输数据信息
* 创建人: hongyichao
* 创建时间: 2019/6/11 16:47:01
* 修改人: 洪移潮
* 修改时间:
* 版本： @version 1.0
=====================================================*/
namespace Framework.MQRPC
{
    public class TransferContext
    {
        public TransferRequest TransferRequest { get; }
        public TransferResponse TransferResponse { get; }
    }
}
