using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class student
    {
        public int StudentId;
        public string StudentName;
        public string StudentMailID;
        public double Percentage;
        public static string SchoolName;
        public static string SchoolAdress;

        public void PrintstudentDetails()
        {
            Console.WriteLine("Student ID:" + StudentId);
            Console.WriteLine("StudentName:" + StudentName);
            Console.WriteLine("StudentMailID:" + StudentMailID);
            Console.WriteLine("Percentage:" + Percentage);
            Console.WriteLine("SchoolName:" + student.SchoolName);
            Console.WriteLine("SchoolAdress:" + student.SchoolAdress);
        }
        public void DisplayCertification()
        {
            if (Percentage >= 90 && Percentage <= 100)
            {
                Console.WriteLine("Hi" + StudentName + " You have successfully passed with grade A");
            }
            else if (Percentage >= 80 && Percentage <= 89)
            {
                Console.WriteLine("Hi" + " You have successfully passed with grade B");
            }
            else if (Percentage >= 60 && Percentage <= 79)
            {
                Console.WriteLine("Hi" + " You have successfully passed with grade C");
            }
            else
            {
                Console.WriteLine("Hi" + "You have Fail this exam");
            }

                }
            }
        }

        

    
    

