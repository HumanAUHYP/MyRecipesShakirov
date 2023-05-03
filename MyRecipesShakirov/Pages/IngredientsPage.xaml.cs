using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyRecipesShakirov.Data;

namespace MyRecipesShakirov.Pages
{
    /// <summary>
    /// Логика взаимодействия для IngridientsPage.xaml
    /// </summary>
    public partial class IngredientsPage : Page
    {
        public List<Ingredient> Ingredients;
        public IngredientsPage()
        {
            Ingredients = DataAccess.GetIngredients();
            InitializeComponent();

            SetIngredientsCount();
            SetAllStockSum();

            lvTable.ItemsSource = Ingredients;
        }

        public void SetIngredientsCount()
        {
            tbCount.Text = Convert.ToString(Ingredients.Count) + " наименований";
        }

        public void SetAllStockSum()
        {
            double allStockSum = 0;
            foreach(Ingredient ing in Ingredients)
            {
                allStockSum += ing.StockSum;
            }
            tbStockSum.Text = "Запасов в холодильнике на сумму (руб.): " + Convert.ToString(Math.Round(allStockSum, 2));
        }
    }
}
