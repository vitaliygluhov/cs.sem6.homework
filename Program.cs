namespace sem6_hw;
using vgnamespace;
class Program
{
    static void Main(string[] args)
    {
        //Задача 41: Пользователь вводит с клавиатуры M чисел. 
        //Посчитайте, сколько чисел больше 0 ввёл пользователь.
        void Task41()
        {
            int[] Num = vg.MultiInputInt("Введите числа разделенные пробелами ");
            int Count = 0;
            for (int i = 0; i < Num.Length; i++)
                if (Num[i] > 0)
                    Count++;
            Console.WriteLine($"Введено чисел больше 0: {Count}");
        }
        Task41();
    }
}
