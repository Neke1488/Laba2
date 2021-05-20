using CountryLab;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCountry
{


    public class Model : BaseModel
    {

        private static ObservableCollection<Kingdom> kingdomList = new ObservableCollection<Kingdom>();
        public static ObservableCollection<Kingdom> KingdomList
        {
            get
            {
                return kingdomList;
            }
            set
            {
                kingdomList = value;
            }
        }

        private static ObservableCollection<Monarchy> monarchyList = new ObservableCollection<Monarchy>();
        public static ObservableCollection<Monarchy> MonarchyList
        {
            get
            {
                return monarchyList;
            }
            set
            {
                monarchyList = value;
            }
        }

        private static ObservableCollection<Republic> republicList = new ObservableCollection<Republic>();
        public static ObservableCollection<Republic> RepublicList
        {
            get
            {
                return republicList;
            }
            set
            {
                republicList = value;
            }
        }



        private async void LoadDataToList()
        {
            
        }

        /// <summary>
        /// Асинхронно сохраняет файл
        /// </summary>
        public async void SaveData()
        {
            //await XmlSaveAsync(path, BaseList);
        }

    }
}
