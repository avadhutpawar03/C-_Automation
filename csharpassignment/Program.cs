using Math.Volumeformulae;

namespace Math.formulae
{
    public class Program
    {
        static void Main111()
        {
            Console.WriteLine("avadhut pawar");

            double result = Volume.VolumeOfSphere(12);
            Console.WriteLine("The volume of sphere is " + result);
            
            result=Volume.VolumeOfCuboid(10,10,10);
            Console.WriteLine(result);

        }
    }
}
