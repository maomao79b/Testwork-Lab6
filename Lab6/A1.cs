using System;

namespace Csharp
{
    public class A1{
        public void main(){
            Console.Write("\n\nmenu \n 1.Line \n 2.Rectangle \n 3.Triangle \n 4.Exit \n--------------\n");
            Console.Write("menu :> ");
            int menu =  int.Parse(Console.ReadLine());

            if( menu == 4 ){
                Environment.Exit(0);
            }else if ( menu == 1 ){

                Console.Write("\n\n\ninput length of line :> ");
                int length_line =  int.Parse(Console.ReadLine());
                Line(length_line);

            }else if ( menu == 2 ){

                Console.Write("\n\n\ninput length of line :> ");
                int length_line =  int.Parse(Console.ReadLine());
                Console.Write("ninput number of line :> ");
                int number_line =  int.Parse(Console.ReadLine());
                Rectangle(length_line,number_line);

            }else if ( menu == 3 ){

                Console.Write("\n\n\ninput width of line :> ");
                int width_line =  int.Parse(Console.ReadLine());
                Triangle(width_line);

            }else {

                Console.WriteLine("Pleas choose number 1-4");
                main();

            }

        }

        private void Line(int length_line)
        {
            if( length_line - 1 < 0 ){
                Console.WriteLine("Enter value more than zero");
            }else {
                for (int i=length_line-1; i>=0 ; i--) {
                    Console.Write(i);
                }
            }
            main();
        }

        private void Rectangle(int length_line, int number_line){
            if( length_line <= 0 || number_line <= 0){
                Console.WriteLine("Enter value more than zero");
            }else {
                for ( int i = 1 ; i<= number_line ; i++) {
                    for ( int j = length_line ; j>0 ; j--) {
                        Console.Write(i);
                    }
                    Console.WriteLine("");
                }
            }
            main();
        }

        private void Triangle(int width_line){
            if( width_line <= 0){
                Console.WriteLine("Enter value more than zero");
            }else {
                for ( int i = width_line ; i>= 1 ; i--) {
                    for ( int j = i ; j>=1 ; j--) {
                        if ( j==1 ) {
                            Console.Write(i);
                        }else {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine("");
                }
            }
            main();
        }
    }
}