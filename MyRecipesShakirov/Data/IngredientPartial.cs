using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipesShakirov.Data
{
    public partial class Ingredient
    {
        public double StockSum => AvailableCount / CostForCount * (double)Cost;
    }
}
