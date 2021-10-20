using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3S9A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View2 : ContentPage
    {
        //modificamos al constructor para que reciba las 2 variables. 
        public View2(string usuario,string clave)
        {
            InitializeComponent();
            //pasamos las variables a los label
            lblUsuario.Text = usuario;
            lblClave.Text = clave;
            txtUsuario.Text = usuario;
            txtPasswor.Text = clave;
        }
    }
}