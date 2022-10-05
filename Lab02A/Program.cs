using System;

namespace NumberGameTwo
{
    class Program
    {
        static void Main(String[] args)
        {
            StartSequence();
        }
        static void StartSequence(){
        {
            Console.WriteLine("Enter a number greater than zero.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {userNumber}");

            int[] numberArray = new int[userNumber];
            numberArray = Populate(userNumber, numberArray);

            int sum = GetSum(numberArray);
            int[] product = GetProduct(numberArray, sum);
            decimal[] quotient = GetQuotient(product[0]);

            Console.WriteLine(
            $"Array size: {numberArray.Length}\nYour Array: {String.Join(", ", numberArray)}\nSum: {sum}\nProduct: {sum} * {numberArray[product[1] - 1]} = {product[0]}\nQuotient: {product[0]} / {quotient[1]} = {quotient[2]}");
        }



            //getting the array

            // int[] numbers = new int[6];
            static int[] Populate(int userNumber, int[] numberArray)
            {
                for (int i = 0; i < userNumber; i++)
                {

                    Console.WriteLine($"Enter a number: {i + 1} of {userNumber}");

                    numberArray[i] = Convert.ToInt32(Console.ReadLine());

                }
                return numberArray;
            }

            //asking for numbers 


            // Console.WriteLine("Enter a number to divide by: ");
            // int divideNumber = Convert.ToInt32(Console.ReadLine());


            //showing array

            // Console.WriteLine("Array line : " + string.Join(",", numberArray));
            // Console.WriteLine($"Your array length is: {userNumber}.");


            //sum
            static int GetSum(int[] numberArray)
            {
                int sum = numberArray.Sum();
                return sum;
            }


            // product
            static int[] GetProduct(int[] numberArray, int sum)
            {
                Console.WriteLine($"Select a number between 1 and {numberArray.Length}.");
                int productNumber = Convert.ToInt32(Console.ReadLine());
                int product = productNumber * sum;
                int[] productArray = { product, productNumber };
                return productArray;
            }
            // Console.WriteLine($"Product is: {product}");

            //quotient

            static Decimal[] GetQuotient(int product)
            {
                Console.WriteLine("Enter a number to divide by: ");
                int divideNumber = Convert.ToInt32(Console.ReadLine());

                Decimal dNum = Convert.ToDecimal(divideNumber);
                Decimal bigNum = Convert.ToDecimal(product);
                Decimal value = Decimal.Divide(bigNum, dNum);
                // Console.WriteLine($"{bigNum} / {dNum} = {value}.");
                Decimal[] quotientArray = { bigNum, dNum, value };
                return quotientArray;
            }

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