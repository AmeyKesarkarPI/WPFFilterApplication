using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFFilterApplication
{
    public class SearchableFruit : SearchableViewModel
    {
        public SearchableFruit(ObservableCollection<object> Fruit) :  base(Fruit)
        {
        }


        protected override string DisplayList(object item)
        {
            Fruit fruit = (Fruit)item;
            return fruit.Content;
        }

        protected override bool ValidateSearch(object item)
        {
            Fruit fruit = (Fruit)item;
            return fruit?.Content.ToLower().Contains(FilterText?.ToLower() ?? "") ?? false;
        }

    }
}
