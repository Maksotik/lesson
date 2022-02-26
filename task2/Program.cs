int max = 0;

Console.WriteLine("Введите первое число- ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);

Console.WriteLine("Введите второе число- ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);

Console.WriteLine("Введите третье число- ");
string inputC = Console.ReadLine();
int numberC = int.Parse(inputC);

if( max > numberA ); 
    else
    {
      max = numberA;  
    }

if( max > numberB );
    else
    {
       max = numberB; 
    }

if( max > numberC );
    else
    {
        max = numberC;
    }
Console.WriteLine("Max= {0}" ,max);