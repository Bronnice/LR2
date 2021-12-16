namespace рпм2
{

    public enum TeacherPosition
    {
        Assistant = 0,
        StLecturer = 1
    }

    /// <summary>
    /// Преподаватель
    /// </summary>
    public class Teacher : Personal, Lecture
    {
        static string[] positions = new string[] { "Ассистент", "Старший преподаватель" };
        
        public Teacher(string Name, TeacherPosition position) : base(Name, positions[(int)position])
        {

        }
        
        public string GiveLectures()
        {
            return "проводит лекции";
        }
    }
}
