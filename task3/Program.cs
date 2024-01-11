using System;
void task3 (){
    int number = new Random().Next(10, 100);
    Console.WriteLine($"{number}");
    int part1 = number % 10;
    int part2 = number / 10;
    
    if (part1 > part2){
        Console.WriteLine($"вторая цифра больше первой");
    }
    else if (part2 > part1){
         Console.WriteLine($"первая цифра больше второй");
     }
    else{
         Console.WriteLine($"цифры числа равны");
    }
}
task3();