using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:撸起袖子加油干,树大江大河大气象,立基础基层基本功
 * 功能描述：DefaultModelBinder  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/18 19:17:46
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQApi
{
    public class DefaultModelBinder : IModelBinder
    {
        public Object BindModel(ControllerContext controllerContext, String modelName, Type modelType)
        {
            if (modelType.IsValueType || typeof(string) == modelType)
            {
                Object instance;
                if (GetValueTypeInstance(controllerContext, modelName, modelType, out instance))
                {
                    return instance;
                }
            }
            return null;
        }
        private bool GetValueTypeInstance(ControllerContext controllerContext, String modelName, Type modelType, out Object value)
        {
            Dictionary<String, Object> dataSource = new Dictionary<String, Object>();
            RouteData data = controllerContext.RequestContext.RouteData;
            foreach (String key in data.QueryString)
            {
                if (dataSource.ContainsKey(key.ToLower()))
                {
                    continue;
                }
                dataSource.Add(key.ToLower(), data.QueryString[key]);
            }
            foreach (String key in data.Params)
            {
                if (dataSource.ContainsKey(key.ToLower()))
                {
                    continue;
                }
                dataSource.Add(key.ToLower(), data.Params[key]);
            }
            if (dataSource.TryGetValue(modelName.ToLower(), out value))
            {
                value = Convert.ChangeType(value, modelType);
                return true;
            }
            return false;
        }
    }
}
