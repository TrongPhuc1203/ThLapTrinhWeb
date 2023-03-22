using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

using ThucHanh_Bai3_02.DTOs;
using ThucHanh_Bai3_02.Models;

namespace ThucHanh_Bai3_02.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;

        public AttendancesController()
        { 
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]//  [FromBody] int courseId
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        { 
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a=>a.AttendeeId == userId && a.CourseId==attendanceDto.CourseId))
                return BadRequest("The Attendance already exists!");

            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                //AttendeeId = User.Identity.GetUserId()
                AttendeeId = userId
            };

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
