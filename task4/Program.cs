using System;
void task4 (int number){
    int part2 = 1;
      while (part2 !=0){
        int part1 = number % 10;
        part2 = number / 10;
        if (part2 == 0){
            Console.Write($"{part1}. ");
        }
        else{
            Console.Write($"{part1}, ");
        }
        number = part2;
    }
}
task4(123);