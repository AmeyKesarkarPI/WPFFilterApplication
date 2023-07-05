using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WPFFilterApplication
{
    public class SearchableViewModel : INotifyPropertyChanged
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private string selectedFilterText { get; set; }

        public string SelectedFilterText
        {
            get
            {
                return selectedFilterText;
            }
            set
            {
                if (filterText != value)
                {
                    selectedFilterText = value;
                    FilterText = selectedFilterText;
                    OnPropertyChange(nameof(FilterText));
                }
            }
        }

        public string FilterText
        {
            get
            {
                return filterText;
            }
            set
            {
                filterText = value;
                OnPropertyChange(nameof(ItemsList));
                FilterList();
            }
        }

        private string filterText { get; set; }

        public ObservableCollection<string> ItemsList { get; set; }

        private ObservableCollection<object> itemsList { get; set; }


        private void FilterList()
        {
            ItemsList = new ObservableCollection<string>();
            foreach (var item in itemsList)
            {
                if (ValidateSearch(item))
                {
                    ItemsList.Add(DisplayList(item));
                }
            }

            OnPropertyChange(nameof(ItemsList));
        }

        protected virtual string DisplayList(object item)
        {
            return item.ToString();
        }

        protected virtual bool ValidateSearch(object item)
        {
            return item?.ToString().ToLower().Contains(FilterText?.ToLower() ?? "") ?? false;
        }

        public SearchableViewModel(ObservableCollection<object> ItemList)
        {
            itemsList = new ObservableCollection<object>(ItemList);
            FilterList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
