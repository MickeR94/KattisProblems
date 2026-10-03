// Solution for a Kattis problem where you add the expenses from a string. The string includes both expenses (negative numbers) and incomes, hence the program filters for negative numbers
using System;

namespace JobExpenses{
    internal class Program{
        static void Main(String [] args){
            int n = int.Parse(Console.ReadLine());
            
            string[] ki = Console.ReadLine().Split(' ');
            
            Console.WriteLine(Sum(n, ki));
            
        }
        
        
        private static int Sum(int n, string[] k){
            int expenses = 0;
            for(int i = 0; i < n; i++){
                int number = int.Parse(k[i]);
                if (number < 0){
                    expenses += number;
                }
                
            }
            expenses = expenses*(-1);
            return expenses;
        }
    }
}
