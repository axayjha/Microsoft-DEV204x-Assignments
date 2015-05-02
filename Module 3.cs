using System;

namespace Module3Assignment
{

	class MainClass
	{


		public static void Main (string[] args)
		{
			header();

			//Calling Get functions from inside Main() as asked  by the assignment
			GetStudentInfo ();
			GetTeacherInfo ();
			GetDegreeInfo ();
			GetProgramInfo ();
			GetCourseInfo ();

			Console.WriteLine ("=============================================================\n");


			//NotImplementedException block

			try
			{
				ValidateBirthday();
			}
			catch (NotImplementedException err)
			{
				Console.WriteLine(err.Message);
			}

			//the incomplete function 'ValidateBirthday()'  is at the bottom-most

			footer ();

			Console.ReadLine ();
		}

		//Declaring function  to get information about the student
		public static void GetStudentInfo()
		{

			Console.WriteLine ("\nGetting Student's Info\n" +
				               "--------------------------");			         

			Console.Write ("\nEnter the student's full name: \n>");
			string name = Console.ReadLine ();


			Console.Write ("\nEnter the student's study field: \n>");
			string field  = Console.ReadLine ();

			Console.Write ("\nEnter grade scored in last semester-end exam: \n>");
			string grade = Console.ReadLine ();

			//Calling Print functions from inside Get function as asked by the assignment
			PrintStudentDetails (name, field, grade);
		}


		public static void PrintStudentDetails(string stu_name, string stu_field, string sem_endGrade)
		{
			Console.WriteLine ("\n\nStudent's Info:  \n" +
				               "------------------ \n");

			/* I've not used the code similar to what was shown in assignment instructions to 
			 * print the details
			 * I've used my own version of that code to print details with a fancier look! :)
			 * */

			Console.WriteLine ("   Name         : {0}", stu_name + "\n" +
				"   Field        : " + stu_field + "\n" +
				"   Sem-End Grade: " + sem_endGrade);
		
		}


		public static void GetTeacherInfo()
		{
			Console.WriteLine ("\n\nGetting Teahcer's Info\n" +
			                   "------------------------");

			Console.Write ("\nEnter the teacher's full name: \n>");
			string name = Console.ReadLine (); 
			//same variable names declared in GetStudentInfo() doesn't matter as these are local variables

			Console.Write ("\nEnter the teacher's field of expertise: \n>");
			string field  = Console.ReadLine ();

			Console.Write ("\nEnter teacher's age: \n>");
			string age = Console.ReadLine ();

			PrintTeacherDetails (name, field, age);

		}

		public static void PrintTeacherDetails(string tea_name, string tea_field, string tea_age)
		{
			Console.WriteLine ("\n\nTeacher's Info:  \n" +
				               "------------------ \n");
			Console.WriteLine ("   Name         : {0}", tea_name + "\n" +
				"   Field        : " + tea_field + "\n" +
				"   Age          : " + tea_age);
		}

		//Similar 'Get' and 'Print' functions below

		public static void GetDegreeInfo()
		{
			Console.Write("\n\nGetting Degree Info\n" +
				          "-----------------------");

			Console.Write ("\nEnter the name of degree: \n>");
			string degName = Console.ReadLine();

			Console.Write ("\nEnter the field of the degree:  \n>");
			string degField = Console.ReadLine();

			Console.Write ("\nEnter the credits required for the degree: \n>");
			string degCredits = Console.ReadLine();

			PrintDegreeInfo (degName, degField, degCredits);
		}

		public static void PrintDegreeInfo(string deg_name, string deg_field, string deg_credits)
		{
			Console.WriteLine ("\n\nInformation about the Degree: \n" +
				               "-------------------------------");
			Console.WriteLine ("   Name             : " + deg_name + "\n" +
				               "   Field            : " + deg_field + "\n" +
			                   "   Credits required : " + deg_credits + "\n");
		}           



		public static void GetProgramInfo()
		{
			Console.WriteLine ("\n\nGetting Program Info\n" +
				               "-----------------------");

			Console.Write ("\nEnter the name of the program: \n>");
			string progName = Console.ReadLine();

			Console.Write ("\nEnter the program field: \n>");
			string progField = Console.ReadLine();

			Console.Write ("\nEnter the names of degrees available(followed by ',' as in 'BS, MS'): \n>");
			string progDegrees = Console.ReadLine();

			Console.Write ("\nWho is the department head? : \n>");
			string progDepHead = Console.ReadLine();

			PrintProgramInfo (progName, progField, progDegrees, progDepHead);

		}

		public static void PrintProgramInfo(string prog_name, string prog_field, string prog_degrees,
			string prog_depHead )
		{
			Console.WriteLine ("\n\nInformation about University programme: \n" +
				"------------------------------------------");
			Console.WriteLine ("   Name              : " + prog_name + "\n" +
				"   Field             : " + prog_field + "\n" +
				"   Degrees available : " + prog_degrees + "\n" +
				"   Department head   : " + prog_depHead + "\n");
		}


		public static void GetCourseInfo()
		{
			Console.WriteLine ("\n\nGetting Course Info\n" +
				               "--------------------------");

			Console.Write ("\nEnter the name of the course: \n>");
			string courseName = Console.ReadLine();

			Console.Write ("\nEnter the field of the course: \n>");
			string courseField = Console.ReadLine();

			Console.Write ("\nHow many weeks long is the course? : \n>");
			string courseLenght = Console.ReadLine();

			Console.Write("\nEnter the credits required to take the course: \n>");
			string courseCredits = Console.ReadLine();

			PrintCourseInfo (courseName, courseField, courseLenght, courseCredits);
		}

		public static void PrintCourseInfo(string course_name, string course_field,
			string course_length, string course_credits)
		{
			Console.WriteLine ("\n\nInformation about optional extra course: \n" +
				"-------------------------------------------");
			Console.WriteLine ("   Name    : " +course_name + "\n" +
				"   Field   : " + course_field + "\n" +
				"   Length  : " + course_length + "\n" +
				"   Credits : " + course_credits + "\n");
		}

		//-----------------------------------------------------------------------------------

		//So finally, here is the incomplete ValidateBirthday() function

		static void ValidateBirthday()
		{
			// Incomplete and unimplemented function 
			throw new NotImplementedException();
		}

		//-------------------------------------------------------------------------------------

		public static void header()
		{
			Console.WriteLine("DEV 204x Module 3 Assignment \n" +
				              "------------------------------- \n");
		}

		public static void footer()
		{
			Console.WriteLine("\n\nPress <ENTER> to exit...");
		}






	}
}
