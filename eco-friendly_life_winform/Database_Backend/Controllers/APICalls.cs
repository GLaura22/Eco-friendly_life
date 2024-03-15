using Azure;
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

            string str = "search.php?s=" + recipeName;

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

        public List<RecipeAPI.Rootobject> getMeatyRecipes()
        {
            // recipes with meat in them
            List<RecipeAPI.Meal> resultList = new List<RecipeAPI.Meal>();

            RecipeAPI.Rootobject beefResult;
            RecipeAPI.Rootobject chickenResult;
            RecipeAPI.Rootobject lambResult;
            RecipeAPI.Rootobject porkResult;
            RecipeAPI.Rootobject seafoodResult;
            RecipeAPI.Rootobject goatResult;

            // all the dishes with meat in them in full format
            List<RecipeAPI.Rootobject> wholeDishData = new List<RecipeAPI.Rootobject>();

            var request1 = new RestRequest("filter.php?c=Beef");
            var response1 = client.Execute(request1);
            List<RecipeAPI.Meal> beefMeals = new List<RecipeAPI.Meal>();

            var request2 = new RestRequest("filter.php?c=Chicken");
            var response2 = client.Execute(request1);
            List<RecipeAPI.Meal> chickenMeals = new List<RecipeAPI.Meal>();

            var request3 = new RestRequest("filter.php?c=Lamb");
            var response3 = client.Execute(request1);
            List<RecipeAPI.Meal> lambMeals = new List<RecipeAPI.Meal>();

            var request4 = new RestRequest("filter.php?c=Pork");
            var response4 = client.Execute(request1);
            List<RecipeAPI.Meal> porkMeals = new List<RecipeAPI.Meal>();

            var request5 = new RestRequest("filter.php?c=Seafood");
            var response5 = client.Execute(request1);
            List<RecipeAPI.Meal> seafoodMeals = new List<RecipeAPI.Meal>();

            var request6 = new RestRequest("filter.php?c=Goat");
            var response6 = client.Execute(request1);
            List<RecipeAPI.Meal> goatMeals = new List<RecipeAPI.Meal>();


            if (response1.StatusCode == System.Net.HttpStatusCode.OK
               && response2.StatusCode == System.Net.HttpStatusCode.OK
               && response3.StatusCode == System.Net.HttpStatusCode.OK
               && response4.StatusCode == System.Net.HttpStatusCode.OK
               && response5.StatusCode == System.Net.HttpStatusCode.OK
               && response6.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string beefRawResponse = response1.Content;
                string chickenRawResponse = response2.Content;
                string lambRawResponse = response3.Content;
                string porkRawResponse = response4.Content;
                string seafoodRawResponse = response5.Content;
                string goatRawResponse = response6.Content;
                

                beefResult = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(beefRawResponse);
                chickenResult = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(chickenRawResponse);
                lambResult = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(lambRawResponse);
                porkResult = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(porkRawResponse);
                seafoodResult = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(seafoodRawResponse);
                goatResult = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(goatRawResponse);

                if (beefResult != null && chickenResult != null
                     && lambResult != null && porkResult != null
                      && seafoodResult != null && goatResult != null)
                {
                    foreach (var obj in beefResult.meals)
                    {
                        resultList.Add(obj);
                    }

                    foreach (var obj in chickenResult.meals)
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

        public List<RecipeAPI.Rootobject> getRecipeByIngredients(string[] ingredients)
        {
            // recipes that contain all the ingredients passed on by the ingredients array
            List<RecipeAPI.Rootobject> resultList = new List<RecipeAPI.Rootobject>();

            //foreach (var recipe in recipes)
            //{
            //    bool hasAllIngredients = true;
            //    foreach (var ingredient in recipe.Value)
            //    {
            //        if (!ingredients.Contains(ingredient))
            //        {
            //            hasAllIngredients = false;
            //            break;
            //        }
            //    }
            //    if (hasAllIngredients)
            //        return $"Recommended recipe: {recipe.Key}";
            //}

            //return "No recipe found matching provided ingredients";

            return resultList;
        }
    }
}
