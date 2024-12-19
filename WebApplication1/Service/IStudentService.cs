using WebApplication1.Entities;
using WebApplication1.Repository;

namespace WebApplication1.Service
{
    public interface IStudentService
    {
        public Task<List<Student>> GetList();
    }

    public class StudentService(ISmartStore smartStore) : IStudentService
    {
        public async Task<List<Student>> GetList()
        {
            string parameter = "students";
            string condition = "Address = N'123 Main Street'";  
            var param = new {parameter,  condition };
            var data = await smartStore.GetListObjectAsync<Student>("GetData", param);
            return data;
        }
    }

}
