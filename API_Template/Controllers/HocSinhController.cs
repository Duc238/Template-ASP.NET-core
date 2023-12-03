using Data;
using Microsoft.AspNetCore.Mvc;

namespace API_Template.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HocSinhController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<HocSinhController> _logger;

        public HocSinhController(ILogger<HocSinhController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<HocSinhDetail> Get()
        {
            return new List<HocSinhDetail> {
                new HocSinhDetail { Id=1,Name="Vương Vũ Tiệp"},
                new HocSinhDetail { Id=2,Name="Maragret Wang"},
                new HocSinhDetail { Id=3,Name="卢英雄"},
                new HocSinhDetail {Id=4,Name="Võ Tấn Đức"}
            };
        }
        [HttpGet("{id}")]
        public HocSinhDetail Get(int id)
        {
            if(id==1)
            {
                return new HocSinhDetail() { Id = 1, Name = "Vương Vũ Tiệp" };

            }
            else if(id==2)
            {
                return new HocSinhDetail() { Id = 2, Name = "Maragret Wang" };
            }
            else if(id==3)
            {
                return new HocSinhDetail() { Id = 3, Name = "卢英雄" };
            }
            else
            {
                return new HocSinhDetail() { Id = 4, Name = "Võ Tấn Đức" };
            }
        }
    }
}