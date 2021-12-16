namespace рпм2
{
    public class Student : Person, SessionFail
    {
        string group;
        
        public Student(string Name, string Grup) : base(Name)
        {
            this.group = Grup;
        }
        
        public string GetGroup()
        {
            return group;
        }
        
        public string Failed()
        {
            return "заявление на отчисление";
        }
    }
}
