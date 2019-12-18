using System.Linq;

namespace GeneralAlgo
{
    public static class FizzBuzz
    {
        public static string[] Convert(int[] nums) =>
            nums.Select(num => num % 6 == 0 ? "FizzBuzz" : (num % 2 == 0 ? "Fizz" : (num % 3 == 0 ? "Buzz" : null))).ToArray();
    }
}

//return nums.Select(num =>
//{
//    var result = new StringBuilder();

//    var res = num % 6 == 0 ? "FizzBuzz" : (num % 2 == 0 ? "Fizz" : (num % 3 == 0 ? "Buzz" : null));

//    if (num % 2 == 0) result.Append("Fizz");
//    if (num % 3 == 0) result.Append("Buzz");
//    return result.ToString();
//}).ToArray();
