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
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing(){
            var clas = await Controllers.controller.getAll();
            list.ItemsSource = clas;
        }

        private void list_ItemTapped(object sender, ItemTappedEventArgs e){
            var clas = e.Item as Models.Clase;
            lblId.Text = Convert.ToString(clas.id);
        }

        private async void btnSearch_Clicked(object sender, EventArgs e){

            if (lblId.Text.Length > 0)
            {
                var clas = await Controllers.controller.getById(lblId.Text);

                await Navigation.PushAsync(new Views.ViewPage(clas));
            }
            else await DisplayAlert("Alerta","No ha seleccionado nada","OK");
        }
    }
}