Console.WriteLine("Введите число- ");
int N = int.Parse(Console.ReadLine());      // Вводимое число
int i = 0;                                 // Счетчик четных значений

while( N > i & N != 1 ) {  //N не равно 1, для того чтобы не выводилось значение 2 при вводе числа 1 в терминале
        
if( N % 2 == 0 )      // Если число делится без остатка на 2 
    i = i+2;         // То записываем значение счетчика
else
{           
    N = N-1;       // Если число не делится на 2 отнимаем от него единицу
    i = i+2;      // Счетчик для того что бы отсчет всегда велся от цифры 2, как в примере к ДЗ
}                           

Console.Write(  i + " " );   // Увеличиваем наш счетчик на четное значение 2

}       





