using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：FeatureCollection  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/2 10:14:13
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.IOCApplication
{
    public class FeatureCollection : IFeatureCollection
    {
        public TFeature Get<TFeature>()
        {
            throw new NotImplementedException();
        }

        public void Set<TFeature>(TFeature instance)
        {
            throw new NotImplementedException();
        }
    }
}
