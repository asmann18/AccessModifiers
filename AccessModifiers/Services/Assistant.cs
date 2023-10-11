using AccessModifiers.Models;

namespace AccessModifiers.Services;

public class Assistant:Manager
{
    public static void GetFeedBack(Employee employee)
    {
        if(employee.IsSuccessfull)
                Manager.GetPromotion(ref employee);

    }
}
