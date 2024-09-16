using AssistantHeadman.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AssistantHeadman
{
    public partial class App : Application
    {
        private static DBContext DBContext;

        public static DBContext dBContext
        {
            get
            {
                if(DBContext == null)
                    dBContext= new DBContext("db.Sqlite");
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

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
