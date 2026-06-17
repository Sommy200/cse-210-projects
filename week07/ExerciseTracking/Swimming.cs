namespace ExerciseTracker
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(string date, int minutes, int laps)
            : base(date, minutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            // Distance (miles) = laps * 50 / 1000 * 0.62
            // 50 meters per lap, 1000 meters per km, 0.62 miles per km
            return _laps * 50.0 / 1000 * 0.62;
        }

        public override double GetSpeed()
        {
            // Speed = (distance / minutes) * 60
            return (GetDistance() / GetMinutes()) * 60;
        }

        public override double GetPace()
        {
            // Pace = minutes / distance
            return GetMinutes() / GetDistance();
        }
    }
}