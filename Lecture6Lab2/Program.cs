/// Lab No. 6		Exercise Part 2
/// File Name: Fraction
/// @author: Evan Sinclair
/// Date:  Oct 6, 2020
///
/// Problem Statement: Define a class called Fraction. Include setter methods that allow the user to set the numerator
/// and the denominator.  Include a method that returns the value of the numerator divided by the denominator as a 
/// double.  Include an additional method that outputs the value of the fraction reduced to lowest terms (ie instead
/// of outputting 20/60 output 1/3). Embed your class in a test program.
/// 
/// 
/// Overall Plan:.
/// 1)Build Class Fraction with numerator and denominator
/// 2)Write a constructor and setters and getters
/// 3)Write method that will return a reduced fraction
/// 4)Build driver program to test Fraciton class


using System;

namespace Lecture6Lab2
{
    public class Fraction
    {
        
        //Variables
        private int numerator; 
        private int denominator;

        //Constructor
        public Fraction(int numer, int denom)
        {
            SetNumerator(numer);
            SetDenominator(denom);
        }

        //Setters
        public void SetNumerator(int numer)
        {
            numerator = numer;
        }
        
        // do not allow 0 for denominator
        public void SetDenominator(int denom)
        {
            if (denom != 0)
            {
                denominator = denom;
            }
            else
            {
                Console.WriteLine("Error, cannot set denominator to 0. Setting denominator to 1");
                SetDenominator(1);
            }
        }

        //Getters

        public int GetDenom()
        {
            return denominator;
        }

        public int GetNumer()
        {
            return numerator;
        }

        public double GetDouble()
        {
            return Convert.ToDouble(numerator) / denominator;
        }
        // Reduce fraction by finding GCD with the Euclidean algorithm and then
        // dividing numerator and denominator by it

        public void DisplayReducedFraction()
        {
            int a = denominator;
            int b = numerator;

            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            Console.WriteLine((numerator / a) + " / " + (denominator / a));
        }



    }

    //Test Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerator and a denominator");
            Fraction tester = new Fraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            tester.DisplayReducedFraction();
            Console.WriteLine(tester.GetDouble());

        }


    }

    
}
