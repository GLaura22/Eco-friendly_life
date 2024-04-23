using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eco_friendly_life_winform.Database_Backend.Controllers;
using eco_friendly_life_winform.Database_Backend.Tables;

namespace eco_friendly_life_winform
{
    public partial class Options : Form
    {
        List<RecipeAPI.Rootobject> resultList = new List<RecipeAPI.Rootobject>();
        public Options(List<string> ids)
        {
            InitializeComponent();

            APICalls apiController = new APICalls();
            foreach (string id in ids)
            { 
                RecipeAPI.Rootobject option = new RecipeAPI.Rootobject();
                option = apiController.getRecipeById(id);
                resultList.Add(option);
            }

            option1label.Text = resultList.ElementAt(0).meals[0].strMeal;
            option2label.Text = resultList.ElementAt(1).meals[0].strMeal;
            option3label.Text = resultList.ElementAt(2).meals[0].strMeal;

            // id doesn't matter here
            Form1 instance = new Form1(0);
            instance.loadInImage(resultList.ElementAt(0).meals[0].strMealThumb, option1pictureBox);
            instance.loadInImage(resultList.ElementAt(1).meals[0].strMealThumb, option2pictureBox);
            instance.loadInImage(resultList.ElementAt(2).meals[0].strMealThumb, option3pictureBox);
        }
    }
}
