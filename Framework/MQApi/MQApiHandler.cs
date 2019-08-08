using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:撸起袖子加油干,树大江大河大气象,立基础基层基本功
 * 功能描述：MQApiHandler  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/18 15:09:28
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQApi
{
    public class MQApiHandler : IApiHandler
    {
        private RequestContext RequestContext;
        private IControllerFactory ControllerFactory;
        public MQApiHandler(RequestContext requestContext)
        {
            RequestContext = requestContext;
            ControllerFactory = new DefaultControllerFactory();
        }
        public void ProcessRequest()
        {
            String controllername = RequestContext.RouteData.Controller;
            IApiController controller = ControllerFactory.CreateController(RequestContext, controllername);
            if (controller == null) return;
            controller.Execute(RequestContext);
        }
    }
}
