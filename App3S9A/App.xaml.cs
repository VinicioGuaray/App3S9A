using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3S9A
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //habilitamos la navegación jerargica
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
