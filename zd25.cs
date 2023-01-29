int Extent(int a, int b) 
{
    int result = 1;
    for (int count = 1; count <= b; count++)
    { 
       result = result * a;

    }

    return result;
}
int ReadConsole(string msg) 
{
Console.Write(msg);
return int. Parse (Console. ReadLine () !) ;
}
Console.Clear();
int a = ReadConsole("Введите число А: ");
int b = ReadConsole("Введите натуральное число В: ");
int pow = Extent(a, b);

Console.Write(pow);