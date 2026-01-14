using System;

public class Worker
{
    // Поля класса
    private string fio;
    private string position;
    private decimal salary;
    private int yearStartWork;
    
    // Конструктор по умолчанию
    public Worker()
    {
        fio = "Не указано";
        position = "Не указано";
        salary = 0;
        yearStartWork = 0;
    }
    
    // Конструктор с параметрами
    public Worker(string fio, string position, decimal salary, int yearStartWork)
    {
        this.fio = fio;
        this.position = position;
        this.salary = salary;
        this.yearStartWork = yearStartWork;
    }
    
    // Деструктор
    ~Worker()
    {
        Console.WriteLine($"Объект {fio} уничтожен");
    }
    
    // Свойства для доступа к полям
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
    
    // Метод для ввода данных
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
    
    // Метод для отображения данных
    public void ShowInfo()
    {
        Console.WriteLine($"ФИО: {fio}");
        Console.WriteLine($"Должность: {position}");
        Console.WriteLine($"Зарплата: {salary}");
        Console.WriteLine($"Год начала работы: {yearStartWork}");
    }
    
    // Метод расчета стажа
    public int GetExperience()
    {
        return DateTime.Now.Year - yearStartWork;
    }
}
