using System;

namespace рпм2
{
    class Program
    {
        static void Main(string[] args)
        {
            HR one = new HR("К.Е.В.");
            Console.WriteLine(one.GetName());
            Console.WriteLine(one.GetJob() + "\n");
            
            Student four = one.CreateStudent("Н.З.Ш.", "3-1п9");
            Console.WriteLine(four.GetName());
            Console.WriteLine(four.GetGroup() + "\n");
            
            Teacher five = one.CreateTeacher("Р.О.Г.", TeacherPosition.Assistant);
            Console.WriteLine(five.GetName());
            Console.WriteLine(five.GetJob() + "\n");
            
            Teacher two = new Teacher("А.Х.Г.", TeacherPosition.StLecturer);
            Console.WriteLine(two.GetName());
            Console.WriteLine(two.GetJob());
            Console.WriteLine(two.GiveLectures() + "\n");
        }
    }
}