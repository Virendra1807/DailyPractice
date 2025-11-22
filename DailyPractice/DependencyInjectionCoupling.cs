using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{

    public interface IEducationalInstitution
    {
        void Teach();
    }

    public class College: IEducationalInstitution
    {
        public void Teach()
        {
            Console.WriteLine("Teaching students in College");
        }
    }

    public class School: IEducationalInstitution
    {
        public void Teach()
        {
            Console.WriteLine("Teaching students in School");
        }
    }
    public class Class : IEducationalInstitution
    {
        public void Teach()
        {
            Console.WriteLine("Teaching students in Class");
        }
    }
    public class Student
    {
        private IEducationalInstitution _college;
        private IEducationalInstitution _school;
        // Constructor Injection
        public Student(College college)
        {
            _college = college;
        }

        //Property Injections 
        public School school
        {
            set { _school = value; }
        }

        public void Study(IEducationalInstitution _class)
        {
            _college.Teach();// Constructor Injection
            _school.Teach();// Property Injection
            _class.Teach();// Method Injection-
        }


    }

}
