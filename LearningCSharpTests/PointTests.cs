using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCSharp;
using Xunit;

namespace LearningCSharp.Tests
{
    public class PointTests 
    {
        [Fact ()]
        public void AdditionTest()
        {
            var p1 = new Point(1, 5);
            var p2 = new Point(2, 6);

            var p3 = p1 + p2;
            Assert.Equal(p3, new Point(3, 11));

            var p4 = p1 + 1;
            Assert.Equal(p4, new Point(2, 6));
        }

        [Fact ()]
        public void SubtractionTest () {
            var p1 = new Point (1, 5);
            var p2 = new Point (2, 6);

            var p3 = p1 - p2;
            Assert.Equal (p3, new Point (-1, -1));

            var p4 = p1 - 1;
            Assert.Equal (p4, new Point (0, 4));
        }
    }
}
