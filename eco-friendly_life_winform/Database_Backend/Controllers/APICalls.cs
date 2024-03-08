using eco_friendly_life_winform.Database_Backend.Tables;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eco_friendly_life_winform.Database_Backend.Controllers
{
    internal class APICalls
    {
        RestClient client = new RestClient("https://themealdb.com/api/json/v1/1/");
        RecipeAPI.Rootobject result;

        public RecipeAPI.Rootobject randomRecipeCall()
        {
            var request = new RestRequest("random.php");
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                result = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(rawResponse);

                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Don't have any data");
                }
            }
            else
            {
                throw new Exception("Can't reach API");
            }
        }

        public RecipeAPI.Rootobject getRecipeByNameCall(string recipeName)
        {
            RecipeAPI.Rootobject resultRecipe;

            string str = "s=" + recipeName;

            var request = new RestRequest(str);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                resultRecipe = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(rawResponse);

                if (resultRecipe != null)
                {
                    return resultRecipe;
                }
                else
                {
                    throw new Exception("Don't have any data");
                }
            }
            else
            {
                throw new Exception("Can't reach API");
            }
        }

        public RecipeAPI.Rootobject getRecipeById(string id)
        {
            string restRequest = "lookup.php?i=" + id;
            var request = new RestRequest(restRequest);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                result = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(rawResponse);

                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Don't have any data");
                }
            }
            else
            {
                throw new Exception("Can't reach API");
            }

        }


        // meals with no meat (vegan + vegetarian)
        public List<RecipeAPI.Rootobject> vegetarianRecipeCall()
        {
            List<RecipeAPI.Meal> resultList = new List<RecipeAPI.Meal>();

            RecipeAPI.Rootobject vegaResult;
            RecipeAPI.Rootobject veganResult;
            List<RecipeAPI.Rootobject> wholeDishData = new List<RecipeAPI.Rootobject>();

            // vegetarian meals data call

            var request1 = new RestRequest("filter.php?c=Vegetarian");
            var response1 = client.Execute(request1);
            List<RecipeAPI.Meal> vegaMeals = new List<RecipeAPI.Meal>();

            // vegan meals data call

            var request2 = new RestRequest("filter.php?c=Vegan");
            var response2 = client.Execute(request2);
            List<RecipeAPI.Meal> veganMeals = new List<RecipeAPI.Meal>();

            // these API Calls dont return the whole meal only 3 properties
            //"strMeal": "Baingan Bharta",
            //"strMealThumb": "https://www.themealdb.com/images/media/meals/urtpqw1487341253.jpg",
            //"idMeal": "52807"

            if (response1.StatusCode == System.Net.HttpStatusCode.OK
                && response2.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string vegaRawResponse = response1.Content;
                string veganRawResponse = response2.Content;

                vegaResult = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(vegaRawResponse);
                veganResult = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(veganRawResponse);

                if (vegaResult != null && veganResult != null)
                {
                    foreach (var obj in vegaResult.meals)
                    {
                        resultList.Add(obj);
                    }

                    foreach (var obj in veganResult.meals)
                    {
                        resultList.Add(obj);
                    }

                    foreach (var dish in resultList)
                    {

                        // converting the short recipes to full ones
                        RecipeAPI.Rootobject meal = getRecipeById(dish.idMeal);
                        wholeDishData.Add(meal);
                    }

                    return wholeDishData;

                }
                else
                {
                    throw new Exception("Don't have any data");
                }
            }
            else
            {
                throw new Exception("Can't reach API");
            }
        }
    }
}
