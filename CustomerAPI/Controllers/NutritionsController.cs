using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomerAPI.Models;
using CustomerAPI.Repositories;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionsController : ControllerBase
    {
        private readonly INutritionRepository _context;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(NutritionsController));


        public NutritionsController(INutritionRepository context)
        {
            _context = context;
        }

        // GET: api/Nutritions
        [HttpGet]
        public  IEnumerable<FoodandNutrition> GetNutritions()
        {
            return  _context.GetAllNutritions();
        }



       

    }
}
