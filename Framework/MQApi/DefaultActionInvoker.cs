using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


/* ==============================================================================
 * 格言:撸起袖子加油干,树大江大河大气象,立基础基层基本功
 * 功能描述：DefaultActionInvoker  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/18 19:10:59
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQApi
{
    public class DefaultActionInvoker : IActionInvoker
    {
        public IModelBinder ModelBinder { get; private set; }
        public DefaultActionInvoker()
        {
            this.ModelBinder = new DefaultModelBinder();
        }
        public void InvokeAction(ControllerContext controllerContext, string actionName)
        {
            MethodInfo methodInfo = controllerContext.Controller.GetType().GetMethods().First(m => String.Compare(actionName, m.Name, true) == 0);
            List<Object> parameters = new List<object>();
            foreach (ParameterInfo paramter in methodInfo.GetParameters())
            {
                parameters.Add(this.ModelBinder.BindModel(controllerContext, paramter.Name, paramter.ParameterType));
            }
            ActionExecutor executor = new ActionExecutor(methodInfo);
            ActionResult actionResult = (ActionResult)executor.Execute(controllerContext.Controller, parameters.ToArray());
            actionResult.ExecuteResult(controllerContext);
        }
    }
}
