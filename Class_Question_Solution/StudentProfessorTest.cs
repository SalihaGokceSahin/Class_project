using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Question_Solution
{
    public class StudentProfessorTest
    {
        public static void Main()
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(10);
            student.Greet();
            student.ShowAge();
            student.Study();

            Teacher teacher = new Teacher();
            teacher.SetAge(50);
            teacher.Greet();
            teacher.Explain();

            Console.ReadKey();
        }
    }
}
