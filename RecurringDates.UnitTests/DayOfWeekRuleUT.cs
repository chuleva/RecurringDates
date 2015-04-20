﻿using System;
using FluentAssertions;
using NUnit.Framework;

namespace RecurringDates.UnitTests
{
    [TestFixture]
    public class DayOfWeekRuleUT<T> : ProjectedRuleTestFixture<T> where T : IRuleProjection, new()
    {
        [Test]
        public void Day_ShouldMatch_Monday()
        {
            var rule = new DayOfWeekRule(DayOfWeek.Monday);
            var date = new DateTime(2015, 3, 9);
            Project(rule).IsMatch(date).Should().BeTrue();
        }

        [Test]
        public void Day_WithFluentSyntax_ShouldMatch_Monday()
        {
            var rule = DayOfWeek.Monday.EveryWeek();
            var date = new DateTime(2015, 3, 9);

            Project(rule).IsMatch(date).Should().BeTrue();
        }

    }
}