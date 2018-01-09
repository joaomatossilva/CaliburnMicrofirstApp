using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro.Xamarin.Forms;

namespace CaliburnMicroFristApp.ViewModels
{
    public class MainViewModel : Screen
    {
        private readonly INavigationService _navigationService;
        private string _mainText;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            MainText = "It works with Caliburn.Micro";
        }

        public string MainText
        {
            get { return _mainText; }
            set { SetField(ref _mainText, value); }
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (!object.Equals(field, value))
            {
                field = value;
                NotifyOfPropertyChange(propertyName);
                return true;
            }
            return false;
        }

        public async Task Open()
        {
            //This doesn't set constructor
            //await _navigationService.NavigateToViewModelAsync<DetailViewModel>(new DetailViewModel(1));

            //This works too
            _navigationService.For<DetailViewModel>()
                .WithParam(v => v.Id, 1)
                .Navigate();
        }
    }
}
