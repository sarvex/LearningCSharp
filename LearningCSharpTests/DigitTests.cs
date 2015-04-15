using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCSharp;
using Xunit;

namespace LearningCSharp.Tests
{
    public class DigitTests 
    {
        [Fact ()]
        public void ImplicitTest()
        {
            var digitFoo = new Digit(5);
            int foo = digitFoo;

            Assert.Equal(foo, 5);
        }

        [Fact ()]
        public void ExplicitTest()
        {
            int foo = 5;
            byte byteFoo = (byte)foo;

            int bar = 5;
            Digit digitBar = (Digit)bar;
            Assert.Equal (bar, 5);
        }
    }
}
