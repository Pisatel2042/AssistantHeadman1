using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AssistantHeadman
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
       
        
        public LoginPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
           
           
        }
        public void Prov(object sender, EventArgs e)
        {
            string Email = EmailLabel.Text;

            if (Email == "vasya")
            {
                GoToMain(sender, e);
            }
            else
            {
                EmailLabel.TextColor = Color.Red;
                ButtonEnter.TextColor = Color.Red;
            }
        }
        private async void GoToMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}