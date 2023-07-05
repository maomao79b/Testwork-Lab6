using System;

namespace Csharp{
    class A5{
        private int[] data1;
        private int[] data2;
        private int sum = 0;
        public void main(){
            Console.Write("how many number :>");
            string amountNumber = Console.ReadLine();
            if(amountNumber != null){
                if(int.TryParse(amountNumber, out int number)){
                    
                    data1 = new int[number];
                    data2 = new int[number];

                    ReadData(data1, "data1");
                    Console.WriteLine("----------------------------------");
                    ReadData(data2, "data2");

                    Calculat(data1,data2);
                    Console.WriteLine("----------------------------------\n");
                    Console.WriteLine($"Sum of Diif-Square is {sum}");

                }else{
                    Console.WriteLine("Please input number");
                }
            }else{
                Console.WriteLine("Please input number");
            }
        }
        private void ReadData(int[] data, string dataName){
            for(int i=0; i<data.Length; i++){
                Console.Write($"input {dataName}[{i+1}] :>");
                string input = Console.ReadLine();
                if(input != null){
                    if(int.TryParse(input, out int number)){
                        data[i] = number;
                    }else{
                        Console.WriteLine("Please input number");
                        i--;
                    }
                }else{
                    Console.WriteLine("Please input number");
                        i--;
                }
            }
            Console.WriteLine("");
        }

        private void Calculat(int[] data1, int[] data2){
            if(data1.Length > 0 && data2.Length > 0 ){
                for ( int i=0; i<data1.Length; i++){
                    int result = data1[i] - data2[i];
                    result = result*result;
                    sum += result;
                    Console.WriteLine($"data1[{data1[i]}] - data2[{data2[i]}] = {result}");
                }
            }
        }
    }
}