using eco_friendly_life_winform.Database_Backend.Tables;
using eco_friendly_life_winform.Database_Backend.Controllers;
using RestSharp;
using Newtonsoft;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Net;
using eco_friendly_life_winform.Database_Backend.Calculator;

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

            // meat 12
            for (int i = 0; i < 13; i++)
            {
                ingredientComboBox1.Items.Add(ingredients[i].IngredientName.ToString());
            }
            // vegtables 13
            for (int i = 13; i < 26; i++)
            {
                ingredientComboBox2.Items.Add(ingredients[i].IngredientName.ToString());
            }
            // fruits 13
            for (int i = 26; i < 39; i++)
            {
                ingredientComboBox3.Items.Add(ingredients[i].IngredientName.ToString());
            }
            // dairy 5
            for (int i = 39; i < 43; i++)
            {
                ingredientComboBox4.Items.Add(ingredients[i].IngredientName.ToString());
            }
            // other 12
            for (int i = 43; i < 55; i++)
            {
                ingredientComboBox5.Items.Add(ingredients[i].IngredientName.ToString());
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
            string wantedIngredient4 = string.Empty;
            string wantedIngredient5 = string.Empty;

            wantedIngredient1 = ingredientComboBox1.Text;
            wantedIngredient2 = ingredientComboBox2.Text;
            wantedIngredient3 = ingredientComboBox3.Text;
            wantedIngredient4 = ingredientComboBox3.Text;
            wantedIngredient5 = ingredientComboBox3.Text;

            string tipus = string.Empty;

            // there is no preffered ingredient

            if ("" == wantedIngredient1 && "" == wantedIngredient2 && "" == wantedIngredient3 &&
                 "" == wantedIngredient4 && "" == wantedIngredient5)
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

        }

        private void meatAllIngredients()
        { 
            
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
            vegetarianResultName = result.meals[0].strMeal;
            //vegetarianResult += noMeatListResult[1].meals[0].strMeal;


            resultPanel.Visible = true;
            resultRecipeLabel.Text = vegetarianResultName;
            //MessageBox.Show("lefutott");

            // loading in actual meals image
            loadInImage(result.meals[0].strMealThumb, resultPictureBox);
        }

        private void apiReadButton_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            // API call
            // Source: https://themealdb.com/api/json/v1/1/

            //var client = new RestClient("https://themealdb.com/api/json/v1/1/");
            //var request = new RestRequest("random.php");
            //var response = client.Execute(request);

            //if (response.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    string rawResponse = response.Content;

            //    result = JsonConvert.DeserializeObject<RecipeAPI.Rootobject>(rawResponse);

            //    if(result != null)
            //    {
            //        foreach(var obj in result.meals) 
            //        {
            //            todaysTippTextBox.Text = obj.strMeal;
            //        }
            //    }
            //}

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
    }
}