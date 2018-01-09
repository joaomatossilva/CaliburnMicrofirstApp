using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using CaliburnMicroFristApp.ViewModels;
using Xamarin.Forms;

namespace CaliburnMicroFristApp
{
    public partial class App : FormsApplication
    {
        private readonly SimpleContainer _container;

        public App(SimpleContainer container)
        {
            _container = container;

            //Initialize types
            container.PerRequest<MainViewModel>();

            InitializeComponent();

            DisplayRootViewFor<MainViewModel>();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            _container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
