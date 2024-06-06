using System;

class Website
{
    // Поля класса
    private string name;
    private string url;
    private string description;
    private string ipAddress;

    // Конструктор класса
    public Website(string name, string url, string description, string ipAddress)
    {
        this.name = name;
        this.url = url;
        this.description = description;
        this.ipAddress = ipAddress;
    }

    // Методы для ввода данных
    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetUrl(string url)
    {
        this.url = url;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public void SetIpAddress(string ipAddress)
    {
        this.ipAddress = ipAddress;
    }

    // Методы для вывода данных
    public string GetName()
    {
        return name;
    }

    public string GetUrl()
    {
        return url;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetIpAddress()
    {
        return ipAddress;
    }

    // Метод для вывода всех данных
    public void PrintInfo()
    {
        Console.WriteLine($"Название сайта: {name}");
        Console.WriteLine($"Путь к сайту: {url}");
        Console.WriteLine($"Описание сайта: {description}");
        Console.WriteLine($"IP адрес сайта: {ipAddress}");
    }
}

class Program
{
    static void Main()
    {
        // Пример использования класса
        Website site = new Website("Example", "http://www.example.com", "Example website", "192.168.1.1");

        // Вывод данных
        site.PrintInfo();

        // Изменение данных
        site.SetName("New Example");
        site.SetUrl("http://www.newexample.com");
        site.SetDescription("New example website");
        site.SetIpAddress("192.168.1.2");

        // Вывод обновленных данных
        site.PrintInfo();
    }
}