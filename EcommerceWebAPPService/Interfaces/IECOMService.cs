using EcommerceWebAPPService.Model;
namespace EcommerceWebAPPService.Service
{
    public interface IECOMService<T>
    {
        List<T> GetAllList();
        T GetDetailsById(int empId);
        ResponseModel SaveItem(T model);
        ResponseModel DeleteItem(int employeeId);
    }
}
