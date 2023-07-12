using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2_SegundoParcial.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2_SegundoParcial.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewPage : ContentPage
    {
        private Clase clase;
        public ViewPage(Clase _clase){
            InitializeComponent();
            clase = _clase;
            lblId.Text = Convert.ToString(clase.id);
            lblTitle.Text = clase.title;
            lblBody.Text = clase.body;
        }
    }
}