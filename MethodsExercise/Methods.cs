using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise;

internal static class Methods
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    } 
    public static int Multiply(int num1, int num2)
    { 
        return num1 * num2; 
    } 
    public static int Divide(int num1, int num2) 
    {
        return num1 / num2; 
    }
    public static int Subtract(int num1, int num2) 
    {
        return num1 - num2; 
    }

    public static void AddWithParam(params int[] numbers)
    {
        int sum = 0;    
        foreach (var item in numbers)
        {
            sum += item;    
        }
        Console.WriteLine(sum);
    }

    public static void MultiplyWithParam(params int[] numbers)
    {
        int answer = 1;
        foreach (var item in numbers)
        {
            answer *= item;
        }
        Console.WriteLine(answer); 
    }

    public static void SubtractWithParam(params int[] numbers)
    {
        var startingPoint = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        { 
            startingPoint -= numbers[i]; 
        }
        Console.WriteLine(startingPoint);
    }
}

                                                  