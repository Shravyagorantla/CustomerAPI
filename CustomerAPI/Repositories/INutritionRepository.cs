using CustomerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Repositories
{
    public interface INutritionRepository
    {
        IEnumerable<FoodandNutrition> GetAllNutritions();

      
    }
}
