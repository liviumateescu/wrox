using UnitTestingSamples;
// <copyright file="StringSampleFactory.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;

namespace UnitTestingSamples
{
    /// <summary>A factory for UnitTestingSamples.StringSample instances</summary>
    public static partial class StringSampleFactory
    {
        /// <summary>A factory for UnitTestingSamples.StringSample instances</summary>
        [PexFactoryMethod(typeof(StringSample))]
        public static StringSample Create(string init_s)
        {
            StringSample stringSample = new StringSample(init_s);
            return stringSample;

            // TODO: Edit factory method of StringSample
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
