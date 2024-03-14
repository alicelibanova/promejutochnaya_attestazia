using System.ComponentModel.DataAnnotations;
using System.Xml;

int[] array = new int[]{1, 2, 5, 0, 10, 34};


int reversearray(int n)
{
    if (n >= 0)
{
    System.Console.Write(array[n]);
    return reversearray(n - 1);}
    else
    {
      return 0;  
    }
} 

reversearray(array.Length-1);


