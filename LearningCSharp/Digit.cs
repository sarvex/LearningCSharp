using System;

namespace LearningCSharp
{
    public struct Digit
    {
        public byte Value { get; private set; }
 
        public Digit(byte value) : this()
        {
            if (value > 9) throw new ArgumentException();

            Value = value;
        }

        public static implicit operator int(Digit digit)
        {
            return digit.Value;
        }

        public static explicit operator Digit(int value) 
        {
            return new Digit((byte)value);
        }
    }
}