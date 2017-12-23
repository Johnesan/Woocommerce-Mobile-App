using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wikeplus_App.Models;
using Wikeplus_App.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wikeplus_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Products : ContentPage
    {
        public List<Product> FinalProducts { get; set; }
        public Products()
        {
            InitializeComponent();
            InitAsync();
        }
        private async Task InitAsync()
        {
            var api = new WoocommerceAPI();
              var AllProducts = await api.GetAllProducts();
            FinalProducts = AllProducts.products.ToList();
            productsListView.ItemsSource = FinalProducts;
        }              
    }
}