using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp {
    public struct Point {
        public int X { get; set; }
        public int Y { get; set; }

        public Point (int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point point1, Point point2) {
            return new Point(point1.X + point2.X, point1.Y + point2.Y);
        }

        public static Point operator + (Point point, int value)
        {
            return new Point(point.X + value, point.Y + value);
        }

        public static Point operator - (Point point1, Point point2) {
            return new Point (point1.X - point2.X, point1.Y - point2.Y);
        }

        public static Point operator - (Point point, int value) {
            return new Point (point.X - value, point.Y - value);
        }

        public static bool operator ==(Point point1, Point point2)
        {
            return point1.X == point2.X && point1.Y == point2.Y;
        }

        public static bool operator != (Point point1, Point point2) {
            return point1.X != point2.X && point1.Y != point2.Y;
        }

        public override int GetHashCode()
        {
            return X ^ Y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null && !(obj is Point) )
            {
                return false;
            }

            var point = (Point) obj;
            return point == this;
        }

        public bool Equals(Point point)
        {
            return this == point;
        }
    }
}
