Console.WriteLine("Ведите число A: ");
String inputA = Console.ReadLine();
int numberA = int.Parse(inputA);

Console.WriteLine("Ведите число B: ");
String inputB = Console.ReadLine();
int numberB = int.Parse(inputB);

if(numberA >= numberB) 
    Console.WriteLine( "Max= {0} ", numberA );

else{
    Console.WriteLine( "Max= {0} ",numberB );
    }

