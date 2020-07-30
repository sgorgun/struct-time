#nullable enable
using System;

namespace TimeStruct
{
    // Implement immutable struct `Time` according following requires:
    // 
    public readonly struct Time : IEquatable<Time>, IComparable<Time>, IComparable
    {
        private const int minutesInHour = 60;
        private const int hourInDay = 24;

        public Time(int minutes) : this(0, minutes)
        {
        }

        public Time(int hours, int minutes = 0)
        {
            Hours = Mod((hours * minutesInHour + minutes) / (double) minutesInHour, hourInDay);
            Minutes = Mod(minutes, minutesInHour);
        }

        // The hour value
        public int Hours { get; }
        // The minute value

        public int Minutes { get; }

        public static Time operator +(Time time, int minutesToAdd)
        {
            return Add(time, minutesToAdd);
        }

        public static Time Add(Time time, int minutesToAdd)
        {
            return new Time(time.Hours, time.Minutes + minutesToAdd);
        }

        public static Time operator -(Time time, int minutesToSubtract)
        {
            return Subtract(time, minutesToSubtract);
        }

        public static Time Subtract(Time time, int minutesToSubtract)
        {
            return new Time(time.Hours, time.Minutes - minutesToSubtract);
        }

        public static bool operator ==(Time lhs, Time rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Time lhs, Time rhs)
        {
            return !(lhs == rhs);
        }

        public override string ToString() => $"{Hours:00}:{Minutes:00}";

        int IComparable.CompareTo(object? obj)
        {
            if (obj is Time clock)
            {
                return this.CompareTo(clock);
            }

            throw new ArgumentException("Object is not a Time.");
        }

        private static int Mod(double x, double y) => (int) ((x % y + y) % y);

        //TODO: Implement the generic Equals method with the Time class as the Type parameter.
        //The time equality depends on the comparison of the underlying integer values of hour and minutes.

        public bool Equals(Time other) => Hours == other.Hours && Minutes == other.Minutes;

        //TODO: Implement the generic CompareTo method with the Time class as the Type parameter.
        //The time comparison depends on the comparison of the underlying integer values of hour and minutes.
        public int CompareTo(Time other)
        {
            if (this == other)
            {
                return 0;
            }

            if (this.Hours > other.Hours)
            {
                return 1;
            }

            if (this.Hours < other.Hours)
            {
                return -1;
            }

            return this.Minutes > other.Minutes ? 1 : -1;
        }

        // Define the is greater than operator.
        public static bool operator >(Time lhs, Time rhs)
        {
            return lhs.CompareTo(rhs) == 1;
        }

        // Define the is less than operator.
        public static bool operator <(Time lhs, Time rhs)
        {
            return lhs.CompareTo(rhs) == -1;
        }

        // Define the is greater than or equal to operator.
        public static bool operator >=(Time lhs, Time rhs)
        {
            return lhs.CompareTo(rhs) >= 0;
        }

        // Define the is less than or equal to operator.
        public static bool operator <=(Time lhs, Time rhs)
        {
            return lhs.CompareTo(rhs) <= 0;
        }

        //TODO: Override virtual method of Object class: method returns true if the hours and minutes property of two Time objects is identical; otherwise, it returns false.
        public override bool Equals(object? obj) => obj is Time other && Equals(other);

        public override int GetHashCode() => HashCode.Combine(Hours, Minutes);
    }
}