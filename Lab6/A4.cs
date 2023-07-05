using System;

namespace Csharp{
    class A4{
        private int[] score = new int[9];
        private string dataFromVillage= "";
        public void main(){
            // read Data score from user
            ReadData();
            // show console
            Print();
        }

        private void ReadData(){
            int count = 1;
            while(true){
                Console.Write($"input data[{count}] :> ");
                count++;
                string input = Console.ReadLine();
                if(int.TryParse(input, out int number)){
                    if(number >= 0 && number < 9){
                        if(number == 0){
                            break;
                        }
                        dataFromVillage = dataFromVillage + $"{number} ";
                        score[number-1] += 1;
                    }else{
                        Console.WriteLine("Please input number 1-9");
                        count--;
                    }

                }else{
                    Console.WriteLine("Please input number 1-9");
                    count--;
                }
            }
        }

        private void Print(){
            Console.WriteLine("");
            Console.WriteLine("data from villager :");
            Console.WriteLine(dataFromVillage);

            Console.WriteLine("score of each applycant:");
            foreach(var number in score){
                Console.Write($"{number} ");
            }

            Calculat();

        }

        private void Calculat(){
            int vote_score_max = score.Max();
            int assist_score = 0;
            foreach ( var number in score ){
                if(number < vote_score_max){
                    if(number > assist_score) assist_score=number;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Head is number {Array.IndexOf(score,vote_score_max)+1}\t\tvote_score is {vote_score_max}");
            Console.WriteLine($"Assistant is number {Array.IndexOf(score,assist_score)+1}\t\tvote_score is {assist_score}");
        }
    }
}
