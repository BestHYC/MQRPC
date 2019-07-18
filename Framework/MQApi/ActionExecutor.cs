using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;


/* ==============================================================================
 * 格言:撸起袖子加油干,树大江大河大气象,立基础基层基本功
 * 功能描述：ActionExecutor  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/18 19:15:38
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQApi
{
    public class ActionExecutor
    {
        private static Dictionary<MethodInfo, Func<Object, Object[], Object>> executors = new Dictionary<MethodInfo, Func<object, object[], object>>();
        private static Object syncHelper = new object();
        public MethodInfo MethodInfo { get; private set; }
        public ActionExecutor(MethodInfo methodInfo)
        {
            this.MethodInfo = methodInfo;
        }
        public Object Execute(Object target, Object[] arguments)
        {
            Func<Object, Object[], Object> executor;
            if (!executors.TryGetValue(this.MethodInfo, out executor))
            {
                lock (syncHelper)
                {
                    if (!executors.TryGetValue(this.MethodInfo, out executor))
                    {
                        executor = CreateExecutor(this.MethodInfo);
                        executors[this.MethodInfo] = executor;
                    }
                }
            }
            return executor(target, arguments);
        }
        private static Func<Object, Object[], Object> CreateExecutor(MethodInfo methodInfo)
        {
            ParameterExpression target = Expression.Parameter(typeof(Object), "target");
            ParameterExpression arguments = Expression.Parameter(typeof(Object[]), "arguments");
            List<Expression> parameters = new List<Expression>();
            ParameterInfo[] paramInfos = methodInfo.GetParameters();
            for (Int32 i = 0; i < paramInfos.Length; i++)
            {
                ParameterInfo paramInfo = paramInfos[i];
                BinaryExpression getElementByIndex = Expression.ArrayIndex(arguments, Expression.Constant(i));
                UnaryExpression converToParamterType = Expression.Convert(getElementByIndex, paramInfo.ParameterType);
                parameters.Add(converToParamterType);
            }
            UnaryExpression instanceCast = Expression.Convert(target, methodInfo.ReflectedType);
            MethodCallExpression methodCall = Expression.Call(instanceCast, methodInfo, parameters);
            UnaryExpression converToObjectType = Expression.Convert(methodCall, typeof(Object));
            return Expression.Lambda<Func<Object, Object[], Object>>(converToObjectType, target, arguments).Compile();
        }
    }
}
