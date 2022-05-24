using Services.Implementations;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBetween25MayAnd27MayAreThreeDays()
        {
            var workingDaysCalculator = new WorkingDaysCalculator();
            var startDate = new DateTime(2022, 5, 25);
            var endDate = new DateTime(2022, 5, 27);

            var result = workingDaysCalculator.GetWorkingDays(startDate, endDate);

            Assert.Equal(3, result);
        }

        [Fact]
        public void TestBetween25MayAnd25MayIsOneDay()
        {
            var workingDaysCalculator = new WorkingDaysCalculator();
            var startDate = new DateTime(2022, 5, 25);
            var endDate = new DateTime(2022, 5, 25);

            var result = workingDaysCalculator.GetWorkingDays(startDate, endDate);

            Assert.Equal(1, result);
        }

        [Fact]
        public void TestBetween25MayAnd26MayAreTwoDays()
        {
            var workingDaysCalculator = new WorkingDaysCalculator();
            var startDate = new DateTime(2022, 5, 25);
            var endDate = new DateTime(2022, 5, 26);

            var result = workingDaysCalculator.GetWorkingDays(startDate, endDate);

            Assert.Equal(2, result);
        }

        [Fact]
        public void TestBetween24MayAnd31MayAreSixDays()
        {
            var workingDaysCalculator = new WorkingDaysCalculator();
            var startDate = new DateTime(2022, 5, 24);
            var endDate = new DateTime(2022, 5, 31);

            var result = workingDaysCalculator.GetWorkingDays(startDate, endDate);

            Assert.Equal(6, result);
        }

        [Fact]
        public void TestBetween6JuneAnd18JuneAreTenDays()
        {
            var workingDaysCalculator = new WorkingDaysCalculator();
            var startDate = new DateTime(2022, 6, 6);
            var endDate = new DateTime(2022, 6, 18);

            var result = workingDaysCalculator.GetWorkingDays(startDate, endDate);

            Assert.Equal(10, result);
        }
    }
}