using System.ComponentModel.DataAnnotations;

namespace NGCooking.Models
{
    public class CategoryRecipe
    {
        public string Id { get; set; }
        [Required]
        public string NametoDisplay { get; set; }

    }
}