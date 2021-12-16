namespace рпм2
{
    /// <summary>
    /// Кадровик
    /// </summary>
    public class HR : Personal, Create
    {
        public HR(string name) : base(name, "кадровик")
        {

        }
        
        public Student CreateStudent(string StudentName, string group)
        {
            return new Student(StudentName, group);
        }
        
        public Teacher CreateTeacher(string TeacherName, TeacherPosition position)
        {
            return new Teacher(TeacherName, position);
        }
    }
}
