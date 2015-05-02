using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{


    class MainClass
    {

        //Creating the structs


        struct Student
        {
            public string fullName;
            public int gradePoint;
            public DateTime birthDate;

            //the contructor
            public Student(string _fullName, int _gradePoint, string _birthday)
            {
                this.fullName = _fullName;
                this.gradePoint = _gradePoint;
                this.birthDate = DateTime.Parse(_birthday);

            }

        }

        struct Teacher
        {
            public string fullName;
            public int age;
            public string field;

            public Teacher(string _fullName, int _age, string _field)
            {
                this.fullName = _fullName;
                this.age = _age;
                this.field = _field;
            }
        }


        struct Program
        {
            public string officialName;
            public string field;
            public int lenghtInWeeks;
            //string UG, PG;

            public Program(string _officialName, string _field, int _lengthInWeeks)
            {
                this.officialName =  _officialName;
                this.field = _field;
                this.lenghtInWeeks = _lengthInWeeks;
            }

        }

        struct Course
        {
            public string officialName;
            public string degreesOfferred;
            public float creditsReq;

            public Course(string _officialName, string _degreesOfferred, int _creditsReq)
            {
                this.officialName =  _officialName;
                this.degreesOfferred = _degreesOfferred;
                this.creditsReq = _creditsReq;
            }

        }

       

        struct courseDeg
        {
            public string UnderGrad, PostGrad;

            //the constructor
            public courseDeg(string UG, string PG)
            {
                this.UnderGrad = UG;
                this.PostGrad = PG;
            }

            public override string ToString()
            {

                return base.ToString();
            }


        }


        static void Main(string[] args)
        {
            Console.Title = "DEV 204x: Module 4 Assignment";


            Console.WriteLine("DEV 204x Module 4 Assignment\n" +
                              "================================\n");

            

            //Creating struct objects and
            //asking for values for (atleast) one attribute from each struct (Asking for all of them would've been a mess
            //for me as well as the peer assesser. So I've left many variables in the structs unassigned intentionally.

            Student newStudent1 = new Student(); //I didn't use custom costructor here,
            // but I have (to show that I can) in another part of this assignment below
            
            Console.Write("\nEnter student's full name: \n>");
            newStudent1.fullName = Console.ReadLine();

            //this block makes sure that the birthdate is entered in proper format
        getBday:
            Console.Write("\nEnter students birthday (in MM/DD/YYYY format): \n>");
            string birthday = Console.ReadLine();

            try
            {
                newStudent1.birthDate = DateTime.Parse(birthday);
            }

            catch
            {
                Console.WriteLine("Enter a valid date! Try again. \n");
                goto getBday;
            }


            //As we're using structs, implementing methods didn't seem helpful here, so I've avoided implementing any


            Console.WriteLine("\nStudent's Info: \n" +
                              "----------------------\n" +
                              "\tName     : " + newStudent1.fullName + "\n" +
                              "\tBirthday : " + newStudent1.birthDate.ToShortDateString() + "\n");

            //Samiliarly taking few more inputs and assigning to obect attributes

            Teacher newTeacher1 = new Teacher();
            Console.Write("\nEnter teacher's name: \n>");
            newTeacher1.fullName = Console.ReadLine();

            Program newProgram1 = new Program();
            Console.Write("\nEnter program's field: \n>");
            newProgram1.field = Console.ReadLine();

            courseDeg CompSc = new courseDeg();
            Console.Write("\nEnter the UG degrees available for the course : \n>");
            CompSc.UnderGrad = Console.ReadLine();

            Course newCourse1 = new Course();

        getCredit:
            Console.Write("\nEnter the credits required to take the course: \n>");
            string courseCredits = Console.ReadLine();

            //this block handles the exception if any invalid input(for example, any letter) is entered
            try
            {
                newCourse1.creditsReq = float.Parse(courseCredits);
            }
            catch
            {
                Console.WriteLine("Please enter a valid number!Try again.");
                goto getCredit;
            }
            //finished with taking inputs

            Console.WriteLine("\nOutput from the different struct attributes: \n" +
                              "-------------------------------------------------\n");

            Console.WriteLine("\nTeacher's name      : " + newTeacher1.fullName + "\n" +
                                "Program's field     : " + newProgram1.field + "\n" +
                                "Credits required    : " + newCourse1.creditsReq + "\n" +
                                "UG degrees offerred : " + CompSc.UnderGrad + "\n");


            #region Array holding 5 Student structs

            //Declaring 5 Student structs 

            //As per the assignment instructions, assigning values for atleast one of the structs in the array
            //I've hard-coded the values for the following (although I could've asked for user inputs)
            //otherwise peer assesser would've unnecessarily many inputs to enter (which already is more than enough)

            Student student1 = new Student("John Clarke", 8, "09/25/1997");
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();
            Student student5 = new Student();

            //Creating the array containing 5 Student structs
            Student[] studentArray = { student1, student2, student3, student4, student5 };

            
            #endregion


            Console.WriteLine("\n\n*Output from the struct array block* \n\n");
            Console.WriteLine("Student Info : \n" +
                              "----------------\n\n" +
                              "\tName        : " + studentArray[0].fullName + "\n" +
                              "\tBirthday    : " + studentArray[0].birthDate.ToShortDateString() + "\n" +
                              "\tGrade Point : " + studentArray[0].gradePoint);


            Console.WriteLine("\n\nPress <ENTER> to exit...");
            Console.ReadLine();
        }
    }
}
