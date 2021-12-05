// See https://aka.ms/new-console-template for more information

using System;

namespace less10tsk2
{
    public class less10
    {
        public static void Main()
        {
            Teacher teacher = new Teacher();
            teacher.Explain();

            Student student = new Student();
            student.Study();
            student.SetAge(22);
            student.ShowAge();
        }
    }
}