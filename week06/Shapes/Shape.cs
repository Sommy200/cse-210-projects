namespace Shapes
{
    public class Shape
    {
        private string _color;

        public Shape(string color)
        {
            _color = color;
        }

        public string GetColor() => _color;
        
        public void SetColor(string color) => _color = color;

        // 'virtual' allows derived classes to override this
        public virtual double GetArea()
        {
            return 0;
        }
    }
}