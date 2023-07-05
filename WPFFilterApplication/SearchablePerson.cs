using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFFilterApplication
{
    public class SearchablePerson : SearchableViewModel
    {

        public SearchablePerson(ObservableCollection<object> person) : base(person) 
        {

        }

        protected override string DisplayList(object item)
        {
            Person person = (Person)item;
            return person.Content;
        }

        protected override bool ValidateSearch(object item)
        {
            Person person = (Person)item;
            return person?.Content.ToLower().Contains(FilterText?.ToLower() ?? "") ?? false;
        }
    }
}
