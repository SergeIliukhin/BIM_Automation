using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using _02_WPF_Task19.Annotations;
using _02_WPF_Task19.Models;

namespace _02_WPF_Task19.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }

        private double result;
        public double Result
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; }

        private void OnAddCommandExecute(object p)
        {
            Result = Calculation.Calculate(Radius);
        }

        private bool CanAddCommandExecuted(object p)
        {
            if (radius != 0)
                return true;
            else
                return false;
        }

        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);
        }

    }
}
