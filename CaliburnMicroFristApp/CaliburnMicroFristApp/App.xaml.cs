using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using CaliburnMicroFristApp.ViewModels;
using CaliburnMicroFristApp.Views;
using Xamarin.Forms;

namespace CaliburnMicroFristApp
{
    public partial class App : FormsApplication
    {
        private readonly SimpleContainer _container;

        public App(SimpleContainer container)
        {
            Initialize();

            _container = container;

            //Initialize types
            container.PerRequest<MainViewModel>();
            container.PerRequest<DetailViewModel>();

            InitializeComponent();

            //DisplayRootViewFor is for ViewModel first, but it doesn't register the Navigation services
            //Because of it, we use the View First only on the root view to enable navigation
            //DisplayRootViewFor<MainViewModel>();
            DisplayRootView<MainView>();
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
