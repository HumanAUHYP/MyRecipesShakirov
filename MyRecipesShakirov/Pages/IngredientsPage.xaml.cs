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
            InitializeComponent();

            Ingredients = DataAccess.GetIngredients();
            lvTable.ItemsSource = Ingredients;
        }
    }
}
