using System;
using Caliburn.Micro;

namespace CaliburnMicroFristApp.ViewModels
{
    public class DetailViewModel : Screen
    {
        private int _id;

        public DetailViewModel(int i)
        {
            Id = i;
        }

        public int Id
        {
            get { return _id; }
            set { Set(ref _id, value); }
        }
    }
}