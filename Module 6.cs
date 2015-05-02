using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module6
{

    class MainClass
    {



        static void Main(string[] args)
        {


            // 1. Instantiating three student objects
            Student student1 = new Student("Geoff Anderson", "A010", "England", 20);
            Student student2 = new Student("Emily Sanchez", "B210", "Brazil", 19);
            Student student3 = new Student("Akshay Anand", "C302", "India", 18);

            // 2. Instantiating a Course object called Programming with C#
            Course course1 = new Course("Programming with C#", "CompSci", 12);

            // 3. Adding the three students to this Course object.
            course1.students[0] = student1;
            course1.students[1] = student2;
            course1.students[2] = student3;

            // 4. Instantiating at one Teacher object.
            Teacher teacher1 = new Teacher("Fred Ramos", "Mathematics", "Argentina", 40);

            // 5. Adding that Teacher object to the Course object
            course1.teachers[0] = teacher1;

            // 6. Instantiating a Degree object
            Degree degree1 = new Degree("Bachelor of Science", "CompSci");

            // 7. Adding the Course object to the Degree object.
            degree1.course = course1;

            // 8. Instantiating a UProgram object called Information Technology
            UProgram UProgram1 = new UProgram("Information Technology", "CompSci");

            // 9. Adding the Degree object to the UProgram object.
            UProgram1.degree = degree1;

            // 10. Using Console.WriteLine statements, to output the following information to the console window:

            // 1. The name of the program and the degree it contains
            Console.WriteLine("The {0} program contains the {1} degree", UProgram1.Name, UProgram1.degree.Name);

            // 2. The name of the course in the degree
            Console.WriteLine("The {0} degree contains the {1} course", degree1.Name, degree1.course.Name);

            // 3. The count of the number of students in the course.
            Console.WriteLine("The {0} course contains {1} students", course1.Name, Student.studentCount);
            //in the line above, could've also used course1.students.Count() instead of Student.studentCount


            Console.ReadLine();


        }
    }

    //Person base class

    abstract class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _country;
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

    }

    //inheriting common attributes from person base class
    class Student : Person  
    {
        

        private string _IDnumber;
        public string IDNumber
        {
            get { return _IDnumber; }
            set { _IDnumber = value; }
        }

        public void TakeTest()
        {
            Console.WriteLine("Taking test......");
        }
               


        public static int studentCount = 0;

        public Student(string name, string IDnumber, string country, int age)
        {
            this.Name = name;
            this.IDNumber = IDnumber;
            this.Country = country;
            this.Age = age;
            studentCount += 1;

        }
        
    }      
    
    //inheriting common attributes from person base class
    class Teacher : Person
    {
        

        private string _field;
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }

        public void GradeTest()
        {
            Console.WriteLine("Grading test....");
        }


        public Teacher(string name, string field, string country, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
            this.Field = field;
        }
    }

    class UProgram
    {

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _field;
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }

        private Degree _degree;
        public Degree degree
        {
            get { return _degree; }
            set { _degree = value; }
        }

        public UProgram(string name, string field)
        {
            this.Name = name;
            this.Field = field;
            
        }

        public UProgram(Degree degree)
        {            
            this.degree = degree;
        }
        
    }

    class Degree
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _field;
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }

        private Course _course;
        public Course course
        {
            get { return _course; }
            set { _course = value; }
        }

        public Degree(string name, string field)
        {
            this.Name = name;
            this.Field = field;
        }

        public Degree(Course course)
        {            
            this.course = course;
        }
    }

    class Course
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _field;
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }

        private int _length;
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        private Student[] studentArray = new Student[3];
        public Student[] students
        {
            get { return studentArray; }
            set { studentArray = value; }
        }

        private Teacher[] teacherArray = new Teacher[3];
        public Teacher[] teachers
        {
            get { return teacherArray; }
            set { teacherArray = value; }
        }


        public Course(string name, string field, int lengthInWeek)
        {
            this.Name = name;
            this.Field = field;
            this.Length = lengthInWeek;
        }
    }

    


}
