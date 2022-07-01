using System;

namespace _4_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userInputArray = new int[0];
            string userInput;
            int sumOfArray = 0;
            bool continuationProgram = true;
            
            while(continuationProgram == true)
            {
                Console.WriteLine("Введите число для заполнения массива\nВведиде sum для вывода суммы всех элементов массива\nВведите exit для завершения программы");
                userInput = (Console.ReadLine());

                
                if (userInput == "sum")
                {
                    for (int i = 0; i < userInputArray.Length; i++)
                    {
                        sumOfArray += userInputArray[i];
                    }
                    Console.WriteLine("Сумма всех элементов массива равна: " + sumOfArray);
                    userInputArray = new int[1];
                }
                else if (userInput == "exit")
                {
                    continuationProgram = false;
                }
                else
                {
                    int[] tempUserInputArray = new int[userInputArray.Length + 1];

                    for (int i = 0; i < userInputArray.Length; i++)
                    {
                        tempUserInputArray[i] = userInputArray[i];
                    }
                    tempUserInputArray[tempUserInputArray.Length -1] = Convert.ToInt32(userInput);

                    userInputArray = tempUserInputArray;
                }
            }
        }
    }
}
