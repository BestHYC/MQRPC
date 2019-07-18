
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;


/*===================================================
* 类名称: RouteData
* 类描述: 针对请求过来的路由模板
* 创建人: hongyichao
* 创建时间: 2019/6/6 18:23:22
* 修改人: 洪移潮
* 修改时间:
* 版本： @version 1.0
=====================================================*/
namespace Framework.MQApi
{
    /// <summary>
    /// 通过路由值,取得具体的参数,调取controller,Action,Arguments
    /// </summary>
    public class RouteData
    {
        public IRouteHandler RouteHandler { get; set; }
        public NameValueCollection Values { get; }
        public NameValueCollection Params { get; }
        public NameValueCollection QueryString { get; }
        public NameValueCollection Headers { get; }
        public RouteData()
        {
            Values = new NameValueCollection();
            Params = new NameValueCollection();
            QueryString = new NameValueCollection();
            Headers = new NameValueCollection();
        }
        public String Controller
        {
            get
            {
                return this.Values.Get("controller");
            }
        }
        public String ActionName
        {
            get
            {
                return this.Values.Get("action");
            }
        }
    }
}
