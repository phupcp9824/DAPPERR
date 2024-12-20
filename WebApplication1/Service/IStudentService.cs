using DAPPERR.Entities;
using WebApplication1.Repository;

namespace WebApplication1.Service
{
    public interface IStudentService
    {
        public Task<List<Student>> GetformRequest();    
    }

    public class StudentService(ISmartStore smartStore) : IStudentService
    {

        public async Task<List<Student>> GetformRequest()
        {
            string parameter = "students";
            string condition = "Address = N'123 Main Street'";
            string colums = " StudentId, Name, Age, Phone";
            var param = new { parameter, condition, colums };
            var data = await smartStore.GetListObjectAsync<Student>("GetData", param);
            return data;
        }



        //public async Task<List<Student>> GetformRequest()
        //{
        //    string query = @"SELECT StudentId, Name, Address, Phone FROM Student";
        //    var parameters = new { query };
        //    // Chỉ sử dụng tên của stored procedure
        //    var data = await smartStore.GetListObjectAsync<Student>("GetData", parameters);
        //    return data;
        //}


    }

}
