namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;
        public SimpleGoal(string name, int points) : base(name, points)
        {
            _isComplete = false;
        }

        
      
        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override string GetStatus()
        {
            if (_isComplete)
            {
                return "[X]";
            }
            return"[]";
        }
        
            
            
        

        
        
    }
}