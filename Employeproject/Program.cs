namespace Maveric.Runner
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********EMPLOYE DASHBOARD********");
            Employe.companyName = "Maveric";
            Employe.companyLocation = "Chennai";

            Employe emp1 = new Employe();
            Employe emp2 = new Employe();

            emp1.empId = 101;
            emp1.empNmae = "saul";
            emp1.empSalary = 9000;

            emp2.empempId = 102;
            emp2.empName = "kim";
            emp2.empSalary = 12000.2;


            Employe.companyName = "Maveric Company";
            Console.WriteLine(emp1.empId);

             

 


        }
    }
}
