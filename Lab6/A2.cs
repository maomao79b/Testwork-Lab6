using System;

namespace Csharp {
    public class A2{
        private double sum = 0;
        private double search = 0.0;
        public void main(){

            Console.Write("how many number :> ");
            int data_amount =  int.Parse(Console.ReadLine());

            if ( data_amount > 0){

                double[] result = data(data_amount);
                
                Console.Write($"input data to search :> ");
                search =  double.Parse(Console.ReadLine());
                Console.WriteLine("\nindex");
                for ( int i=0 ; i<data_amount ; i++) {
                    Console.Write($"{i}\t\t");
                }
                Console.WriteLine("\n");
                foreach ( double number in result ){
                    Console.Write($"{number:F1}\t\t");
                    if(number == this.search) sum += number;
                }
                Console.WriteLine("\n\n");
                Console.WriteLine("data\tsum");
                Console.WriteLine($"{search:F1}\t{sum:F1}");
            }

        }

        private double[] data(int data_amount){

            double[] numbers = new double[data_amount];

            for ( int i=0 ; i<data_amount ; i++){
                Console.Write($"input data[{i+1}] :> ");
                string number = Console.ReadLine();
                if( number == "" ){
                    Console.WriteLine("Please input number");
                    i--;
                    continue;
                }
                numbers[i] = double.Parse(number);
            }
            return numbers;
        }

    }
}