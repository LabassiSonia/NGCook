using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NGCooking.Models
{
    public class Ingredient
    {
        public Ingredient()
        {
            this.Receipts = new HashSet<Recipe>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public string Picture { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; }
        [ForeignKey("Categ")]
        public string Category { get; set; }

        //Navigation property
        public virtual CategoryIngedient Categ { get; set; }
        public  virtual ICollection<Recipe> Receipts { get; set; } 
    }
}