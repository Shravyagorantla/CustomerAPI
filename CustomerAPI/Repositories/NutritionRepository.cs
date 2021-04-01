using CustomerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Repositories
{
       public class NutritionRepository : INutritionRepository
    {
        private readonly tacobellContext _context;
        public NutritionRepository(string tokenKey)
        {
        }
        public NutritionRepository(tacobellContext context)
        {
            _context = context;
        }
        public IEnumerable<FoodandNutrition> GetAllNutritions()
        {
            List<FoodDetail> foods = _context.FoodDetails.ToList();
            List<FoodandNutrition> foodandNutritions = new List<FoodandNutrition>();
            foreach (var item in _context.Nutritions)
            {
                FoodDetail foodDetail = new FoodDetail();
                foodDetail = foods.FirstOrDefault(f => f.FoodId == item.FoodId);
                if (foodDetail != null)
                {
                    foodandNutritions.Add(new FoodandNutrition
                    {
                        NutritionId = item.NutritionId,
                        FoodName = foodDetail.FoodName,
                        WeightInGrams =item.WeightInGrams,
                        Protein=item.Protein,
                        Calories=item.Calories,
                        Totalsugar=item.Totalsugar,
                        Sodium=item.Sodium,
                        Grain=item.Grain,
                        FruitorVegetable=item.FruitorVegetable,
                        Dairy=item.Dairy,
                        ProteinClassification=item.ProteinClassification
                    }) ;
                }
            }
            return foodandNutritions;
        }

        

        
    }

 
}




