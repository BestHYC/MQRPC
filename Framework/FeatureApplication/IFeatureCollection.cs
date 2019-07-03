using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.FeatureApplication
{
    public interface IFeatureCollection
    {
        TFeature Get<TFeature>();
        void Set<TFeature>(TFeature instance);
    }
}
