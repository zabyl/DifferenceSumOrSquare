internal class Program
{
    private static void Main(string[] args)
    {
        CompareWithSixtySeven();
    }

    static void CompareWithSixtySeven()
    {
      Console.WriteLine("How many numbers do you want to check?");
      int numCount = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"You will test {numCount} numbers.");
      int[] nums = new int [numCount];
      
      int sumOfDifference = 0;
      int squareOfDifference = 0;
      int baseNum = 67;
      int counter = 0;
      
      while(numCount > 0)
      {
          Console.WriteLine("Please enter a number except 67: ");
          nums[counter] = Convert.ToInt32(Console.ReadLine());
          
          if (nums[counter] < baseNum)
          {
              sumOfDifference += (baseNum - nums[counter]);
          }
          else if (nums[counter] > baseNum)
          {
              squareOfDifference += ( (nums[counter] - baseNum) * (nums[counter] - baseNum) );
          }
          
          counter++;
          numCount--;
      }
      
      foreach (int num in nums)
      {
          Console.Write($"{num} ");
      }
      
      Console.WriteLine();
    
      Console.WriteLine($"{sumOfDifference} {squareOfDifference}");
    }
}