using eco_friendly_life_winform.Database_Backend.Tables;
using eco_friendly_life_winform.Database_Backend.Controllers;
using RestSharp;
using Newtonsoft;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Net;
using eco_friendly_life_winform.Database_Backend.Calculator;
using Newtonsoft.Json.Linq;
using System.Diagnostics.Metrics;

namespace eco_friendly_life_winform
{
    public partial class Form1 : Form
    {

        RecipeAPI.Rootobject result;

        public Form1()
        {
            InitializeComponent();
            mainWindowPanel.Visible = true;
            RecipePanel.Visible = false;
            TippPanel.Visible = false;
            resultPanel.Visible = false;
        }


        private void recipeSuggestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainWindowPanel.Visible = false;
            TippPanel.Visible = false;
            RecipePanel.Visible = true;
            resultPanel.Visible = false;
            ingredientComboBox1.Items.Clear();

            IngredientController ingredientController = new();

            List<Ingredient> ingredients = ingredientController.GetItems();

            
            for (int i = 0; i < 45; i++)
            {
                ingredientComboBox1.Items.Add(ingredients[i].IngredientName.ToString());
            }
            
            for (int i = 0; i < 45; i++)    
            {
                ingredientComboBox2.Items.Add(ingredients[i].IngredientName.ToString());
            }
            
            for (int i = 0; i < 45; i++) 
            {
                ingredientComboBox3.Items.Add(ingredients[i].IngredientName.ToString());
            }

        }


        private void tippsAndTricksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainWindowPanel.Visible = false;
            RecipePanel.Visible = false;
            TippPanel.Visible = true;

            TippController tippController = new();

            List<Tipp> tipps = new List<Tipp>();
            tipps = tippController.GetTipps();

            Random rnd = new Random();
            int num = rnd.Next(0, tipps.Count());

