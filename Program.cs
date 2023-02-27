using System;
using System.Data;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks; 

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Linda";
            int characterAge; 
            characterAge = 28; // -28
            char grade = 'A'; // No dubble quotation aloud
            float n1 = 28.1F; // Least accurate
            double n2 = 28.2; // Mid accurate
            decimal n3 = 28.3M; // Most accurate
            bool isMale = false;

            Console.WriteLine("My \"name\" is \n" + characterName);
            Console.WriteLine("My age is " + characterAge);

            characterName = "Andersson"; 

            Console.WriteLine("My last name is \n" + characterName);
            Console.WriteLine(characterName.Length); 
            Console.WriteLine(characterName.ToUpper()); 
            Console.WriteLine(characterName.ToLower()); 
            Console.WriteLine(characterName.Contains('L')); 
            Console.WriteLine(characterName[0]); 
            Console.WriteLine(characterName.IndexOf("sson")); // -1 = dose not exist
            Console.WriteLine(characterName.Substring(5)); 
            Console.WriteLine(characterName.Substring(5, 2)); 

            Console.WriteLine(5 / 2); // 2  int vs decimal
            Console.WriteLine(5 / 2.0); // 2.5 hole num vs decimal
  
            int[] luckyNumbers = { 1, 3, 7, 9, 12, 17, 19, 29 };

            luckyNumbers[1] = 4; 

            Console.WriteLine(luckyNumbers[1]); 

            string[] friends = new string[2]; // New must know how many elements inside the array
            friends[0] = "Main friend"; 
            friends[1] = "Second friend"; 

            Console.WriteLine(friends); // System.String[]

            // Method othside class
            SayHi("You", 28); 

            int cubedNumber = Cube(5);
            Console.WriteLine(cubedNumber); 

            // Exception testing
            try 
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            // catch(Exception e)
            // {
            //     Console.WriteLine(e.Message);   
            // }
            catch(DivideByZeroException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message); 
            }
            finally 
            {
                Console.WriteLine("I'll always be thrown!"); 
            }

            // Book
            Book book1 = new Book(); // Book object
            book1.title = "My Book"; 
            book1.author = "Linda A"; 
            book1.pages = 300; 

            Book book2 = new Book(); // Book object
            book2.title = "Another book"; 
            book2.author = "Linda K"; 
            book2.pages = 500; 

            Console.WriteLine(book1.title); 
            Console.WriteLine(book2.title); 

            // BetterBook
            BetterBook betterBook1 = new BetterBook("My best book", "Linda H-A", 250);

            betterBook1.title = "My best book yet!"; 

            Console.WriteLine(betterBook1.title);  

            // Student
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6); 

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            // Movie
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            shrek.Rating = "R"; 

            Console.WriteLine(avengers.Rating); 
            Console.WriteLine(shrek.Rating); 

            // Song
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount); 
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount()); 

            // Static method belongs to the class
            Console.WriteLine(Math.Sqrt(144)); 

            // UsefulTools
            UsefulTools.SayHello("Linda"); 

            // Chef
            Chef chef = new Chef(); 
            chef.MakeSpacialDish(); 

            // ItalianChef
            ItalianChef italianChef = new ItalianChef(); 
            italianChef.MakeSpacialDish(); 

            Console.ReadLine(); // Stops the console until enter
        }

        // Method / Function
        static void SayHi(string name, int age) 
        {
            Console.WriteLine("Hello " + name + "!\nYou are: " + age); 
        }

        static int Cube(int num)
        {
            int result = num * num * num; 
            return result; 
        }
    }
}