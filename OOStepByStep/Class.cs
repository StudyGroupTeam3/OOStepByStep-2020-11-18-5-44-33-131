using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Class
    {
        private readonly string classInfo;
        private Teacher teacher;
        private List<Student> students = new List<Student>();
        public Class(Teacher teacher, string classInfo)
        {
            teacher.ClassNumber = classInfo;
            this.teacher = teacher;
            this.classInfo = classInfo;
        }

        public string AddNewStudent(Student newStudent)
        {
            newStudent.ClassNumber = classInfo;
            students.Add(newStudent);
            return TeacherWelcome(newStudent) + StudentsWelcome(newStudent);
        }

        public string IntroduceStudent(Student student)
        {
            if (student.ClassNumber == classInfo)
            {
                return $"{student.SelfIntroduce().TrimEnd('.')} of {classInfo}.";
            }
            else
            {
                return "I am not from this class";
            }
        }

        public string IntroduceTeacher(Teacher teacher)
        {
            if (teacher.ClassNumber == classInfo)
            {
                return $"{teacher.SelfIntroduce().TrimEnd('.')} of {classInfo}.";
            }
            else
            {
                return "I am not from this class";
            }
        }

        private string StudentsWelcome(Student newStudent)
        {
            string welcome = string.Empty;
            if (students.Count > 1)
            {
                for (int index = 0; index < students.Count - 1; index++)
                {
                    welcome += $"{students[index].SelfIntroduce().TrimEnd('.')} of {classInfo}. Welcome {newStudent.Name} join {classInfo}.\n";
                }
            }

            return welcome;
        }

        private string TeacherWelcome(Student newStudent)
        {
            return $"{teacher.SelfIntroduce().TrimEnd('.')} of {classInfo}. Welcome {newStudent.Name} join {classInfo}.\n";
        }
    }
}
