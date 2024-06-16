// Дан массив и число.
// Найдите три числа в массиве сумма которых равна искомому числу.
// Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 12, 34, 8, 9, 3, 17, 15, 10, 21 };
            HashSet<int> intsHashSet = new HashSet<int>(ints);

            int target = 34;

            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (intsHashSet.Contains(target - ints[i] - ints[i + 1]))
                {
                    Console.WriteLine($"Три числа дающие в сумме {target} это ({ints[i]}, {ints[i + 1]}, {target - ints[i] - ints[i + 1]})");
                }
            }

            // Три числа дающие в сумме 34 это(8, 9, 17)
            // Три числа дающие в сумме 34 это(17, 15, 2)
            // Три числа дающие в сумме 34 это(15, 10, 9)
            // Три числа дающие в сумме 34 это(10, 21, 3)

        }
    }
}
