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
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;

namespace eco_friendly_life_winform
{
    public partial class Form1 : Form
    {

        RecipeAPI.Rootobject result;
        private Person user = new Person { UserID = 0, UserName = "", Password = "" };
        private int actUserId = 0;

        List<RecipeAPI.Rootobject> resultList = new List<RecipeAPI.Rootobject>();

        public Form1(int userId)
        {
            InitializeComponent();
            mainWindowPanel.Visible = true;
            RecipePanel.Visible = false;
            TippPanel.Visible = false;
            resultPanel.Visible = false;
            ratingPanel.Visible = false;
            optionsButton.Visible = false;
            user.UserID = userId;

            //MessageBox.Show(userId.ToString());
            PersonController personController = new PersonController();

            string actUserName = personController.GetUsername(userId);
            userNameLabel.Text = "Hi, " + actUserName + "!";
            actUserId = userId;

        }


        private void recipeSuggestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainWindowPanel.Visible = false;
            TippPanel.Visible = false;
            RecipePanel.Visible = true;
            resultPanel.Visible = false;
            ratingPanel.Visible = false;
            optionsButton.Visible = false;
            ingredientComboBox1.Items.Clear();

            IngredientController ingredientController = new();

            List<Ingredient> ingredients = ingredientController.GetItems();
            ingredientComboBox1.Items.Clear();
            ingredientComboBox2.Items.Clear();
            ingredientComboBox3.Items.Clear();
            
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
            ratingPanel.Visible = false;
            optionsButton.Visible = false;

            TippController tippController = new();

            List<Tipp> tipps = new List<Tipp>();
            tipps = tippController.GetTipps();

            Random rnd = new Random();
            int num = rnd.Next(0, tipps.Count());

            todaysTippTextBox.Text = tipps[num].TippName;
        }

        private void generalasButton_Click(object sender, EventArgs e)
        {
            resultList.Clear();
            MessageBox.Show("Generating...");
            string wantedIngredient1 = string.Empty;
            string wantedIngredient2 = string.Empty;
            string wantedIngredient3 = string.Empty;

            wantedIngredient1 = ingredientComboBox1.Text;
            wantedIngredient2 = ingredientComboBox2.Text;
            wantedIngredient3 = ingredientComboBox3.Text;

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

            optionsButton.Visible = true;

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

            result = mealswithFootprint.First().Key;
            carbonFootprint = mealswithFootprint.First().Value;

            resultPanel.Visible = true;
            resultRecipeLabel.Text = result.meals[0].strMeal;
            string formattedValue = carbonFootprint.ToString("0.00");   // only 2 digits should be displayed
            carbonFootprintLabel.Text = formattedValue + " CO2eq/kg";

            // loading in actual meals image
            loadInImage(result.meals[0].strMealThumb, resultPictureBox);

            // saving the top 3 results
            if (mealswithFootprint.Count() >= 4)
            {
                resultList.Add(mealswithFootprint.ElementAt(1).Key);
                resultList.Add(mealswithFootprint.ElementAt(2).Key);
                resultList.Add(mealswithFootprint.ElementAt(3).Key);
            }


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

            // saving the top 3 results
            if (mealsWithCarbonfootprint.Count() >= 3)
            {
                resultList.Add(mealsWithCarbonfootprint.ElementAt(1).Key);
                resultList.Add(mealsWithCarbonfootprint.ElementAt(2).Key);
                resultList.Add(mealsWithCarbonfootprint.ElementAt(3).Key);
            }

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

            // saving the top 3 results
            if (mealsWithCarbonfootprint.Count() >= 3)
            {
                resultList.Add(mealsWithCarbonfootprint.ElementAt(1).Key);
                resultList.Add(mealsWithCarbonfootprint.ElementAt(2).Key);
                resultList.Add(mealsWithCarbonfootprint.ElementAt(3).Key);
            }
            

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

        public void loadInImage(string imageUrl, PictureBox pictureBox)
        {
            // download the image from the URL
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);

                    // convert the downloaded byte array to an Image object
                    using (var ms = new System.IO.MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);

                        // assign the image to the PictureBox control
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


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string filename = "";

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            file.FilterIndex = 1;

            file.Multiselect = false;


            if (file.ShowDialog() == DialogResult.OK)
            {
                filename = file.FileName;
                //MessageBox.Show(file.FileName);

                // Get the selected file path.
                string selectedImagePath = file.FileName;

                // Assign the image file to PictureBox
                pictureBox2.ImageLocation = selectedImagePath;
            }

        }

        private void rateButton_Click(object sender, EventArgs e)
        {

            CommentController commentController = new CommentController();

            // getting the data for the comment
            string mealName = ratedMealNameTextBox.Text;
            int rating = ratingBar.Value;
            byte[] imageByteArray = commentController.ImageConvertToByteArray(pictureBox2.Image);

            // getting the mealId by the name
            APICalls recipeController = new APICalls();
            
            
            try
            {
                RecipeAPI.Rootobject actDish = recipeController.getRecipeByNameCall(mealName);
                if (actDish != null && actDish.meals != null && actDish.meals.Length > 0)
                {
                    string actDishId = actDish.meals[0].idMeal;

                    Comment newComment = new Comment { MealImage = imageByteArray, Rating = rating, UserID = actUserId, MealID = actDishId };

                    int debug = commentController.AddComment(newComment);

                    if (debug == 0)
                    {
                        MessageBox.Show("Sorry, we couldn't save your rating!");
                    }
                }
                else
                {
                    MessageBox.Show("No recipe found with a name like that");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void reviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainWindowPanel.Visible = false;
            RecipePanel.Visible = false;
            TippPanel.Visible = false;
            ratingPanel.Visible = true;
            optionsButton.Visible = false;

            commentsDataGridView.Rows.Clear();
            commentsDataGridView.Columns[0].Width = 120; // Username column
            commentsDataGridView.Columns[1].Width = 200; // Meal column
            commentsDataGridView.Columns[2].Width = 60;  // Rating column
            commentsDataGridView.Columns[3].Width = 240; // Image column

            CommentController commentController = new CommentController();
            List<Comment> comments = commentController.GetCommentList();

            PersonController userController = new PersonController();
            APICalls aPICalls = new APICalls();

            foreach(var comment in comments)
            {
                
                string username = userController.GetUsername(comment.UserID);
                string rating = comment.Rating.ToString();
                Image actImage = commentController.ByteArrayConvertToImage(comment.MealImage);

                RecipeAPI.Rootobject actmeal = aPICalls.getRecipeById(comment.MealID);

                int rowIndex = commentsDataGridView.Rows.Add(username, actmeal.meals[0].strMeal, rating, actImage);

                // set row height
                commentsDataGridView.Rows[rowIndex].Height = 100;

            }
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(resultList.Count().ToString());
            List<string> ids = new List<string>();
            if (resultList.Count() > 0)
            {
                
                for (int i = 0; i < resultList.Count(); i++)
                {
                    //MessageBox.Show(resultList.ElementAt(i).meals[0].strMeal);
                    ids.Add(resultList.ElementAt(i).meals[0].idMeal);
                }

                var myForm = new Options(ids);
                myForm.ShowDialog();

            }
            else {
                MessageBox.Show("Sorry can't recommend any meals similar to this one.");
            }
        }
    }
}