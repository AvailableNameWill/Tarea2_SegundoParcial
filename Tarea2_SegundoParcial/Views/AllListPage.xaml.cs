using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2_SegundoParcial.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllListPage : ContentPage
    {
        public AllListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing(){
            var clas = await Controllers.controller.getAll();
            list.ItemsSource = clas;
        }
    }
}