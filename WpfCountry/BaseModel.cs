using CountryLab;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WpfCountry
{
    public class BaseModel : INotifyPropertyChanged
    {

        private static List<State> baseList = new List<State>();
        public static List<State> BaseList
        {
            get
            {
                return baseList;
            }
            set
            {
                baseList = value;
            }
        }

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

        public static string path { get; } = @"C:\Users\neket\Downloads\Laba2\Laba2\WpfCountry\Data.xml";

        /// <summary>
        /// Сериализация
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path">Путь</param>
        /// <param name="list">Список</param>
        /// <returns></returns>
        public static async Task XmlSaveAsync<T>(string path, T list)
        {
            await Task.Run(() =>
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
                        serializer.Serialize(fs, BaseList);
                    }
                }
                catch { }
            });
        }

        /// <summary>
        /// Десерилизация
        /// </summary>
        public static async Task<List<State>> XmlLoadAsync(string path)
        {
            return await Task.Run(() =>
            {
                try
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(List<State>));
                    using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        return (List<State>)formatter.Deserialize(fs);
                    }
                }
                catch
                {
                    return default(List<State>);
                }
            }) ?? new List<State>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
