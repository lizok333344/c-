using System;

class Journal
{
    // Поля класса
    private string name;
    private int yearFounded;
    private string description;
    private string contactPhone;
    private string contactEmail;

    // Конструктор класса
    public Journal(string name, int yearFounded, string description, string contactPhone, string contactEmail)
    {
        this.name = name;
        this.yearFounded = yearFounded;
        this.description = description;
        this.contactPhone = contactPhone;
        this.contactEmail = contactEmail;
    }

    // Методы для ввода данных
    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetYearFounded(int yearFounded)
    {
        this.yearFounded = yearFounded;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public void SetContactPhone(string contactPhone)
    {
        this.contactPhone = contactPhone;
    }

    public void SetContactEmail(string contactEmail)
    {
        this.contactEmail = contactEmail;
    }

    // Методы для вывода данных
    public string GetName()
    {
        return name;
    }

    public int GetYearFounded()
    {
        return yearFounded;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public string GetContactEmail()
    {
        return contactEmail;
    }

    // Метод для вывода всех данных
    public void PrintInfo()
    {
        Console.WriteLine($"Название журнала: {name}");
        Console.WriteLine($"Год основания: {yearFounded}");
        Console.WriteLine($"Описание журнала: {description}");
        Console.WriteLine($"Контактный телефон: {contactPhone}");
        Console.WriteLine($"Контактный e-mail: {contactEmail}");
    }
}

class Program
{
    static void Main()
    {
        // Пример использования класса
        Journal journal = new Journal("Tech Times", 1995, "Technology and Innovation", "+1-800-555-0199", "info@techtimes.com");

        // Вывод данных
        journal.PrintInfo();

        // Изменение данных
        journal.SetName("New Tech Times");
        journal.SetYearFounded(2000);
        journal.SetDescription("Updated Technology and Innovation");
        journal.SetContactPhone("+1-800-555-0200");
        journal.SetContactEmail("contact@newtechtimes.com");

        // Вывод обновленных данных
        journal.PrintInfo();
    }
}