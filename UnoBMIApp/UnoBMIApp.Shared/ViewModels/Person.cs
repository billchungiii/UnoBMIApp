using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using UnoBMIApp.Commands;

namespace UnoBMIApp.ViewModels
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double _height;
        public double Height
        {
            get { return _height; }
            set
            {
                if (value != _height )
                {
                    _height = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Height)));
                }
            }
        }

        private double _weight;
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value != _weight)
                {
                    _weight = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Weight)));
                }
            }
        }

        private double _result;
        public double Result
        {
            get { return _result; }
            set
            {
                if (value != _result)
                {
                    _result = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
                }
            }
        }

        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                if (_clickCommand == null)
                {
                    _clickCommand = new RelayCommand((x) =>
                   {
                       Result = Weight / Math.Pow(Height, 2);                        
                   });
                }
                return _clickCommand;
            }
        }
    }
}
