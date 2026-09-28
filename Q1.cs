/*
Question 1
Write a function that given two positive integer value parameters will print
out all even numbers between 2 and the highest parameter value (inclusive)
which is evenly divisible by the lowest parameter value.
Examples
Given 17 and 4, the output will be 4, 8, 12, 16
Given 21 and 7, the output will be 14
Given 5 and 20, the output will be 10, 20
Given 3 and 10, the output will be 6
Given 2 and 2, the output will be 2
*/

//Pseudocode

/*

find which is the largest and which is the lowest

iterate every number between max and min

perform modulo 2 to check for the reminder

insert to list and return at the end

*/
using System.Runtime.InteropServices.Marshalling;

static void Q1(int num1, int num2)
{

    List<int> ans = new List<int>();

    int max = 0;
    int min = 0;

    if (num1 > num2)
    {
        max = num1;
        min = num2; 
    } else
    {
        max = num2;
        min = num1;
    }

    for (int i = min; i <= max; i++)
    {
        //modulo to check the reminder 
        if (i % 2 == 0)
        {
            ans.Add(i);
        }
    }

    Console.WriteLine(ans);

}