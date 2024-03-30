using eco_friendly_life_winform.Database_Backend.Connection;
using eco_friendly_life_winform.Database_Backend.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eco_friendly_life_winform.Database_Backend.Loading
{
    internal class LoadInData
    {
        public void DataLoad()
        {
            Task.Run(() =>
            {
                // loading in the data for carbon footprint
                using (var context = new AppDbContext())
                { 
                    if(!context.Ingredients.Any())
                    {
                        // at every loading in the id record of the table should start from 1
                        context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Ingredients', RESEED, 0)");

                        var newIngredients = new Ingredient[]
                        {
                            // ---------- meat (12) ---------------------------------------------------------

                            new Ingredient
                            {
                                IngredientName = "Chicken",
                                CarbonFootprint = 3.68
                            },
                            new Ingredient
                            {
                                IngredientName = "Salmon",
                                CarbonFootprint = 1.61
                            },
                            new Ingredient
                            {
                                IngredientName = "Beef",
                                CarbonFootprint = 17.96
                            },
                            new Ingredient
                            {
                                IngredientName = "Bacon",
                                CarbonFootprint = 4.03
                            },
                            new Ingredient
                            {
                                IngredientName = "Lamb",
                                CarbonFootprint = 25.23
                            },
                            new Ingredient
                            {
                                IngredientName = "Pork",
                                CarbonFootprint = 5.72
                            },
                            //new Ingredient
                            //{
                            //    IngredientName = "Duck",
                            //    CarbonFootprint = 4.10
                            //},
                            //new Ingredient
                            //{
                            //    IngredientName = "Turkey",
                            //    CarbonFootprint = 4.08
                            //},
                            //new Ingredient
                            //{
                            //    IngredientName = "Fish",
                            //    CarbonFootprint = 4.99
                            //},
                            new Ingredient
                            {
                                IngredientName = "Tuna",
                                CarbonFootprint = 2.64
                            },
                            //new Ingredient
                            //{
                            //    IngredientName = "Shrimp",
                            //    CarbonFootprint = 15.07
                            //},
                            new Ingredient
                            {
                                IngredientName = "Egg",
                                CarbonFootprint = 3.20
                            },

                            // -------- vegetables (13) ----------------------------------------------------

                            new Ingredient
                            {
                                IngredientName = "Asparagus",
                                CarbonFootprint = 0.83,
                            },
                            new Ingredient
                            {
                                IngredientName = "Aubergine",
                                CarbonFootprint = 0.19,
                            },
                            //new Ingredient
                            //{
                            //    IngredientName = "Beans",
                            //    CarbonFootprint = 0.43,
                            //},
                            new Ingredient
                            {
                                IngredientName = "Broccoli",
                                CarbonFootprint = 0.57,
                            },
                            new Ingredient
                            {
                                IngredientName = "Lentils",
                                CarbonFootprint = 1.03,
                            },
                            new Ingredient
                            {
                                IngredientName = "Carrots",
                                CarbonFootprint = 0.24,
                            },
                            new Ingredient
                            {
                                IngredientName = "Celery",
                                CarbonFootprint = 0.32,
                            },
                            new Ingredient
                            {
                                IngredientName = "Potato",
                                CarbonFootprint = 0.24,
                            },
                            new Ingredient
                            {
                                IngredientName = "Onion",
                                CarbonFootprint = 0.22,
                            },
                            new Ingredient
                            {
                                IngredientName = "Cucumber",
                                CarbonFootprint = 2.55,
                            },
                            new Ingredient
                            {
                                IngredientName = "Garlic",
                                CarbonFootprint = 0.71,
                            },
                            //new Ingredient
                            //{
                            //    IngredientName = "Olives",
                            //    CarbonFootprint = 0.64,
                            //},
                            new Ingredient
                            {
                                IngredientName = "Pumpkin",
                                CarbonFootprint = 0.24,
                            },

                            // -------- fruits (13) --------------------------------------------------------

                            new Ingredient
                            {
                                IngredientName = "Avocado",
                                CarbonFootprint = 0.54,
                            },
                            new Ingredient
                            {
                                IngredientName = "Peaches",
                                CarbonFootprint = 0.39,
                            },
                            new Ingredient
                            {
                                IngredientName = "Tomatoes",
                                CarbonFootprint = 0.45,
                            },
                            new Ingredient
                            {
                                IngredientName = "Apples",
                                CarbonFootprint = 0.25,
                            },
                            new Ingredient
                            {
                                IngredientName = "Lemons",
                                CarbonFootprint = 0.22,
                            },
                            new Ingredient
                            {
                                IngredientName = "Lime",
                                CarbonFootprint = 0.22,
                            },
                            new Ingredient
                            {
                                IngredientName = "Orange",
                                CarbonFootprint = 0.30,
                            },
                            new Ingredient
                            {
                                IngredientName = "Strawberry",
                                CarbonFootprint = 2.88,
                            },
                            new Ingredient
                            {
                                IngredientName = "Banana",
                                CarbonFootprint = 0.34,
                            },
                            new Ingredient
                            {
                                IngredientName = "Raspberries",
                                CarbonFootprint = 0.63,
                            },
                            new Ingredient
                            {
                                IngredientName = "Blueberries",
                                CarbonFootprint = 0.78,
                            },
                            new Ingredient
                            {
                                IngredientName = "Blackberries",
                                CarbonFootprint = 0.42,
                            },
                            //new Ingredient
                            //{
                            //    IngredientName = "Cherry",
                            //    CarbonFootprint = 0.46,
                            //},

                            // -------- dairy (5) ---------------------------------------------------------

                            new Ingredient
                            {
                                IngredientName = "Butter",
                                CarbonFootprint = 8.48,
                            },
                            new Ingredient
                            {
                                IngredientName = "Cheese",
                                CarbonFootprint = 8.93,
                            },
                            new Ingredient
                            {
                                IngredientName = "Cream",
                                CarbonFootprint = 5.45,
                            },
                            new Ingredient
                            {
                                IngredientName = "Milk",
                                CarbonFootprint = 1.31,
                            },
                            //new Ingredient
                            //{
                            //    IngredientName = "Yogurt",
                            //    CarbonFootprint = 1.69,
                            //},

                            // -------- other (12) ---------------------------------------------------------

                            new Ingredient
                            {
                                IngredientName = "Bread",
                                CarbonFootprint = 0.89,
                            },
                            new Ingredient
                            {
                                IngredientName = "Tofu",
                                CarbonFootprint = 2.27,
                            },
                            //new Ingredient
                            //{
                            //    IngredientName = "Pasta",
                            //    CarbonFootprint = 3.15,
                            //},
                            //new Ingredient
                            //{
                            //    IngredientName = "Paste",
                            //    CarbonFootprint = 3.15,
                            //},
                            new Ingredient
                            {
                                IngredientName = "Sugar",
                                CarbonFootprint = 0.94,
                            },
                            new Ingredient
                            {
                                IngredientName = "Mushrooms",
                                CarbonFootprint = 2.06,
                            },
                            new Ingredient
                            {
                                IngredientName = "Flour",
                                CarbonFootprint = 0.36,
                            },
                            new Ingredient
                            {
                                IngredientName = "Honey",
                                CarbonFootprint = 1.74,
                            },
                            new Ingredient
                            {
                                IngredientName = "Peanut Butter",
                                CarbonFootprint = 1.15,
                            },
                            new Ingredient
                            {
                                IngredientName = "Cocoa",
                                CarbonFootprint = 3.60,
                            },
                            new Ingredient
                            {
                                IngredientName = "Vanilla",
                                CarbonFootprint = 4.30,
                            },
                            new Ingredient
                            {
                                IngredientName = "Rice",
                                CarbonFootprint = 2.19,
                            }

                        };

                        context.Ingredients.AddRange(newIngredients);
                        context.SaveChanges();
                    }

                    if (!context.Tipps.Any())
                    {
                        context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Tipps', RESEED, 1)");

                        var newTipps = new Tipp[]
                        {
                            new Tipp
                            {
                                TippName = "Use reusable water bottle!"
                            },
                            new Tipp 
                            {
                                TippName = "Don't litter!"
                            },
                            new Tipp
                            {
                                TippName = "Go paperless with bills and statements!"
                            },
                            new Tipp
                            {
                                TippName = "Plant trees and native plants in your yard!"
                            },
                            new Tipp
                            {
                                TippName = "Switch to energy-efficient LED light bulbs!"
                            },
                            new Tipp
                            {
                                TippName = "Walk, bike, or use public transportation instead of driving!"
                            },
                            new Tipp
                            {
                                TippName = "Buy locally grown and produced foods!"
                            },
                            new Tipp
                            {
                                TippName = "Use cloth bags instead of plastic bags!"
                            },
                            new Tipp
                            {
                                TippName = "Conserve water by fixing leaks and using water-saving fixtures!"
                            },
                            new Tipp
                            {
                                TippName = "Compost organic waste instead of throwing it away!"
                            },
                            new Tipp
                            {
                                TippName = "Choose products with minimal packaging!"
                            },
                            new Tipp
                            {
                                TippName = "Support eco-friendly businesses and products!"
                            },
                            new Tipp
                            {
                                TippName = "Turn off lights and electronics when not in use!"
                            },
                            new Tipp
                            {
                                TippName = "Use natural cleaning products instead of harsh chemicals!"
                            },
                            new Tipp
                            {
                                TippName = "Reduce meat consumption and eat more plant-based meals!"
                            },
                            new Tipp
                            {
                                TippName = "Opt for reusable containers and utensils instead of single-use ones!"
                            },
                            new Tipp
                            {
                                TippName = "Carpool or car-share to reduce carbon emissions!"
                            },
                            new Tipp
                            {
                                TippName = "Support renewable energy sources like solar and wind power!"
                            },
                            new Tipp
                            {
                                TippName = "Avoid fast fashion and buy clothing made from sustainable materials!"
                            },
                            new Tipp
                            {
                                TippName = "Educate others about the importance of environmental conservation!"
                            }
                        };

                        context.Tipps.AddRange(newTipps);
                        context.SaveChanges();
                    }
                }
            });
        }
    }
}
