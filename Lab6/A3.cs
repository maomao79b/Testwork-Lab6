using System;

namespace Csharp{
    class A3{
         public void main(){
            Console.Write("how many number :> ");
            int data_amount =  int.Parse(Console.ReadLine());
            if( data_amount > 0){
                int[] array = InputArray(data_amount);
                int minNumber = array.Min();
                int maxNumber = array.Max();
                int differNumber = maxNumber - minNumber;
                Console.WriteLine("");
                Console.WriteLine("Max is " + maxNumber);
                Console.WriteLine("Min is " + minNumber);
                Console.WriteLine("Diff is " + differNumber);
            }
         }

         private static int[] InputArray(int data_amount){
            
            int[] numbers = new int[data_amount];

            for ( int i=0 ; i<data_amount ; i++){
                Console.Write($"input data[{i+1}] :> ");
                string number = Console.ReadLine();
                if(int.TryParse(number, out int value)){
                    numbers[i] = value;
                }else{
                    Console.WriteLine("Please input number");
                    i--;
                    continue;
                }
            }

            return numbers;
         }
    }
}