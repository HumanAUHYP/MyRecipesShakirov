using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipesShakirov.Data
{
    public static class DataAccess
    {
        public static List<Ingredient> GetIngredients()
        {
            return db.connection.Ingredient.ToList();
        }
    }
}
