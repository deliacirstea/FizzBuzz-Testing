public class FizzBuzz
{
    public string Run(int number)
    {
        //get a list of number from 1 to 100

           //check if the number is divisible by 3 and 5  - FizzBuzz
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            //check if the number is divisible by 3 - Fizz
            else if (number % 3 == 0)
            {
                return "Fizz";  }
            //check if the number is divisible by 5 - Buzz
            else if (number % 5 == 0)
            {
                return "Buzz";     }
            //write out the count
            else
            {
                return number.ToString();
            }
        





    }
}