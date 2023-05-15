//4.Есть массив из целых чисел. Написать функцию, которая определяет можно ли заданное число представить суммой чисел из массива (каждое число можно использовать один раз):
//Пример:
//Массив: { 3, 1, 8, 5, 4}
//Число 10 - можно представить суммой(1 + 5 + 4)
//Число 2 - нельзя


public class Program
{
    public static bool CanSum(int targetSum, int[] numbers, HashSet<int>? usedIds = null)
    {
        if (targetSum == 0 && usedIds != null)
        {
            return true;
        }

        if (targetSum < 0)
        {
            return false;
        }

        if (usedIds == null)
        {
            usedIds = new HashSet<int>();
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (usedIds.Contains(numbers[i]))
            {
                continue;
            }
            usedIds.Add(numbers[i]);
            int remainder = targetSum - numbers[i];
            if (CanSum(remainder, numbers, usedIds))
            {
                return true;
            }
            usedIds.Remove(numbers[i]);
        }
        return false;
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 3, 1, 8, 5, 4 };

        Console.WriteLine(CanSum(10, numbers)); // Output: True
        Console.WriteLine(CanSum(2, numbers));  // Output: False
        Console.WriteLine(CanSum(16658949, numbers));  // Output: False
        Console.WriteLine(CanSum(0, numbers));  // Output: False
        Console.WriteLine(CanSum(21, numbers));  // Output: True
    }
}
