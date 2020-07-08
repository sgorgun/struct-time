using NUnit.Framework;

namespace TimeStruct.Tests
{
    [TestFixture]
    public class TimeTests
    {
        [Test, TestCaseSource(typeof(TestCasesSource),nameof(TestCasesSource.TestCasesForToString))]
        public void ToStringTests(Time time, string str)
        {
            Assert.AreEqual(str, time.ToString());
        }

        [Test, TestCaseSource(typeof(TestCasesSource),nameof(TestCasesSource.TestCasesForMinutesProperty))]
        public void MinutesPropertyTests(Time time, int minutes)
        {
            Assert.AreEqual(minutes, time.Minutes);
        }
        
        [Test, TestCaseSource(typeof(TestCasesSource),nameof(TestCasesSource.TestCasesForHoursProperty))]
        public void HoursPropertyTests(Time time, int hour)
        {
            Assert.AreEqual(hour, time.Hours);
        }
        
        [Test, TestCaseSource(typeof(TestCasesSource),nameof(TestCasesSource.TestCasesForTwoParametersCtor))]
        public void CtorWithTwoParametersTests(Time time, int hour, int minutes)
        {
            Assert.AreEqual(hour, time.Hours);
            Assert.AreEqual(minutes, time.Minutes);
        }
        
        [Test, TestCaseSource(typeof(TestCasesSource),nameof(TestCasesSource.TestCasesForOneParameterCtor))]
        public void CtorWithOneParameterTests(Time time, int hour, int minutes)
        {
            Assert.AreEqual(hour, time.Hours);
            Assert.AreEqual(minutes, time.Minutes);
        }
    }
}