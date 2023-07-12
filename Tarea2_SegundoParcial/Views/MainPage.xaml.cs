using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2_SegundoParcial.Controllers;
using Tarea2_SegundoParcial.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2_SegundoParcial.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAll_Clicked(object sender, EventArgs e){
            await Navigation.PushAsync(new Views.AllListPage());
        }

        private async void btnOne_Clicked(object sender, EventArgs e){
            await Navigation.PushAsync(new Views.SearchPage());
        }
    }
}