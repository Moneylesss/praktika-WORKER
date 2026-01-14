using System;

public class Worker
{
    private string fio;
    private string position;
    private decimal salary;
    private int yearStartWork;
    
    public Worker()
    {
        fio = "Не указано";
        position = "Не указано";
        salary = 0;
        yearStartWork = 0;
    }
    
    public Worker(string fio, string position, decimal salary, int yearStartWork)
    {
        this.fio = fio;
        this.position = position;
        this.salary = salary;
        this.yearStartWork = yearStartWork;
    }
    
    ~Worker()
    {
        Console.WriteLine($"Объект {fio} уничтожен");
    }
    
    public string FIO 
    {
        get { return fio; }
        set { fio = value; }
    }
    
    public string Position 
    {
        get { return position; }
        set { position = value; }
    }
    
    public decimal Salary 
    {
        get { return salary; }
        set { salary = value; }
    }
    
    public int YearStartWork 
    {
        get { return yearStartWork; }
        set { yearStartWork = value; }
    }
    
    public void InputData()
    {
        Console.Write("Введите ФИО: ");
        fio = Console.ReadLine();
        
        Console.Write("Введите должность: ");
        position = Console.ReadLine();
        
        Console.Write("Введите зарплату: ");
        salary = decimal.Parse(Console.ReadLine());
        
        Console.Write("Введите год начала работы: ");
        yearStartWork = int.Parse(Console.ReadLine());
    }
    
    public void ShowInfo()
    {
        Console.WriteLine($"ФИО: {fio}");
        Console.WriteLine($"Должность: {position}");
        Console.WriteLine($"Зарплата: {salary}");
        Console.WriteLine($"Год начала работы: {yearStartWork}");
    }
    
    public int GetExperience()
    {
        return DateTime.Now.Year - yearStartWork;
    }
}
