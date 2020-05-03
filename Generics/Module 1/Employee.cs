namespace Generics.Module_1
{
    public class Employee
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}