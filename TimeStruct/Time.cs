#pragma warning disable CA1815

namespace TimeStruct
{
    public readonly struct Time
    {
        private const int MinutesInHour = 60;
        private const int HourInDay = 24;
        
        public Time(int minutes)
            : this(0, minutes)
        {
        }

        public Time(int hours, int minutes = 0)
            : this()
        {
            this.Hours = Mod((hours * MinutesInHour + minutes) / (double) MinutesInHour, HourInDay);
            this.Minutes = Mod(minutes, MinutesInHour);
        }

        public int Hours { get; }

        public int Minutes { get; }

        public void Deconstruct(out int hours, out int minutes)
        {
            hours = this.Hours;
            minutes = this.Minutes;
        }

        public new string ToString() => $"{Hours:00}:{Minutes:00}";

        private static int Mod(double x, double y) => (int)((x % y + y) % y);
    }
}
