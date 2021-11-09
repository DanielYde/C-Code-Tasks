using System;

namespace Tower_of_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi(4, 'A', 'B', 'C');
        }

        static void Move(char from, char to) {
            Console.WriteLine("Move the disc from {0} to {1}!", from, to);
        }

        static void Hanoi(int Number, char from, char helper, char target) {
            if(Number == 0) {} else {
            Hanoi(Number-1, from, target, helper);
            Move(from, target);
            Hanoi(Number-1, helper, from, target);
            }
        }












    }
}
