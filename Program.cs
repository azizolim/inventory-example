
using System.Runtime.CompilerServices;

internal class Program
{
   private static bool _hasString;
    private static void Main(string[] args)
    {
         
        Random random = new Random();
        int[] _newArray = new int[random.Next(1,10)];
        int n = _newArray.Length;
        Console.WriteLine($" Введите {n} количество значений");
        for (int i = 0; i != _newArray.Length; i++) 
        {
            int x = i;
            x++;
            Console.WriteLine($"Введите значение {x}");
            do
            {
                _hasString = int.TryParse(Console.ReadLine(), out _newArray[i]);
                if (!_hasString)
                {
                    Console.WriteLine("Insert a valid number");
                }
            } while (!_hasString);
            
        }
        for (int i = 0; i != _newArray.Length; i++)
        {
            int h = i;
            h++;
            Console.WriteLine($"{h}. {_newArray[i]}");
        }
        
    }
    
}