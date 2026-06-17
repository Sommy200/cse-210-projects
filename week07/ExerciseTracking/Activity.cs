namespace ExerciseTracker
{
    public abstract class Activity
    {
        private string _date;
        private int _minutes;

        public Activity(string date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        // Getters for the shared data
        public string GetDate()
        {
            return _date;
        }

        public int GetMinutes()
        {
            return _minutes;
        }

        // Abstract methods - each derived class must implement
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        // Summary method - uses the abstract methods above
        public virtual string GetSummary()
        {
            return $"{_date} {GetType().Name} ({_minutes} min) - " +
                   $"Distance {GetDistance():F1} miles, " +
                   $"Speed {GetSpeed():F1} mph, " +
                   $"Pace: {GetPace():F1} min per mile";
        }
    }
}