namespace personStudentTeacher_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();
            
            Student student = new Student();
            student.SetAge(18);
            student.Greet();
            student.ShowAge();
            student.Study();

            Teacher teacher= new Teacher();
            teacher.SetAge(38);
            teacher.Greet();
            teacher.Explain();
        }
    }
}