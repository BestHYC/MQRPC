
using System;
using System.Collections.Generic;
using System.Text;


/*===================================================
* 类名称: TransferContentHeaders
* 类描述: 传输的协议头
* 创建人: hongyichao
* 创建时间: 2019/6/11 18:07:58
* 修改人: 洪移潮
* 修改时间:
* 版本： @version 1.0
=====================================================*/
/// <summary>
/// 此处尽量简单,因为包括请求内容长度确认,标头,语言之类,通过MQ去确认
/// 后期如果需要可以添加
/// </summary>
namespace Framework.MQRPC.Transfers
{
    public class TransferContentHeaders
    {
        //
        // 摘要:
        //     获取或设置 MQ 响应上的 Content-MD5 内容标头值。
        //
        // 返回结果:
        //     MQ 响应上的 Content-MD5 内容标头值。
        public byte[] ContentMD5 { get; set; }
        //
        // 摘要:
        //     获取或设置 MQ 响应上的 Content-Location 内容标头值。
        //
        // 返回结果:
        //     MQ 响应上的 Content-Location 内容标头值。
        public Uri ContentLocation { get; set; }
    }
}
