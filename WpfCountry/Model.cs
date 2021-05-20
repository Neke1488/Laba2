using CountryLab;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCountry
{
    public class Model : BaseModel
    {
        private static ObservableCollection<Kingdom> searchKingdomList = new ObservableCollection<Kingdom>();
        public static ObservableCollection<Kingdom> SearchKingdomList
        {
            get
            {
                return searchKingdomList;
            }
            set
            {
                searchKingdomList = value;
            }
        }

        private static ObservableCollection<Monarchy> searchMonarchyList = new ObservableCollection<Monarchy>();
        public static ObservableCollection<Monarchy> SearchMonarchyList
        {
            get
            {
                return searchMonarchyList;
            }
            set
            {
                searchMonarchyList = value;
            }
        }

        private static ObservableCollection<Republic> searchRepublicList = new ObservableCollection<Republic>();
        public static ObservableCollection<Republic> SearchRepublicList
        {
            get
            {
                return searchRepublicList;
            }
            set
            {
                searchRepublicList = value;
            }
        }

        private string textBoxSearch = "";
        public string TextBoxSearch
        {
            get
            {
                return textBoxSearch;
            }
            set
            {
                textBoxSearch = value;
                OnPropertyChanged(nameof(textBoxSearch));
            }
        }



        public static async void CollectionsToList()
        {
            await Task.Run(() =>
            {
                BaseList.Clear();
                BaseList.AddRange(KingdomList);
                BaseList.AddRange(MonarchyList);
                BaseList.AddRange(RepublicList);
            });
        }

        public static void ListToCollection()
        {
            KingdomList.Clear();
            MonarchyList.Clear();
            RepublicList.Clear();
            foreach (var item in BaseList)
            {
                if (item is Kingdom)
                    KingdomList.Add((Kingdom)item);
                if (item is Monarchy)
                    MonarchyList.Add((Monarchy)item);
                if (item is Republic)
                    RepublicList.Add((Republic)item);
            }

        }

        public async void SaveData()
        {
            await XmlSaveAsync(path, BaseList);
        }

        public void OnWindowClosing(object sender, CancelEventArgs e)
        {
            CollectionsToList();
            SaveData();
        }

        public void Search()
        {
            foreach  (var item in KingdomList)
            {
                if(item.IsSearch(TextBoxSearch))
                {
                    SearchKingdomList.Add(item);
                }
            }
            foreach (var item in MonarchyList)
            {
                if (item.IsSearch(TextBoxSearch))
                {
                    SearchMonarchyList.Add(item);
                }
            }
            foreach (var item in RepublicList)
            {
                if (item.IsSearch(TextBoxSearch))
                {
                    SearchRepublicList.Add(item);
                }
            }

        }
    }
}
