Console.WriteLine("Введите число- ");
string input = Console.ReadLine();
int number = int.Parse( input );

if( number % 2 == 0 )
Console.WriteLine("Число {0} четное=))", number);    
    else
    {
        Console.WriteLine("Число {0} нечетное!", number);
    }
