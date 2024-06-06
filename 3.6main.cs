using System;

class Store
{
    // Поля класса
    private string name;
    private string address;
    private string profileDescription;
    private string contactPhone;
    private string contactEmail;

    // Конструктор класса
    public Store(string name, string address, string profileDescription, string contactPhone, string contactEmail)
    {
        this.name = name;
        this.address = address;
        this.profileDescription = profileDescription;
        this.contactPhone = contactPhone;
        this.contactEmail = contactEmail;
    }

    // Методы для ввода данных
    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public void SetProfileDescription(string profileDescription)
    {
        this.profileDescription = profileDescription;
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

    public string GetAddress()
    {
        return address;
    }

    public string GetProfileDescription()
    {
        return profileDescription;
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
        Console.WriteLine($"Название магазина: {name}");
        Console.WriteLine($"Адрес: {address}");
        Console.WriteLine($"Описание профиля: {profileDescription}");
        Console.WriteLine($"Контактный телефон: {contactPhone}");
        Console.WriteLine($"Контактный e-mail: {contactEmail}");
    }
}

class Program
{
    static void Main()
    {
        // Пример использования класса
        Store store = new Store("Gadget Hub", "123 Main St, Tech City", "Electronics and Gadgets", "+1-800-555-0123", "support@gadgethub.com");

        // Вывод данных
        store.PrintInfo();

        // Изменение данных
        store.SetName("New Gadget Hub");
        store.SetAddress("456 Elm St, New Tech City");
        store.SetProfileDescription("Updated Electronics and Gadgets");
        store.SetContactPhone("+1-800-555-0456");
        store.SetContactEmail("info@newgadgethub.com");

        // Вывод обновленных данных
        store.PrintInfo();
    }
}