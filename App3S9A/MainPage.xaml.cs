using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3S9A
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

     

        private async void View2_Clicked(object sender, EventArgs e)
        {
            try
            {
                //capturamos los datos y luego enviamos a traves del constructor de la vista2
                string usuario = txtUsuario.Text;
                string clave = txtPassword.Text;
                await Navigation.PushAsync(new View2(usuario,clave));


            }catch(Exception ex)
            {
               await DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}
