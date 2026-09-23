// Note! This program is not finished. Does not yet compile due to syntax errors

class Program {
    
    FizzBuzz(int[] arr, int X, int Y) {
        for (int i=0; i < arr.Length; i++) {
            if (arr[i] % X == 0) {
                if (arr[i] % Y == 0){
                    Console.WriteLine("FizzBuzz");
                } else {
                    Console.WriteLine("Fizz"); 
                }
            } else if (arr[i] % Y == 0) {
                Console.WriteLine("Buzz");
            } else {
                Console.WriteLine(arr[i]);
            }
        }
    }
    
    static void Main(string[] args){
        fizzBuzz(int [] arr, int X, int Y)
    }
}
