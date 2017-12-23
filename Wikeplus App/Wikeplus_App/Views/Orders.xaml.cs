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
    public partial class Orders : ContentPage
    {
        public List<Order> FinalOrders { get; set; }
        public Orders()
        {
            InitializeComponent();
            InitAsync();
        }
        private async Task InitAsync()
        {
            var api = new WoocommerceAPI();
            var AllOrders = await api.GetAllOrders();
            FinalOrders = AllOrders.orders.ToList();
            ordersListView.ItemsSource = FinalOrders;
        }
    }
}