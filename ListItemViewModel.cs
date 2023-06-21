using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MAUI学習
{
    public class ListItemViewModel : BindableBase
    {
        public List<ListItem> Items
        {
            get;
            set;
        }

        private ListItem InternalSelectedItem = null;

        public ListItem SelectedItem
        {
            get => InternalSelectedItem;
            set 
            { 
                SetProperty(ref InternalSelectedItem, value, nameof(SelectedItem)); 
                SelectedName = value?.Name; 
            }
        }

        private string InternalSelectedName = "";

        public string SelectedName
        {
            get => InternalSelectedName;
            set
            {
                SetProperty(ref InternalSelectedName, value, nameof(SelectedName));
            }
        }

        public ListItemViewModel()
        {
            var lst = new List<ListItem>();
            lst.Add(new ListItem()
            {
                Name = "Cooking",
                Location = "Japan"
            });

            lst.Add(new ListItem()
            {
                Name = "Nothing",
                Location = "Japan2"
            });

            Items = lst;
        }
    }
}
