using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnMicroFristApp.ViewModels
{
    public class MainViewModel : Screen
    {
        private string _mainText;

        public MainViewModel()
        {
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
    }
}
