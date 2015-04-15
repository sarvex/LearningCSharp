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
            var pointOne = new Point(1, 5);
            var pointTwo = new Point(2, 6);

            var pointThree = pointOne + pointTwo;
            Assert.Equal(pointThree, new Point(3, 11));

            var pointFour = pointOne + 1;
            Assert.Equal(pointFour, new Point(2, 6));
        }

        [Fact ()]
        public void SubtractionTest () {
            var pointOne = new Point (1, 5);
            var pointTwo = new Point (2, 6);

            var pointThree = pointOne - pointTwo;
            Assert.Equal (pointThree, new Point (-1, -1));

            var pointFour = pointOne - 1;
            Assert.Equal (pointFour, new Point (0, 4));
        }

        [Fact ()]
        public void EqualityTest () 
        {
            var pointOne = new Point (1, 5);
            var pointTwo = new Point (2, 6);

            var pointThree = pointOne - pointTwo;
            Assert.True (pointThree == new Point (-1, -1));

            var pointFour = pointOne - 1;
            Assert.True (pointFour == new Point (0, 4));
        }

        [Fact ()]
        public void InEqualityTest () {
            var pointOne = new Point (1, 5);
            var pointTwo = new Point (2, 6);

            var pointThree = pointOne + pointTwo;
            Assert.True (pointThree != new Point (1, 5));

            var pointFour = pointOne + 1;
            Assert.True (pointFour != new Point (1, 5));
        }

        [Fact ()]
        public void EqualsMethodTest () {
            var pointOne = new Point (1, 5);
            var pointTwo = new Point (2, 6);

            var pointThree = pointOne + pointTwo;
            Assert.True (pointThree.Equals(new Point(3, 11)));
            Assert.False(pointThree.Equals(null));

            var pointFour = pointOne + 1;
            Assert.True (pointFour.Equals(pointTwo));
            Assert.False(pointFour.Equals(null));
        }
    }
}
