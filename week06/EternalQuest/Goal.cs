namespace EternalQuest
{
    public abstract class Goal
    {
        private string _name;
        private int _points;

        public Goal(string name, int points)
        {
            _name = name;
            
            _points = points;
        }
        public string GetName() => _name;

        public int GetPoints() => _points;

        // childrens compulsory version
        public abstract void RecordEvent();

        // children optional own version
        public virtual string GetStatus() => "[]";
        
        
            
        

        
        

    }
}