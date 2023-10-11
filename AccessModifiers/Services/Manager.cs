using AccessModifiers.Models;

namespace AccessModifiers.Services;

public class Manager
{
    protected static Employee GetPromotion(ref Employee employee)
    {
        employee.Salary += 100;
        return employee;

    }
}
