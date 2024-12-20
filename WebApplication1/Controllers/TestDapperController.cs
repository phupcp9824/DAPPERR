using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repository;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDapperController(ISmartStore _smartStore) : ControllerBase
    {
        [HttpGet("getdata")]
        public async Task<IActionResult> GetData(string tableName, string condition = null, string columns = null)
        {
            try
            {
                var param = new { Parameter = "students", Condition = condition, Colums = tableName };
                var results = await _smartStore.GetListObjectAsync<object>("GetData", param);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
    }
}