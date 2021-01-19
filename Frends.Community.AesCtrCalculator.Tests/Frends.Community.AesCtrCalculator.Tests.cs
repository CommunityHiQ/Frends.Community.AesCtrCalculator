using NUnit.Framework;
using System;

namespace Frends.Community.AesCtrCalculator.Tests
{
    [TestFixture]
    public class AesCtrCalculatorTasksTest
    {
        [Test]
        public void Calculate_Should_Work()
        {
            var result = AesCtrCalculatorTasks.CalculateAesCtr(new Input { Data = "1af1ae9ba7cfda4c84d6", Key = "110BFE1B1116085EB5611152E5244FF5", Iv = "1c1c1c1c1c1c1c1c1c1c1c1c1c1c1c1c" });
            Assert.AreEqual(result.Data, "A7837045760FDAD82C0D");
        }

        [Test]
        public void Calculate_Should_Throw_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AesCtrCalculatorTasks.CalculateAesCtr(new Input
            {
                Data = "1af1ae9ba7cfda4c84d6",
                Key = "10BFE1B1116085EB5611152E5244FF5",
                Iv = "1c1c1c1c1c1c1c1c1c1c1c1c1c1c1c1c"
            }));
        }

    }
}
