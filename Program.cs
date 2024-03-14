using System.Xml;
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());

}
int NaturalDigitsInNumber(int M, int N)
{
    if(M<=N)
{ 
    System.Console.Write(M);
    return NaturalDigitsInNumber(M+1,N);}
    else return 0;
} 

int numberM = ReadInt("Введите число M:");
int numberN = ReadInt("Введите число N:");
NaturalDigitsInNumber(numberM, numberN);
