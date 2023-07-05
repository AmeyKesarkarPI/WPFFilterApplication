using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFFilterApplication
{
    public class MainWindowVIewModel
    {

        public Car CarViewModel { get; set; }
        public Person PersonViewModel { get; set; }
        public Fruit FruitViewModel { get; set; }

        public SearchableViewModel SearchablePersonClass { get; set; }

        public SearchableViewModel SearchableCarClass { get; set; }

        public SearchableViewModel SearchableFruitClass { get; set; }


        public MainWindowVIewModel()
        {


            SearchablePersonClass =  new SearchablePerson ( new ObservableCollection<object>() { 
                new Person() { ItemId = 1, Content = "Shaam" },
                new Person() { ItemId = 2, Content = "Baburao" },
                new Person() { ItemId = 3, Content = "Raju" },
                new Person() { ItemId = 4, Content = "Bunty"},
                new Person() { ItemId = 5, Content = "Jones"},
                new Person() { ItemId = 6, Content = "Mohan"},
                new Person() { ItemId = 7, Content = "Sanjana"},
                new Person() { ItemId = 8, Content = "Prakash"},
                new Person() { ItemId = 9, Content = "Jayesh"},
                new Person() { ItemId = 10, Content = "Kaushik"},
                new Person() { ItemId = 11, Content = "Aman" },
            });

            SearchableCarClass = new SearchableCar(new ObservableCollection<object>()
            {
                new Car() { ItemId = 1, Content = "BMW" , Color = "Red"},
                new Car() { ItemId = 2, Content = "Mercedes" , Color = "Olive Green"},
                new Car() { ItemId = 3, Content = "Jaguar" , Color = "Matt Blue"},
                new Car() { ItemId = 4, Content = "Jeep" , Color = "Black"},
                new Car() { ItemId = 5, Content = "Land Rover", Color = "Silver" },
                new Car() { ItemId = 6, Content = "Range Rover", Color = "Silver" },
                new Car() { ItemId = 7, Content = "Koeneigseg" , Color = "Black"},
                new Car() { ItemId = 8, Content = "Dodge" , Color = "White"},
                new Car() { ItemId = 9, Content = "Mustang" , Color = "Maroon"},
                new Car() { ItemId = 10, Content = "Bugatti" , Color = "Deep Blue"},
                new Car() { ItemId = 11, Content = "Lamborghini" , Color = "Violet"},
            });

            SearchableFruitClass = new SearchableFruit(new ObservableCollection<object>
            {
                new Fruit() { ItemId = 1, Content = "Apple" },
                new Fruit() { ItemId = 2, Content = "Mango" },
                new Fruit() { ItemId = 3, Content = "Banana" },
                new Fruit() { ItemId = 4, Content = "Jackfruit" },
                new Fruit() { ItemId = 5, Content = "Grapes" },
                new Fruit() { ItemId = 6, Content = "Jamun" },
                new Fruit() { ItemId = 7, Content = "Fig" },
                new Fruit() { ItemId = 8, Content = "Guava" },
                new Fruit() { ItemId = 9, Content = "Pineapple" },
                new Fruit() { ItemId = 10, Content = "Kiwi" },
                new Fruit() { ItemId = 11, Content = "Avocado" },
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
