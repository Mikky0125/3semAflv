using System;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertDLLLibraryG;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace WeightConvertUnitTest
{
    public class WeightConvertUnitTest
    {
        [TestClass]
        public class WeightConverterUnitTest
        {
            //Godkendes (Yes)
            [TestMethod]
            public void GramToOzTest1()
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1.7636980975, WeightConvert.GramToOzs(50), 0.00001);
            }
            // Skal slå fejl (Yes)
            [TestMethod]
            public void GramToOzTest2()
            {
                Assert.AreEqual(1.80, WeightConvert.GramToOzs(50), 0.0000001);
            }
            //Godkendes (YES)
            [TestMethod]
            public void OzToGramTest1()
            {
                Assert.AreEqual(499.999944890382, WeightConvert.OzToGrams(17.636980975), 0.00001);
            }
            //burde slå fejl
            [TestMethod]
            public void OzToGramTest2()
            {
                Assert.AreEqual(200, WeightConvert.OzToGrams(12), 0.00001);
            }

        }
    }
}
