using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Olx_Proj.Data;
using Olx_Proj.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olx_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OlxController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public OlxController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Categories> GetCategories() {

            return _context.Categories.ToList();
        }
    }
}
