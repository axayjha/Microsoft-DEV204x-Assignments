using System;
using System.Collections; //required for ArrayList and other collection objects
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module7
{

    class MainClass
    {



        static void Main(string[] args)
        {

            /*
            * This code is built upon module 6 assignmet. So some leftovers exist: some extra classes            
            * and console.writeline statements that are irrelevant to the current assignment. I've put 
            * comments above each modification to highlight the tasks specific to this assignment.
            */


            // Instantiating three student objects
            Student student1 = new Student("Geoff Anderson", "A010", "England", 20);
            Student student2 = new Student("Emily Sanchez", "B210", "Brazil", 19);
            Student student3 = new Student("Akshay Anand", "C302", "India", 18);

            // Instantiating a Course object called Programming with C#
            Course course1 = new Course("Programming with C#", "CompSci", 12);

            // Adding the ArrayList (instead of a student array) of three students to this Course object.
            course1.students.Add(student1);
            course1.students.Add(student2);
            course1.students.Add(student3);

            // Adding 5 grades to the the Stack in the Student object
            student1.Grades.Push("Sem 1: 9");
            student1.Grades.Push("Sem 2: 8");
            student1.Grades.Push("Sem 3: 7");
            student1.Grades.Push("Sem 4: 8");
            student1.Grades.Push("Sem 5: 9.5");

            // Calling the ListStudents() method from Main()
            course1.ListStudents();

            // (Optional) Calling GetGrades() method to get the 5 grades from the stack of a student object
            student1.GetGrades();



            // The rest portion of this Main() contains parts of previous assignment; irrelevant to this assignment.

            // Instantiating at least one Teacher object.
            Teacher teacher1 = new Teacher("Fred Ramos", "Mathematics", "Argentina", 40);

            // Adding that Teacher object to the Course object
            course1.teachers.Add(teacher1);

            // Instantiating a Degree object
            Degree degree1 = new Degree("Bachelor of Science", "CompSci");

            // Adding the Course object to the Degree object.
            degree1.course = course1;

            // Instantiating a UProgram object called Information Technology
            UProgram UProgram1 = new UProgram("Information Technology", "CompSci");

            // Adding the Degree object to the UProgram object.
            UProgram1.degree = degree1;

            // Using Console.WriteLine statements, to output the following information to the console window:

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


        //Creating the Grades stack
        private Stack grades = new Stack();
        public Stack Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        // Implemented this method just for fun. Not asked in the assignment.
        public void GetGrades()
        {
            Console.WriteLine("Grades for {0} : \n", this.Name);
            foreach (object obj in this.Grades)
            {
                Console.WriteLine("\t" + (obj.ToString()) + "\n");
            }

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


        //Student Array replaced with ArrayList
        private ArrayList studentList = new ArrayList();
        public ArrayList students
        {
            get { return studentList; }
            set { studentList = value; }
        }

        // The ListStudents() method with the foreach loop
        // The object inside the foreach loop has been explicitly type-casted to  Student type as asked.

        public void ListStudents()
        {
            Console.WriteLine("List of students in the course '{0}' \n", this.Name);
            foreach (object obj in this.students)
            {
                Console.WriteLine("\t" + (((Student)obj).Name.ToString()) + "\n");
            }
        }

        private ArrayList teacherList = new ArrayList();
        public ArrayList teachers
        {
            get { return teacherList; }
            set { teacherList = value; }
        }



        public Course(string name, string field, int lengthInWeek)
        {
            this.Name = name;
            this.Field = field;
            this.Length = lengthInWeek;
        }
    }

    /*---------------------------------------------------
    *The classes below are same as in Module 6 Assignment
    *No changes to them
    *----------------------------------------------------*/


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






}
