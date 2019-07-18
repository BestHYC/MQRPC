using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.MQApi
{
    public interface IModelBinder
    {
        Object BindModel(ControllerContext controllerContext, String modelName, Type modelType);
    }
}
