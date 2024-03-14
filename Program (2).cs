using System.ComponentModel;
using System.Xml;
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());

}
int ADigitsInNumber(int M, int N)
{
    if(M == 0)return N + 1;
    if (M > 0 && N == 0) return ADigitsInNumber(M - 1,  1);
    if(M > 0 && N > 0)
   return ADigitsInNumber(M - 1,ADigitsInNumber(M, N - 1));

return 0;

} 

int numberM = ReadInt("Введите число M:");
int numberN = ReadInt("Введите число N:");
System.Console.Write(ADigitsInNumber(numberM, numberN));
