
using Framework.MQRPC;
using System;
using System.Collections.Generic;
using System.Text;


/*===================================================
* 类名称: RequestContext
* 类描述: 针对MQ传递数据初始化的信息数据
* 创建人: hongyichao
* 创建时间: 2019/6/6 18:21:33
* 修改人: 洪移潮
* 修改时间:
* 版本： @version 1.0
=====================================================*/
namespace Framework.MQApi
{
    public class RequestContext
    {
        /// <summary>
        /// 中间节请求
        /// </summary>
        public TransferBaseContext Context { get; set; }
        /// <summary>
        /// 路由值请求
        /// </summary>
        public RouteData RouteData { get; set; }
    }
}
