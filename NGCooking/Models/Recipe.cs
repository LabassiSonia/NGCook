using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NGCooking.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.IngredientsRecipe = new HashSet<Ingredient>();
        }


        public string Id { get; set; }
        public string Name { get; set; }
        public String CreationDate { get; set; }
        public bool IsAvailable { get; set; }
        public string Picture { get; set; }
        [ForeignKey("Creator")]
       public virtual int CreatorId { get; set; }
        [ForeignKey("CategoryRecep")]
        public string Category { get; set; }
        [ForeignKey("IngredientsRecipe")]
        public List<string> Ingredients;
        public int Calories { get; set; }
        public string Preparation { get; set; }



        public int CalculerCalories(List<Ingredient> ingredients)
        {
            int cal = 0;
               foreach (var ing in ingredients)
               {
                   cal += ing.Calories;
               }
            return cal;
        }

      


        //Navigation properties
        public CategoryRecipe CategoryRecep { get; set; }
        public virtual ICollection<Ingredient> IngredientsRecipe { get; set; }
        public virtual Community Creator { get; set; }
        public ICollection<Comments> Comments { get; set; }





    }
}