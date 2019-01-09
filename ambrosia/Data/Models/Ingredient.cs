using System.Collections.Generic;

namespace Ambrosia.Data.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<RecipeIngredient> Uses { get; set; }

        public Ingredient()
        {
            Uses = new List<RecipeIngredient>();
        }
    }
}