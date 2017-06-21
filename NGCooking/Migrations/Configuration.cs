namespace NGCooking.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Web.Script.Serialization;
    using System.IO;
    using Models;
    using System;
    using System.Collections.Generic;
    internal sealed class Configuration : DbMigrationsConfiguration<NGCooking.DAL.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NGCooking.DAL.Context context)
        {

            //deserialize Json from file for community
            string JSONstring = File.ReadAllText("C:/Users/C17 Developer/Desktop/Sonia/ProjetStage/NGCooking/NGCooking/Content/communaute.json");

            JavaScriptSerializer ser = new JavaScriptSerializer();

            List<Community> users = ser.Deserialize<List<Community>>(JSONstring);

            foreach (var user in users)
            {
                context.Community.Add(user);
            }


            //ngredients categories
            JSONstring = File.ReadAllText("C:/Users/C17 Developer/Desktop/Sonia/ProjetStage/NGCooking/NGCooking/Content/categories-ingredients.json");

            ser = new JavaScriptSerializer();
            List<CategoryIngedient> categing = ser.Deserialize<List<CategoryIngedient>>(JSONstring);

            foreach (var categ in categing)
            {
                context.IngredientsCategories.Add(categ);
            }


            //ngredients 
            JSONstring = File.ReadAllText("C:/Users/C17 Developer/Desktop/Sonia/ProjetStage/NGCooking/NGCooking/Content/ingredients.json");

            ser = new JavaScriptSerializer();
            List<Ingredient> ings = ser.Deserialize<List<Ingredient>>(JSONstring);

            foreach (var ing in ings)
            {
                context.Ingredients.Add(ing);
            }



            //receipts categories
            JSONstring = File.ReadAllText("C:/Users/C17 Developer/Desktop/Sonia/ProjetStage/NGCooking/NGCooking/Content/categories-recettes.json");

            ser = new JavaScriptSerializer();
            List<CategoryRecipe> reciptsCateg = ser.Deserialize<List<CategoryRecipe>>(JSONstring);

            foreach (var categ in reciptsCateg)
            {
                context.ReceiptsCategories.Add(categ);
            }


            //receipts 
            JSONstring = File.ReadAllText("C:/Users/C17 Developer/Desktop/Sonia/ProjetStage/NGCooking/NGCooking/Content/recettes.json");

            ser = new JavaScriptSerializer();
            List<Recipe> recipts = ser.Deserialize<List<Recipe>>(JSONstring);

            foreach (var recipe in recipts)
            {
                context.Receipts.Add(recipe);
            }








        }
    }
}
