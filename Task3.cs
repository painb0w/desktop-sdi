using System;
using System.Collections.Generic;
using Bogus;
using System.Linq;

public class Employee
{
    public string FullName { get; set; }
    public List<Order> Orders { get; set; }
}

public class Order
{
    public DateTime OrderDate { get; set; }
    public decimal OrderAmount { get; set; }
}

public static class DataGenerator
{
    public static List<Employee> GenerateEmployees(int employeeCount)
    {
        var employeeFaker = new Faker<Employee>("ru") 
            .RuleFor(e => e.FullName, f => f.Name.FullName()); 

        var orderFaker = new Faker<Order>("ru")
            .RuleFor(o => o.OrderDate, f => f.Date.Past(1)) 
            .RuleFor(o => o.OrderAmount, f => f.Finance.Amount(10, 10000)); 

        var employees = new List<Employee>();

        for (int i = 0; i < employeeCount; i++)
        {
            var orders = orderFaker.Generate(50 + new Random().Next(50)); 
            var employee = employeeFaker.Generate(); 
            employee.Orders = orders; 

            employees.Add(employee);
        }

        return employees;
    }
}


public static class DataProcessor
{
    // фильтрация сотрудников по ФИО
    public static List<Order> FilterOrdersByNameLINQ(List<Employee> employees, string filterText, string filterType)
    {
        return employees
            .Where(e => filterType == "Contains" ? e.FullName.Contains(filterText) :
                        filterType == "Starts with" ? e.FullName.StartsWith(filterText) :
                        e.FullName == filterText)
            .SelectMany(e => e.Orders)
            .ToList();
    }

    public static List<Order> FilterOrdersByNamePLINQ(List<Employee> employees, string filterText, string filterType)
    {
        return employees
            .AsParallel()
            .Where(e => filterType == "Contains" ? e.FullName.Contains(filterText) :
                        filterType == "Starts with" ? e.FullName.StartsWith(filterText) :
                        e.FullName == filterText)
            .SelectMany(e => e.Orders)
            .ToList();
    }

    // фильтрация заказов по дате
    public static List<Order> FilterOrdersByDateLINQ(List<Employee> employees, DateTime date, string filterType)
    {
        return employees
            .SelectMany(e => e.Orders)
            .Where(o => filterType == "Before" ? o.OrderDate <= date : o.OrderDate >= date)
            .ToList();
    }

    public static List<Order> FilterOrdersByDatePLINQ(List<Employee> employees, DateTime date, string filterType)
    {
        return employees
            .AsParallel()
            .SelectMany(e => e.Orders)
            .Where(o => filterType == "Before" ? o.OrderDate <= date : o.OrderDate >= date)
            .ToList();
    }

    // cортировка сотрудников по средней сумме заказа
    public static List<Employee> SortEmployeesByAverageOrderLINQ(List<Employee> employees, bool ascending)
    {
        return ascending
            ? employees.OrderBy(e => e.Orders.Average(o => o.OrderAmount)).ToList()
            : employees.OrderByDescending(e => e.Orders.Average(o => o.OrderAmount)).ToList();
    }

    public static List<Employee> SortEmployeesByAverageOrderPLINQ(List<Employee> employees, bool ascending)
    {
        return ascending
            ? employees.AsParallel().OrderBy(e => e.Orders.Average(o => o.OrderAmount)).ToList()
            : employees.AsParallel().OrderByDescending(e => e.Orders.Average(o => o.OrderAmount)).ToList();
    }
}



