using System.Runtime;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;

public ChecklistGoal(string name, int points, int target) : base(name, points)
        {
            _amountCompleted = 0;
            _target = target;
        }

        public override void RecordEvent()
        {
            _amountCompleted = _amountCompleted + 1;
        }

        public override string GetStatus()
        {
            return $"Completed{_amountCompleted}/{_target} times";
        }
    }
}