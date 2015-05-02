using System;

namespace Module1Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Declaring variables to store student's info

			string stu_firstName, stu_lastName, stuAdd_ln1;
			string stuAdd_ln2, stu_city, stu_state, stu_ZIP, stu_country ; 
			DateTime stu_bdate;


			//Declaring variables to store  professor's info

			string pro_firstName, pro_lastName;
			string pro_country, pro_field;
			int pro_age;

			//Declaring variables to store info about the degree
			string deg_name, deg_field;
			float deg_credits;

			//Declaring variables to store info about the university programme
			string progName, progField, progDegrees, progDepHead;

			//Declaring variables to store info about a course of my programme
			string courseName, courseCredits, courseField, courseLength;




		

			//Assigning values to the variables for student's info
			stu_firstName = "Akshay";
			stu_lastName = "Anand";
			stuAdd_ln1 = "33 Smith St.";
			stuAdd_ln2 = "Durham Ave";
			stu_city = "Metuchen";
			stu_state = "NJ";
			stu_ZIP = "08840";
			//I didn't declare ZIP as an 'int' as it'd have eliminated the first '0' from right
			stu_country = "USA";
			stu_bdate= new DateTime(1996, 09, 25);

			//Assigning values to the variables for professor's info
			pro_firstName = "John";
			pro_lastName = "Guttag";
			pro_country = "USA";
		    pro_field = "Electronics";
			pro_age = 50;


			//Assigning values to the variables for degree's info
			deg_name = "Bachelor of Science";
			deg_field = "Information Technology";
			deg_credits = 90; 

		

		
			//Assigning values to the variables for programme's info
			progName = "Introduction to Computer Science";
			progField = "Computer Science";
			progDegrees = "Bachelor, Master, Ph.D.";
			progDepHead = "Eric Grimson";



			//Assigning values to the variables for side course's info
			courseName = "Introductory Physics";
			courseCredits = "85";
			courseField = "Physics";
			courseLength = "12 weeks";



			Console.WriteLine ("Student Information: \n" +
				               "---------------------- ");

			Console.WriteLine ("   Name      : " + stu_firstName + " " + stu_lastName + "\n" +
			                   "   Birthdate : " + stu_bdate.ToShortDateString () + "\n" +
			                   "\n");

			Console.WriteLine ("   Address   : " + stuAdd_ln1 + ", " + stuAdd_ln2 + ", \n" +
				               "               " + stu_city + ", " + stu_state + ", " + stu_ZIP + ", \n" +
				               "               " + stu_country  + "\n");

			Console.WriteLine ("Professor information: \n" +
				               "------------------------");
			Console.WriteLine ("   Name    : " + pro_firstName + " " + pro_lastName + "\n" +
			                   "   Country : " + pro_country + "\n" +
				               "   Field   : " + pro_field + "\n" +
				               "   Age     : " + pro_age + "\n");


			Console.WriteLine ("Information about the Degree: \n" +
				"------------------------------");
			Console.WriteLine ("   Name             : " + deg_name +"\n" +
				               "   Field            : " + deg_field + "\n" +
				               "   Credits required : " + deg_credits + "\n");


			Console.WriteLine ("Information about University programme: \n" +
				"------------------------------------------");
			Console.WriteLine ("   Name              : " + progName + "\n" +
				               "   Field             : " + progField + "\n" +
				               "   Degrees available : " + progDegrees + "\n" +
				               "   Department head   : " + progDepHead + "\n" );


			Console.WriteLine ("Information about optional extra course: \n" +
				"-------------------------------------------");
			Console.WriteLine ("   Name    : " +courseName + "\n" +
				               "   Field   : " + courseField + "\n" +
				               "   Length  : " + courseLength + "\n" +
				               "   Credits : " + courseCredits + "\n");

			Console.ReadLine  ();
		}
	



	}
}
