using System;
using System.Collections.Generic;

namespace Ambrosia.Data.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid ImageFile { get; set; }

        public string Method { get; set; }

        public ICollection<RecipeIngredient> Ingredients { get; set; }

        public Recipe()
        {
            Ingredients = new List<RecipeIngredient>();
        }
    }
}
