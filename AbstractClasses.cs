namespace рпм2
{
    /// <summary>
    /// Класс человека, котоырй содержит имя
    /// </summary>
    public abstract class Person
    {
        string Name;
        
        public Person(string name)
        {
            this.Name = name;
        }
        
        public string GetName()
        {
            return Name;
        }
    }
    
    /// <summary>
    /// Класс персонала (HR, Teacher)
    /// </summary>
    public class Personal : Person
    {
        string Position;
        
        public Personal(string name, string dolj) : base(name)
        {
            this.Position = dolj;
        }
        
        public string GetJob()
        {
            return Position;
        }
    }
}