            todaysTippTextBox.Text = tipps[num].TippName;
        }

        private void generalasButton_Click(object sender, EventArgs e)
        {
            string wantedIngredient1 = string.Empty;
            string wantedIngredient2 = string.Empty;
            string wantedIngredient3 = string.Empty;

            wantedIngredient1 = ingredientComboBox1.Text;
            wantedIngredient2 = ingredientComboBox2.Text;
            wantedIngredient3 = ingredientComboBox3.Text;


            string tipus = string.Empty;

            // there is no preffered ingredient

            if ("" == wantedIngredient1 && "" == wantedIngredient2 && "" == wantedIngredient3)
            {

                // only vegetarian dishes
                if(noMeatRadioButton.Checked) 
                {
                    noMeatAllIngredients();
                }
                //meaty dishes
                else if (meatRadioButton.Checked)
                {
                    meatAllIngredients();
                }

            }

            // there are some preffered ingredients
            else 
            {
                string[] wantedIngredients = { wantedIngredient1, wantedIngredient2, wantedIngredient3 };

                prefferedIngredients(wantedIngredients);                
            }

        }

        private void prefferedIngredients(string[] ingredients)
        {
            List<RecipeAPI.Rootobject> filteredListResult = new List<RecipeAPI.Rootobject>();
            APICalls apiCall = new APICalls();
            CarbonFootprintCalculator crbFtprnt = new CarbonFootprintCalculator();

            filteredListResult = apiCall.getRecipeByIngredients(ingredients);

            // if there's only one element that have mutliple ingredients in it this list contains only one dish 
            Dictionary<RecipeAPI.Rootobject, double> mealswithFootprint = new Dictionary<RecipeAPI.Rootobject, double>();

            double carbonFootprint = -1.0;
            foreach (var dish in filteredListResult)
            {
                // we collect the dishes carbon footprint in the dict
                KeyValuePair<RecipeAPI.Rootobject, double> actmealwithFootprint = new KeyValuePair<RecipeAPI.Rootobject, double>();
                actmealwithFootprint = crbFtprnt.getCarbonFootprint(dish);
                mealswithFootprint.Add(actmealwithFootprint.Key, actmealwithFootprint.Value);
            }

            // sorting the list in decreasing order by the value of the carbon footprints
            mealswithFootprint = mealswithFootprint.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            // ---------------------------- debug ----------------------------------------------------------
            string szenvedes = "tobb etel is van amiben tobb hozzavalo is szerepel: ";

            foreach(var kvp in mealswithFootprint) 
            {
                szenvedes += "(" + kvp.Key.meals[0].strMeal + " - " + kvp.Value.ToString() + "), ";
            }

            MessageBox.Show(szenvedes);
            // ---------------------------- debug vege ----------------------------------------------------------

            result = mealswithFootprint.First().Key;
            carbonFootprint = mealswithFootprint.First().Value;

            resultPanel.Visible = true;
            resultRecipeLabel.Text = result.meals[0].strMeal;
            string formattedValue = carbonFootprint.ToString("0.00");   // only 2 digits should be displayed
            carbonFootprintLabel.Text = formattedValue + " CO2eq/kg";
            //MessageBox.Show("lefutott");

            // loading in actual meals image
            loadInImage(result.meals[0].strMealThumb, resultPictureBox);


        }

        private void meatAllIngredients()
        {
            List<RecipeAPI.Rootobject> meatyListResult = new List<RecipeAPI.Rootobject>();
            APICalls apiCall = new APICalls();
            CarbonFootprintCalculator crbFtprnt = new CarbonFootprintCalculator();

            meatyListResult = apiCall.getMeatyRecipes();

            Dictionary<RecipeAPI.Rootobject, double> mealsWithCarbonfootprint = new Dictionary<RecipeAPI.Rootobject, double>();

            // getting the carbon footprint of every meal that contains meat
            foreach (var obj in meatyListResult)
            {
                KeyValuePair<RecipeAPI.Rootobject, double> mealwithFootprint = crbFtprnt.getCarbonFootprint(obj);
                mealsWithCarbonfootprint.Add(mealwithFootprint.Key, mealwithFootprint.Value);
            }


            // sorting the list in decreasing order by the value of the carbon footprints
            mealsWithCarbonfootprint = mealsWithCarbonfootprint.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            // --------------------------------------------------------

            // saving the result to public variable 
            result = mealsWithCarbonfootprint.First().Key;

            string meatyResultName = "";
            double carbonFootprintResult = -1.0;
            string measurement = "CO2eq/kg";
            meatyResultName = result.meals[0].strMeal;
            carbonFootprintResult = mealsWithCarbonfootprint.First().Value;
            //vegetarianResult += noMeatListResult[1].meals[0].strMeal;


            resultPanel.Visible = true;
            resultRecipeLabel.Text = meatyResultName;
            string formattedValue = carbonFootprintResult.ToString("0.00");   // only 2 digits should be displayed
            carbonFootprintLabel.Text = formattedValue + " " + measurement;
            //MessageBox.Show("lefutott");

            // loading in actual meals image
            loadInImage(result.meals[0].strMealThumb, resultPictureBox);

        }

        private void noMeatAllIngredients()
        {
            //List<RecipeAPI.Meal> result_list = new List<RecipeAPI.Meal>();
            List<RecipeAPI.Rootobject> noMeatListResult = new List<RecipeAPI.Rootobject>();

            APICalls apiCall = new APICalls();
            CarbonFootprintCalculator crbFtprnt = new CarbonFootprintCalculator();

            noMeatListResult = apiCall.vegetarianRecipeCall();

            Dictionary<RecipeAPI.Rootobject, double> mealsWithCarbonfootprint = new Dictionary<RecipeAPI.Rootobject, double>();

            // getting the carbon footprint of every meal that does not contain meat
            foreach (var obj in noMeatListResult)
            {
                KeyValuePair<RecipeAPI.Rootobject, double> mealwithFootprint = crbFtprnt.getCarbonFootprint(obj);
                mealsWithCarbonfootprint.Add(mealwithFootprint.Key, mealwithFootprint.Value);
            }


            // sorting the list in decreasing order by the value of the carbon footprints
            mealsWithCarbonfootprint = mealsWithCarbonfootprint.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            // -------------------------------------------------------- debug

            //debug = "";

            //foreach (var kvp in mealsWithCarbonfootprint)
            //{
            //    foreach (var item in kvp.Key.meals)
            //    {
            //        debug += item.strMeal + " " + kvp.Value.ToString() + ", ";
            //    }
            //}

            //MessageBox.Show(debug);

            // --------------------------------------------------------

            // saving the result to public variable 
            result = mealsWithCarbonfootprint.First().Key;

            string vegetarianResultName = "";
            double carbonFootprintResult = -1.0;
            vegetarianResultName = result.meals[0].strMeal;
            carbonFootprintResult = mealsWithCarbonfootprint.First().Value;
            //vegetarianResult += noMeatListResult[1].meals[0].strMeal;


            resultPanel.Visible = true;
            resultRecipeLabel.Text = vegetarianResultName;
            carbonFootprintLabel.Text = carbonFootprintResult.ToString("0.00") + " CO2eq/kg";
            //MessageBox.Show("lefutott");

            // loading in actual meals image
            loadInImage(result.meals[0].strMealThumb, resultPictureBox);
        }

        //private void apiReadButton_Click(object sender, EventArgs e)
        //{
        //    getData();
        //}

        // rando function for testing

        private void getData()
        {
            // API call
            // Source: https://themealdb.com/api/json/v1/1/

            //var client = new RestClient("https://themealdb.com/api/json/v1/1/");
            //var request = new RestRequest("random.php");
            //var response = client.Execute(request);

            // rando recipe for testing

            APICalls apiCall = new APICalls();

            result = apiCall.randomRecipeCall();


            foreach (var obj in result.meals)
            {
                //todaysTippTextBox.Text = obj.strMeal;
                string imageURL = obj.strMealThumb;

                loadInImage(imageURL, dishPictureBox);
            }
            
        }

        private void recipeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(result.meals[0].strInstructions);
        }

        private void loadInImage(string imageUrl, PictureBox pictureBox)
        {
            // Download the image from the URL
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);

                    // Convert the downloaded byte array to an Image object
                    using (var ms = new System.IO.MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);

                        // Assign the image to the PictureBox control
                        pictureBox.Image = image;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading image: " + ex.Message);
                }
            }
        }

        private void ingredientsButton_Click(object sender, EventArgs e)
        {
            string ingredients = "";

            ingredients += result.meals[0].strIngredient1 + "\n";
            ingredients += result.meals[0].strIngredient2 + "\n";
            ingredients += result.meals[0].strIngredient3 + "\n";
            ingredients += result.meals[0].strIngredient4 + "\n";
            ingredients += result.meals[0].strIngredient5 + "\n";
            ingredients += result.meals[0].strIngredient6 + "\n";
            ingredients += result.meals[0].strIngredient7 + "\n";
            ingredients += result.meals[0].strIngredient8 + "\n";
            ingredients += result.meals[0].strIngredient9 + "\n";
            ingredients += result.meals[0].strIngredient10 + "\n";

            if (result.meals[0].strIngredient11 != "")
            {
                ingredients += result.meals[0].strIngredient11 + "\n";
            }
            if (result.meals[0].strIngredient12 != "")
            {
                ingredients += result.meals[0].strIngredient12 + "\n";
            }
            if (result.meals[0].strIngredient13 != "")
            {
                ingredients += result.meals[0].strIngredient13 + "\n";
            }
            if (result.meals[0].strIngredient14 != "")
            {
                ingredients += result.meals[0].strIngredient14 + "\n";
            }
            if (result.meals[0].strIngredient15 != "")
            {
                ingredients += result.meals[0].strIngredient15 + "\n";
            }
            if (result.meals[0].strIngredient16 != "")
            {
                ingredients += result.meals[0].strIngredient16 + "\n";
            }
            if (result.meals[0].strIngredient17 != "")
            {
                ingredients += result.meals[0].strIngredient17 + "\n";
            }
            if (result.meals[0].strIngredient18 != "")
            {
                ingredients += result.meals[0].strIngredient18 + "\n";
            }
            if (result.meals[0].strIngredient19 != "")
            {
                ingredients += result.meals[0].strIngredient19 + "\n";
            }
            if (result.meals[0].strIngredient20 != "")
            {
                ingredients += result.meals[0].strIngredient20 + "\n";
            }

            MessageBox.Show(ingredients);
        }
    }
}