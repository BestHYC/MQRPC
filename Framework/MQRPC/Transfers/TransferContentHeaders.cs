
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
namespace Framework.MQRPC
{
    /// <summary>
    /// 
    /// </summary>
    public class TransferContentHeaders
    {
        /// <summary>
        /// 请求权限
        /// </summary>
        public String Authorization { get; set; }
        //
        // 摘要:
        //     获取或设置 MQ 响应上的 Uri数据。
        //
        // 返回结果:
        //     MQ 响应上的 Uri数据,也需要记录需要返回的记录值。
        public Uri ContentLocation { get; set; }
        /// <summary>
        /// 当前内容的长度
        /// </summary>
        public Int32 ContentLength { get; set; }
        /// <summary>
        /// 内容的类型
        /// </summary>
        public String ContentType { get; set; }
    }
}
