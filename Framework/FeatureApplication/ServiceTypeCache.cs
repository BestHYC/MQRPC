using Framework.Clones;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：ServiceTypeObject  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/2 16:48:12
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.FeatureApplication
{
    public enum ServiceTypeEnum
    {
        /// <summary>
        /// 单例
        /// </summary>
        Singleton = 0,
        /// <summary>
        /// 单次
        /// </summary>
        Transient = 1
    }
    /// <summary>
    /// 此处只当做流程执行下去,具体请看AutoFac源码,此处只是对此源码做抽象改编
    /// 
    /// </summary>
    public class ServiceTypeCache
    {
        /// <summary>
        /// 保存当前类型
        /// </summary>
        private Type _type;
        /// <summary>
        /// 保存当前类型种类
        /// </summary>
        private ServiceTypeEnum _typeEnum;
        /// <summary>
        /// 缓存当前对象
        /// </summary>
        private Object _obj;
        public ServiceTypeCache(Type type, ServiceTypeEnum typeEnum)
        {
            _type = type;
            _typeEnum = typeEnum;
        }
        public ServiceTypeCache(Object t, ServiceTypeEnum typeEnum)
        {
            _obj = t;
            _typeEnum = typeEnum;
        }
        /// <summary>
        /// 针对构造参数最多的构造器进行创建对象
        /// 如果有相同数量的构造器,选择最后一个构造器
        /// </summary>
        /// <returns></returns>
        public Object GetObj(IDictionary<Type, ServiceTypeCache> typePairs)
        {
            if(_obj == null)
            {
                List<Type> types = GetConstructor();
                Object[] paramters = types.ConvertAll(item => typePairs[item].GetObj(typePairs)).ToArray();
                _obj = Activator.CreateInstance(_type, paramters);
            }
            if (_typeEnum == ServiceTypeEnum.Transient)
            {
                return _obj.DeepClone();
            }
            if (_typeEnum == ServiceTypeEnum.Singleton)
            {
                return _obj;
            }
            throw new Exception("注入对象报错,请查证后再运行");
        }
        /// <summary>
        /// 如果有相同数量的构造器,选择最后一个构造器
        /// </summary>
        /// <returns></returns>
        private List<Type> GetConstructor()
        {
            ConstructorInfo[] a = _type.GetConstructors();
            ConstructorInfo b = null;
            Int32 length = 0;
            foreach (ConstructorInfo info in a)
            {
                if(info.GetParameters().Length >= length)
                {
                    b = info;
                }
            }
            ParameterInfo[] pa = b.GetParameters();
            List<Type> list = new List<Type>();
            foreach(var p in pa)
            {
                list.Add(p.ParameterType);
            }
            return list;
        }
    }
}
