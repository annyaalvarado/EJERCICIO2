using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using static Xamarin.Forms.Internals.Profile;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var datos = new Models.Datos { nombre = txtnombre.Text, apellido = txtapellido.Text, edad = Convert.ToInt32(txtedad.Text), email = txtcorreo.Text };
            var Page2 = new Views.Page2();
            Page2.BindingContext = datos;

            await Navigation.PushAsync(Page2);
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
