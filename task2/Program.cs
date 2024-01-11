using System;
void task2 (int x, int y){
    if(x>0 && y>0){
        Console.WriteLine($"точка в первой четверти");
    }
    else if(x<0 && y>0){
        Console.WriteLine($"точка во второй четверти");
    }
    else if(x<0 && y<0){
        Console.WriteLine($"точка в третьей четверти");
    }
    else if(x>0 && y<0){
        Console.WriteLine($"точка в четвертой четверти");
    }
}
task2(-1, 1);