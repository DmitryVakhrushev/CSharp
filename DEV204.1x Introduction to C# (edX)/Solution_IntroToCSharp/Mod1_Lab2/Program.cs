using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

         /*
            Self Assessment Lab
                1. Create a C# Console application.
                2. Within the Main() method in this application, create variables of the correct data type for the information related to a course, using the information presented below. 
                3. Once you have the variables created, use assignment statements to assign values to the variables and use the Console.WriteLine() method to output the values to the console window.

               Again, this assignment is merely intended to check your understanding of how to create variables,
               assign values to them, and output the information to a console window.
               You will build on these concepts and begin to create more functionality in later modules.

            Challenge (Not graded)
               Investigate the .NET Framework documentation around Console.ReadLine() and modify your code
               to use this method for accepting input from a user of your application.
               Using Console.ReadLine(), prompt a user for information about a student.
               One prompt for each student variable you created earlier.
               Use the appropriate code to assign the values from the user to the variables for the student.                 

         */


         //Student Information
         string StudentFirstName = "";
         string StudentLastName = "";
         DateTime StudentBirthdate;
         string StudentAddressLine1 = "";
         string StudentAddressLine2 = "";
         string StudentCity = "";
         string StudentStateProvince = "";
         string StudentZipPostal = "";
         string StudentCountry = "";

        //Teacher Information
         string TeacherFirstName = "";
         string TeacherLastName = "";
         string TeacherBirthdate      = "";
         string TeacherAddressLine1   = "";
         string TeacherAddressLine2   = "";
         string TeacherCity           = "";
         string TeacherStateProvince  = "";
         string TeacherZipPostal      = "";
         string TeacherCountry = "";

         //UProgram Information
         string ProgramName = "";
         string ProgramDepartmentHead = "";
         string ProgramDegrees = "";

         //Degree Information
         string DegreeName = "";
         float DegreeCreditsRequired = 0;

         //Course Information
         string CourseName = "";
         float CourseCredits = 0;
         float CourseDurationWeeks = 0;
         string CourseTeacher = "";

        }
    }
}
