using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eco_friendly_life_winform.Database_Backend.Controllers;
using eco_friendly_life_winform.Database_Backend.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eco_friendly_life_winform.Database_Backend.Calculator
{
    internal class CarbonFootprintCalculator
    {
        public KeyValuePair<RecipeAPI.Rootobject, double> getCarbonFootprint(RecipeAPI.Rootobject dish)
        {
            double carbonResult = 0.0;

            IngredientController ingController = new IngredientController();

            // accessing the properties of the dish we want to analyse (not really a loop)
            foreach (var obj in dish.meals)
            {

                // looping through the fix 20 ingredient properties of the dish
                for (int j = 1; j <= 20; j++)
                {

                    // accessing dynamicly the dishes strIngredient1, strIngredient2 ... etc properties
                    string ingredientName = "strIngredient" + j;
                    
                    string ingredient = (string)obj.GetType().GetProperty(ingredientName)?.GetValue(obj, null);

                    if (!string.IsNullOrEmpty(ingredient))
                    {
                        // looping through the ingredients in the database (45)
                        for (var i = 0; i < ingController.GetCount(); i++)
                        {
                            Ingredient actIngredient = ingController.getElementByIndex(i);

                            // getting the carbon footprint of the ingredients that are in the dish
                            // making it case-insensitive
                            if (ingredient != null && ingredient.IndexOf(actIngredient.IngredientName, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                carbonResult += actIngredient.CarbonFootprint;
                            }

                        }
                    }
                }
            }

            KeyValuePair<RecipeAPI.Rootobject, double> result = new KeyValuePair<RecipeAPI.Rootobject, double>(dish, carbonResult);

            return result;
        }
    }
}
