using NUnit.Framework;

namespace TimeStruct.Tests
{
    [TestFixture]
    public class TimeTests
    {
        [Test, TestCaseSource(typeof(TestCases),nameof(TestCases.TestCasesForToString))]
        public void ToStringTests(Time time, string presentation)
        {
            Assert.AreEqual(presentation, time.ToString());
        }

        [Test, TestCaseSource(typeof(TestCases),nameof(TestCases.TestCasesForMinutesProperty))]
        public void MinutesPropertyTests(Time time, int minutes)
        {
            Assert.AreEqual(minutes, time.Minutes);
        }
        
        [Test, TestCaseSource(typeof(TestCases),nameof(TestCases.TestCasesForHoursProperty))]
        public void HoursPropertyTests(Time time, int hour)
        {
            Assert.AreEqual(hour, time.Hours);
        }
        
        [Test, TestCaseSource(typeof(TestCases),nameof(TestCases.TestCasesForToCtor))]
        public void CtorTests(Time time, int hour, int minutes)
        {
            Assert.AreEqual(hour, time.Hours);
            Assert.AreEqual(minutes, time.Minutes);
        }
    }
}