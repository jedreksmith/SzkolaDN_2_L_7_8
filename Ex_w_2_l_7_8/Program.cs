using System.Net;

namespace W_2_l_7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Przyjęcie na studia");

            Console.WriteLine("Podaj wynik z matematyki");
            int mat = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wynik z fizyki");
            int fiz = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wynik z chemii");
            int che = int.Parse(Console.ReadLine());

            if (mat > 70 && fiz>55 && che>45 || (mat +fiz+ che > 150 ) || mat + che > 150 ||mat + fiz>150) {
                Console.WriteLine("Zostałeś przyjęty");
            }
            else { Console.WriteLine("Nie zostałes przyjęty"); };

        }
    }
}
