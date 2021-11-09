using System;

namespace My_Route_Tree
{
    class Program
    {

        static void Main(string[] args) {
            // The Variables Are Assigned.
            int CountTrue = 0;
            int CountFalse = 0;
            bool IsYes = false;
            bool IsNo = false;
            bool Seriøst = false;

            // The First Question Is Asked.
            Console.WriteLine("Er du ved at dø?");
            Console.Write("Ja/Nej: ");
            IsYes = false; IsNo = false;
            while(IsYes == false && IsNo == false) {
                check(Console.ReadLine(), CountTrue, CountFalse, out CountTrue, out CountFalse, out IsYes, out IsNo);
            }

            // The Second Question Is Asked.
            if(IsYes == true && CountTrue == 1 && CountFalse == 0) {
                Console.Clear();
                Console.WriteLine("Seriøst?");
                Console.Write("Ja/Nej: ");
                IsYes = false; IsNo = false; Seriøst = true;
                while(IsYes == false && IsNo == false) {
                    check(Console.ReadLine(), CountTrue, CountFalse, out CountTrue, out CountFalse, out IsYes, out IsNo);
                }
            }

            if(IsNo == true &&  CountTrue == 0 && CountFalse == 1) {
                Console.Clear();
                Console.WriteLine("Tror du det er alvorligt?");
                Console.Write("Ja/Nej: ");
                IsYes = false; IsNo = false;
                while(IsYes == false && IsNo == false) {
                    check(Console.ReadLine(), CountTrue, CountFalse, out CountTrue, out CountFalse, out IsYes, out IsNo);
                }
            }

            // The Third Question Is Asked.
            if(IsYes == true && CountTrue == 2 && CountFalse == 0) {
                Console.Clear();
                Console.WriteLine("Ring 112");
                Console.ReadLine();
            }

            if(IsNo == true && CountTrue == 1 && CountFalse == 1) {
                Console.Clear();
                Console.WriteLine("Tror du det er alvorligt?");
                Console.Write("Ja/Nej: ");
                IsYes = false; IsNo = false;
                while(IsYes == false && IsNo == false) {
                    check(Console.ReadLine(), CountTrue, CountFalse, out CountTrue, out CountFalse, out IsYes, out IsNo);
                }
            }

            if(IsNo == true && CountTrue == 0 && CountFalse == 2) {
                Console.Clear();
                Console.WriteLine("Ring til din mor");
                Console.ReadLine();
            }

            if(IsYes == true && CountTrue == 1 && CountFalse == 1) {
                Console.Clear();
                Console.WriteLine("Synes du, forkølelse er alvorligt?");
                Console.Write("Ja/Nej: ");
                IsYes = false; IsNo = false;
                while(IsYes == false && IsNo == false) {
                    check(Console.ReadLine(), CountTrue, CountFalse, out CountTrue, out CountFalse, out IsYes, out IsNo);
                }
            }

            // The Fourth Question Is Asked.
            if(IsNo == true && CountTrue == 1 && CountFalse == 2 && Seriøst == true) {
                Console.Clear();
                Console.WriteLine("Ring til din mor");
                Console.ReadLine();
            }

            if(IsYes == true && CountTrue == 2 && CountFalse == 1) {
                Console.Clear();
                Console.WriteLine("Synes du, forkølelse er alvorligt?");
                Console.Write("Ja/Nej: ");
                IsYes = false; IsNo = false;
                while(IsYes == false && IsNo == false) {
                    check(Console.ReadLine(), CountTrue, CountFalse, out CountTrue, out CountFalse, out IsYes, out IsNo);
                }
            }

            if(IsNo == true && CountTrue == 1 && CountFalse == 2 && Seriøst == false) {
                Console.Clear();
                Console.WriteLine("Er din læge åben nu?");
                Console.Write("Ja/Nej: ");
                IsYes = false; IsNo = false;
                while(IsYes == false && IsNo == false) {
                    check(Console.ReadLine(), CountTrue, CountFalse, out CountTrue, out CountFalse, out IsYes, out IsNo);
                }
            }

            // The Fifth Question Is Asked.
            if(IsYes == true && CountTrue == 3 && CountFalse == 1) {
                Console.Clear();
                Console.WriteLine("Ring til din mor");
                Console.ReadLine();
            }

            if(IsNo == true && CountTrue == 2 && CountFalse == 2 && Seriøst == true) {
                Console.Clear();
                Console.WriteLine("Er din læge åben nu?");
                Console.Write("Ja/Nej: ");
                IsYes = false; IsNo = false;
                while(IsYes == false && IsNo == false) {
                    check(Console.ReadLine(), CountTrue, CountFalse, out CountTrue, out CountFalse, out IsYes, out IsNo);
                }
            }

            if(IsNo == true && CountTrue == 2 && CountFalse == 2 && Seriøst == false) {
                Console.Clear();
                Console.WriteLine("Ring til lægevagten");
                Console.ReadLine();
            }

            if(IsYes == true && CountTrue == 2 && CountFalse == 2 && Seriøst == false) {
                Console.Clear();
                Console.WriteLine("Ring til egen læge");
                Console.ReadLine();
            }

            // The Sixth Question Is Asked
            if(IsNo == true && CountTrue == 2 && CountFalse == 3 && Seriøst == true){
                Console.Clear();
                Console.WriteLine("Ring til lægevagten");
                Console.ReadLine();
            }
            if(IsYes == true && CountTrue == 3 && CountFalse == 2 && Seriøst == true){
                Console.Clear();
                Console.WriteLine("Ring til egen læge");
                Console.ReadLine();
            }


        }

        private static void check(string Answer, int AmountTrueIn, int AmountFalseIn, out int AmountTrueOut, out int AmountFalseOut, out bool Yes, out bool No) {
            AmountTrueOut = AmountTrueIn;
            AmountFalseOut = AmountFalseIn;
            Yes = false;
            No = false;
            if(Answer.ToUpper() != "JA" && Answer.ToUpper() != "NEJ") {
                Console.WriteLine("Svar venligst kun Ja eller Nej");
                Console.Write("Ja/Nej: ");
            } else if(Answer.ToUpper() == "JA") {
                AmountTrueOut += 1;
                Yes = true;
                No = false;
            } else if(Answer.ToUpper() == "NEJ") {
                AmountFalseOut += 1;
                Yes = false;
                No = true;
            }
        }
    }
}