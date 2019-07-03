using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.IOCApplication
{
    public interface IFeatureCollection
    {
        TFeature Get<TFeature>();
        void Set<TFeature>(TFeature instance);
    }
}
