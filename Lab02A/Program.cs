using System;

namespace NumberGameTwo
{
    class Program
    {
        static void Main(String[] args)
        {
            StartSequence();
        }
        static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int [] numberArray = new int[userNumber];

            Console.WriteLine($"You entered: {userNumber}");


            //getting the array

            // int[] numbers = new int[6];
            for (int i = 0; i < userNumber; i++)
            {

                Console.WriteLine($"Enter a number: {i} of {userNumber}");

                numberArray[i] = Convert.ToInt32(Console.ReadLine());

            }

            //asking for numbers 

            Console.WriteLine($"Select a number between 1 and {userNumber}.");
            int pickedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number to divide by: ");
            int divideNumber = Convert.ToInt32(Console.ReadLine());


            //showing array

            Console.WriteLine("Array line : " + string.Join(",", numberArray));
            Console.WriteLine($"Your array length is: {userNumber}.");

            
            //sum

            int sum = numberArray.Sum();
            Console.WriteLine($"Sum is: {sum}");

            // product

            int product = pickedNumber * sum;
            Console.WriteLine($"{pickedNumber} * {sum} = {product}");
            // Console.WriteLine($"Product is: {product}");

            //quotient

            Decimal dNum = Convert.ToDecimal(divideNumber);
            Decimal bigNum = Convert.ToDecimal(sum);
            Decimal value = Decimal.Divide(bigNum, dNum);
            Console.WriteLine($"{bigNum} / {dNum} = {value}.");


        }
    }
}



// using System;

// namespace NumberGame
// {
//     class Program
//     {
//         static void Main(String[] args)
//         {
//          StartSequence();

//         }
//         static void StartSequence(){
//             Console.WriteLine("Enter a number greater than zero.");
//             int userNumber = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine($"You entered: {userNumber}");
//             Console.WriteLine($"Number Array: {numArray}");
//         }
//         static int Populate(int[] numArray){
//             int[] numbers = new int [5];
//             for (int i = 0; i <numbers.Length; i++){

//                 Console.WriteLine($"Enter a number:  {i} of {numbers.Length}");

//                 numbers[i] = Convert.ToInt32(Console.ReadLine());
//             }
//         }

//         static int GetSum(int[] getSum){

//             int sum = numArray.Sum();

//         }

//         static int GetProduct(int[] getProduct){

//             Console.WriteLine($"Select a number between 1 and {numArray}.");
//             int pickedNumber = Convert.ToInt32(Console.ReadLine());
//             int product = pickedNumber * 


//         }
//     }
// }