﻿using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        // setUp
        // TearDown

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
//        [Ignore("Because I wanted to!")]
        public void Add_Whencalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a,int b,int expectedResult)
        {

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void GetOddNumber_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

 //           Assert.That(result, Is.Not.Empty);
           
 //           Assert.That(result.Count(), Is.Not.Equals(3));
           
 //           Assert.That(result, Does.Contain(1));
 //           Assert.That(result, Does.Contain(3));
 //           Assert.That(result, Does.Contain(5));

        }
    }
}