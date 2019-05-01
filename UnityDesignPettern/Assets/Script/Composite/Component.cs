namespace Composite
{
    public class Component
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Component(string Name)
        {
            this.Name = Name;
        }
    }
}
