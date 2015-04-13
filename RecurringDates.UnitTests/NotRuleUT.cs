using System;
using FluentAssertions;
using NUnit.Framework;

namespace RecurringDates.UnitTests
{
    [TestFixture]
    public class NotRuleUT
    {
        [TestCase(2015, 4, 12, true)]
        [TestCase(2015, 4, 13, false)]
        [TestCase(2015, 4, 14, true)]
        [TestCase(2015, 4, 15, true)]
        [TestCase(2015, 4, 16, true)]
        [TestCase(2015, 4, 17, true)]
        [TestCase(2015, 4, 18, true)]
        public void Day_ShouldNotMatch_Monday(int year, int month, int day, bool expected)
        {
            var rule = new NotRule
            {
                ReferencedRule = new DayOfWeekRule()
                {
                    DayOfWeek = DayOfWeek.Monday
                }
            };

            rule.IsMatch(new DateTime(year, month, day))
                .Should().Be(expected);

        }
    }
}