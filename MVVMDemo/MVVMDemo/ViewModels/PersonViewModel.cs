using MVVMDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;

        public PersonViewModel()
        {
            _person = new Person { Name = "John Doe", Age = 30 };
        }

        public string Name
        {
            get => _person.Name;
            set
            {
                if (_person.Name != value)
                {
                    _person.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public int Age
        {
            get => _person.Age;
            set
            {
                if (_person.Age != value)
                {
                    _person.Age = value;
                    OnPropertyChanged(nameof(Age));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
