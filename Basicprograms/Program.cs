namespace Basicprogram
{
    public class PowerOf2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the power value: ");
            long N = Convert.ToInt32(Console.ReadLine());
            int num = 2;
            for (var i = 0; i < N; i++)
            {
                Console.WriteLine(num);
                num = num * 2;
            }
            Console.ReadLine();
           

            }


        }
           

            }
        
    
