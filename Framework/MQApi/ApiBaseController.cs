using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：ApiBaseController  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/12 11:52:56
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQApi
{
    /// <summary>
    /// api控制器的基类
    /// </summary>
    public class ApiBaseController : IApiController
    {
        protected IActionInvoker ActionInvoker { get; set; }
        public ApiBaseController()
        {
            ActionInvoker = new DefaultActionInvoker();
        }
        /// <summary>
        /// 执行方法
        /// </summary>
        /// <param name="requestContext"></param>
        public void Execute(RequestContext requestContext)
        {
            ControllerContext context = new ControllerContext()
            {
                Controller = this,
                RequestContext = requestContext
            };
            String actionName = requestContext.RouteData.ActionName;
            ActionInvoker.InvokeAction(context, actionName);
        }
    }
}
