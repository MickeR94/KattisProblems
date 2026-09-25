using System;

namespace lvable {
    internal class Program {
        static void Main(string [] args){
            string number = Console.ReadLine();
            int num = Int32.Parse(number);
            string text = Console.ReadLine();
            int result = Characters(num, text);
            Console.WriteLine(result);
        }
        
        private static int Characters(int n, string s){
            bool hasL = false;
            bool hasV = false;
            for (int i = 0; i < n; i++){
                if(i + 1 < n && s[i] == 'l' && s[i+1] == 'v'){
                    return 0;
                } else if (s[i] == 'l'){
                    hasL = true;
                } else if (s[i] == 'v'){
                    hasV = true;
                }
            }
            
            if (hasL || hasV){
                return 1;
            } else {
                return 2;
            }
            
        }
    }
}
