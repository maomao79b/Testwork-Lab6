using System;
 namespace Csharp{
    class A6{
        private int proposalSum = 0;
        private int[] proposalResult = new int[2]; //index=> 0=S,1=U 
        private int projectSum = 0;
        private int[] projectResult = new int[4]; //index=> 0=A,1=B,2=C,3=F 
        public void main(){
            Console.Write("how many student :> ");
            string numberOfStudent = Console.ReadLine();
            if(numberOfStudent!=""){
                if( int.TryParse(numberOfStudent, out int number) ){
                    Readdata(number);
                    ShowSummarize();
                }else{
                    Console.WriteLine("");
                }
            }else{

            }
        }
        private void ShowSummarize(){
            Console.WriteLine($"Proposal {proposalSum} students");
            Console.WriteLine($"   S = {proposalResult[0]}, U = {proposalResult[1]}");
            Console.WriteLine($"Project {projectSum} students");
            Console.WriteLine($"   A = {projectResult[0]}, B = {projectResult[1]}, C = {projectResult[2]}, F = {projectResult[3]}");
        }
        private void Readdata(int number){
            for(int i=0; i<number; i++){
                Console.Write("Type of exam : ");
                string typeExam = Console.ReadLine();
                if(String.Equals("p", typeExam, StringComparison.OrdinalIgnoreCase) && String.Equals("t", typeExam, StringComparison.OrdinalIgnoreCase)){
                    i--;
                    Console.WriteLine("Please enter P or T");
                    continue;
                }
                Console.Write("Exam score   : ");
                string examScore = Console.ReadLine();
                if(examScore != ""){
                    if(int.TryParse(examScore, out int score)){
                        string result = checkData(typeExam, score);
                        Console.Write($"Exam result  : {result}\n\n");
                    }
                }else{
                    i--;
                    Console.WriteLine("Please try again ** score is between 0-100");
                    continue;
                }
                
            }
        }
        private string checkData(string typeExam, int examScore){


            if(String.Equals("p", typeExam, StringComparison.OrdinalIgnoreCase)){
                proposalSum += 1;
                if(examScore >= 60){
                    proposalResult[0] += 1;
                    return "S";
                }else{
                    proposalResult[1] += 1;
                    return "U";
                }
            }else if(String.Equals("T", typeExam, StringComparison.OrdinalIgnoreCase)){
                projectSum += 1;
                if(examScore >= 80){
                    projectResult[0] += 1;
                    return "A";
                }else if(examScore >= 60){
                    projectResult[1] += 1;
                    return "B";
                }else if(examScore >= 50){
                    projectResult[2] += 1;
                    return "C";
                }else{
                    projectResult[3] += 1;
                    return "F";
                }
            }else return "";
        }
    }
 }