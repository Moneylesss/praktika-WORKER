using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Worker> workers = new List<Worker>();
        
        Console.Write("Введите количество работников: ");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            Worker worker = new Worker();
            worker.InputData();
            workers.Add(worker);
        }
        
        Console.Write("Введите минимальный стаж работы: ");
        int minExperience = int.Parse(Console.ReadLine());
        
        bool found = false;
        foreach (var worker in workers)
        {
            if (worker.GetExperience() > minExperience)
            {
                Console.WriteLine($"Работник с большим стажем: {worker.FIO}");
                found = true;
            }
        }
        
        if (!found)
        {
            Console.WriteLine("Работников с таким стажем не найдено");
        }
    }
}
