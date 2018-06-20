using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Frends.Community.AesCtrCalculator.Tests
{
    [TestClass]
    public class AesCtrCalculatorTasksTest
    {
        [TestMethod]
        public void Calculate_Should_Work()
        {
            var result = AesCtrCalculatorTasks.CalculateAesCtr(new Input { Data = "1af1ae9ba7cfda4c84d6", Key = "110BFE1B1116085EB5611152E5244FF5", Iv = "1c1c1c1c1c1c1c1c1c1c1c1c1c1c1c1c" });
            Assert.AreEqual(result.Data, "A7837045760FDAD82C0D");
        }

        [TestMethod]
        public void Calculate_Should_Throw_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => AesCtrCalculatorTasks.CalculateAesCtr(new Input
            {
                Data = "1af1ae9ba7cfda4c84d6",
                Key = "10BFE1B1116085EB5611152E5244FF5",
                Iv = "1c1c1c1c1c1c1c1c1c1c1c1c1c1c1c1c"
            }));
        }

    }
}
