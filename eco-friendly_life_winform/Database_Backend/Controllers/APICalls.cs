using Azure;
using eco_friendly_life_winform.Database_Backend.Calculator;
using eco_friendly_life_winform.Database_Backend.Tables;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static eco_friendly_life_winform.Database_Backend.Tables.RecipeAPI;

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
            var response2 = client.Execute(request2);
            List<RecipeAPI.Meal> chickenMeals = new List<RecipeAPI.Meal>();

            var request3 = new RestRequest("filter.php?c=Lamb");
            var response3 = client.Execute(request3);
            List<RecipeAPI.Meal> lambMeals = new List<RecipeAPI.Meal>();

            var request4 = new RestRequest("filter.php?c=Pork");
            var response4 = client.Execute(request4);
            List<RecipeAPI.Meal> porkMeals = new List<RecipeAPI.Meal>();

            var request5 = new RestRequest("filter.php?c=Seafood");
            var response5 = client.Execute(request5);
            List<RecipeAPI.Meal> seafoodMeals = new List<RecipeAPI.Meal>();

            var request6 = new RestRequest("filter.php?c=Goat");
            var response6 = client.Execute(request6);
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

                    foreach (var obj in lambResult.meals)
                    {
                        resultList.Add(obj);
                    }

                    foreach (var obj in seafoodResult.meals)
                    {
                        resultList.Add(obj);
                    }

                    foreach (var obj in goatResult.meals)
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
            // List<RecipeAPI.Meal> resultList = new List<RecipeAPI.Meal>();

            string miabajabamar = "";
            foreach(var i in ingredients)
            {
                miabajabamar += i;
            }
            MessageBox.Show(miabajabamar);
            // Dictionary to count how many times we would add the meal to the list
            // (if the same dish contains two of the wanted ingredients it would be added twice)
            Dictionary<RecipeAPI.Meal, int> resultList = new Dictionary<RecipeAPI.Meal, int>(); 
            List<RecipeAPI.Rootobject> wholeDishData = new List<RecipeAPI.Rootobject>();
            RecipeAPI.Rootobject ing1Result;
            RecipeAPI.Rootobject ing2Result;
            RecipeAPI.Rootobject ing3Result;

            
            string restRequest1 = "filter.php?i=" + ingredients[0].ToLower();
            var request1 = new RestRequest(restRequest1);
            var response1 = client.Execute(request1);

            // we're sure the array has at least one element because we're only calling it then
            // but we have to check if it has a second and third element too

            string elso_szures = ingredients[0] + ": ";
            if (response1.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string ing1rawResponse = response1.Content;

                ing1Result = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(ing1rawResponse);

                if (ing1Result != null)
                {
                    foreach(var obj in ing1Result.meals)
                    {
                        // at first every meal would get in
                        resultList.Add(obj, 1);
                        elso_szures += obj.strMeal + ", ";
                    }
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

            MessageBox.Show(elso_szures);

            int counter = 0;
            foreach (var ing in ingredients)
            {
                if (ing != null)
                {
                    counter++;
                }
            }

            string masodik_szures =ingredients[1] + ": ";
            // we have to filter by two ingredients
            if (ingredients[1] != String.Empty)
            {
                string restRequest2 = "filter.php?i=" + ingredients[1].ToLower();
                var request2 = new RestRequest(restRequest2);
                var response2 = client.Execute(request2);

                if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string ing2rawResponse = response2.Content;

                    ing2Result = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(ing2rawResponse);

                    // ok problem is the key should be the strID not the whole object 
                    //MessageBox.Show(ing2Result.meals[0].ToString());
                    //MessageBox.Show(resultList.First().Key.ToString());
                    

                    if (ing2Result != null)
                    {
                        foreach (var obj in ing2Result.meals)
                        {
                            // TODO ez meg nem mukodik a masodik harmadik hozzavalo alapjan nem szur
                            //                          // duck, fish, turkey, shrimp, beans, olives, cherries, yogurt, flour, mushroom, pasta, paste, chocolate

                            resultList.Add(obj, 1);
                            masodik_szures += obj.strMeal + ", ";
                            /*
                            // if the dish is already in the dictionary we just add one to the number
                            if (resultList.ContainsKey(obj))
                            {
                                // If the dish is already in the dictionary, increment the count
                                resultList[obj]++;
                                masodik_szures += "masododjara lenne hozzaadva: " + obj.strMeal + ", ";
                            }
                            else
                            {
                                // If the dish is not in the dictionary, add it with a count of 1
                                resultList.Add(obj, 1);
                                masodik_szures += obj.strMeal + ", ";
                            }
                            */
        }
    }
                    else
                    {
                        throw new Exception("Don't have any data");
                    }
                }
            }
            MessageBox.Show(masodik_szures);
            

            string harmadik_szures = ingredients[2] + ": ";
            if (ingredients[2] != String.Empty) 
            {
                string restRequest3 = "filter.php?i=" + ingredients[2].ToLower();
                var request3 = new RestRequest(restRequest3);
                var response3 = client.Execute(request3);

                if (response3.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string ing3rawResponse = response3.Content;

                    ing3Result = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(ing3rawResponse);

                    if (ing3Result != null)
                    {
                        foreach (var obj in ing3Result.meals)
                        {
                            /*
                            if (resultList.ContainsKey(obj))
                            {
                                // if the dish is already in the dictionary, increment the count
                                resultList[obj]++;
                                harmadik_szures += "tobbedjera lenne hozzaadva: " + obj.strMeal + ", ";
                            }
                            else
                            {
                                // if the dish is not in the dictionary, add it with a count of 1
                                resultList.Add(obj, 1);
                                harmadik_szures += obj.strMeal + ", ";
                            }
                            */
                            resultList.Add(obj, 1);
                            harmadik_szures += obj.strMeal + ", ";
                        }
                    }
                    else
                    {
                        throw new Exception("Don't have any data");
                    }
                }
            }
            MessageBox.Show(harmadik_szures);

            // putting the filtered meals in a dictionary where the key is the meals id
            // and the value is how many wanted ingredient is int the dish
            Dictionary<string, int> resultdict = new Dictionary<string, int>();
            int szamlalo = 0;
            string pls = "tobbszor benne van: ";
            foreach(var d in resultList)
            {
                if(resultdict.ContainsKey(d.Key.idMeal))
                {
                    resultdict[d.Key.idMeal]++;
                    szamlalo++;
                    pls += d.Key.strMeal + ", ";
                }
                else
                {
                    resultdict.Add(d.Key.idMeal, 1);
                }
                
            }
            MessageBox.Show(szamlalo.ToString() + " " + pls);

            /*
            string debug2 = "";
            foreach (var akarmi in resultList)
            {
                debug2 += akarmi.Key.strMeal + "-" + akarmi.Value.ToString() + ", ";
            }

            string debug3 = "";
            foreach (var akarmi in resultdict)
            {
                debug3 += akarmi.Key + "-" + akarmi.Value.ToString() + ", ";
            }
            */
            //MessageBox.Show("resultList: " + debug2);
            //MessageBox.Show("resultdict: " + debug3);

            //MessageBox.Show(harmadik_szures);

            // sort the dictionary by value in decreasing order
            // so the dishes with the most matches get on the top of the list

            var sortedResultList = resultdict.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);

            string debug = "";
            foreach (var result in sortedResultList) 
            {
                debug += result.Key + " " + result.Value.ToString() + ", ";
            }

            int maxValue = sortedResultList.Values.First();

            // Count how many elements have the maximum value
            int maxCount = sortedResultList.Values.Count(value => value == maxValue);

            // if there's only one recipe with multiple wanted ingredient we offer that one
            if(maxCount == 1)
            {
                // converting the short recipe to a full one
                RecipeAPI.Rootobject meal = getRecipeById(sortedResultList.First().Key);
                wholeDishData.Add(meal);
            }
            // but if there are multiple recipes with the same number of wanted ingredient
            // (f.e.: 5 meals contain 3 of the preffered ingredients) we have to sort them according to their carbon footprint
            else
            {
                // Get the first x elements that have the same value (max)
                var maxElements = sortedResultList.Take(maxCount);

                // converting the short recipes to full ones
                // we call the sorting algorithm in Form1.cs file
                foreach(var element in maxElements)
                {
                    RecipeAPI.Rootobject meal = getRecipeById(element.Key);
                    wholeDishData.Add(meal);
                }

            }

            MessageBox.Show("sorted: " + debug);

           
            //RecipeAPI.Rootobject meal = getRecipeById(sortedResultList.First().Key);
            


            return wholeDishData;
        }
    }
}
