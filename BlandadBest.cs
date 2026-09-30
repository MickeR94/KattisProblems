using System;
internal class Program{
    static void Main(string[] args){
        string input = Console.ReadLine();
        int readNum = Int32.Parse(input);
        string result = BlandadBest(readNum);
        Console.WriteLine(result);
    } 
    
    private static string BlandadBest(int n){
        if (n == 2){
            return "blandad best";
        } else {
            string readMeat = Console.ReadLine();
            return readMeat;
        } 
    }
}
