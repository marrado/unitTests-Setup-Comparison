﻿using System;
using Xunit;

namespace xUnit.Comparison.InitializeOnce
{
    [Collection("TestBase collection")]
    public class TestFixture1
    {
        private SharedContext _testBase;

        public TestFixture1(SharedContext testBase)
        {
            _testBase = testBase;
        }

        [Fact]
        public void Test1()
        {
            //Arrange/Act/Assert
        }

        [Fact]
        public void Test2()
        {
            //Arrange/Act/Assert
        }

        [Theory]
        [InlineData("param")]
        [InlineData("param2")]
        public void TestWithCases(string param)
        {
            //Arrange/Act/Assert
        }
    }
}