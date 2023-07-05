using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFFilterApplication
{
    public class SearchableCar : SearchableViewModel
    {
        public SearchableCar(ObservableCollection<object> car) : base (car)
        {

        }

        protected override string DisplayList(object item)
        {
            Car car = (Car)item;
            return car.Content;
        }

        protected override bool ValidateSearch(object item)
        {
            Car car = (Car)item;
            return car?.Color.ToLower().Contains(FilterText?.ToLower() ?? "") ?? false;
        }
    }
}
