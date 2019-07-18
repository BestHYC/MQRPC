using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Framework.MQApi
{
    public class DefaultControllerFactory : IControllerFactory
    {
        private static List<Type> controllerTypes = new List<Type>();
        static DefaultControllerFactory()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (Type type in assembly.GetTypes().Where(type => typeof(IApiController).IsAssignableFrom(type)))
            {
                controllerTypes.Add(type);
            }
        }
        public IApiController CreateController(RequestContext context, String name)
        {
            if (name.IndexOf("Controller") == -1) name += "Controller";
            Type controllerType = controllerTypes.FirstOrDefault(c => String.Compare(name, c.Name, true) == 0);
            if (controllerType == null)
            {
                return null;
            }
            return (IApiController)Activator.CreateInstance(controllerType);
        }
    }
}
