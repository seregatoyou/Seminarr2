using System;
void task (int number){
    if (number % 7 == 0 && number % 23 == 0){
        Console.WriteLine($"Число одновременно кратно 7и и 23м.");
    }
    else if (number % 7 == 0){
        Console.WriteLine($"Число кратно 7и.");
    }
    else if (number % 23 == 0){
        Console.WriteLine($"Число кратно 23м.");
    }
    else {
        Console.WriteLine($"Число не кратно ни 7и, ни 23м");
    }
}
task(41);