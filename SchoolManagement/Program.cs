using SchoolManagement;

namespace SchoolMangement
{
    public class program
    {
        static void Main(String[] args)
            {
            student stud1 = new student();
            student stud2 = new student();
            student stud3 = new student();

            stud1.StudentId = 1001;
            stud1.StudentName = "jack";
            stud1.StudentMailID = "jack@gmail.com";
            stud1.Percentage = 45.2;
            student.SchoolName = "Global school";
            student.SchoolAdress = "chennai";


            stud1.StudentId = 1002;
            stud1.StudentName = "peter";
            stud1.StudentMailID = "peter@gmail.com";
            stud1.Percentage = 85.2;
            student.SchoolName = "Global school";
            student.SchoolAdress = "chennai";
            
            stud1.StudentId = 1003;
            stud1.StudentName = "mark";
            stud1.StudentMailID = "mark@gmail.com";
            stud1.Percentage = 56.5;
            student.SchoolName = "Global school";
            student.SchoolAdress = "chennai";

            stud1.PrintstudentDetails();
            stud1.DisplayCertification();

            stud2.PrintstudentDetails();
            stud2.DisplayCertification();

            stud3.PrintstudentDetails();
            stud3.DisplayCertification();








        }
     }
      }
