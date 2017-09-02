using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构课程设计_社会关系网络.Model
{
     public class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class Group :NotificationObject
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }
        private string content;
        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                RaisePropertyChanged("Content");
            }
        }
        private ObservableCollection<Person> persons;
        public ObservableCollection<Person> Persons{
            get {
                if (persons==null)
                {
                    persons =new ObservableCollection<Person>();
                }
                return persons;
            }
            set {
                persons = Persons;
                RaisePropertyChanged("Persons");
            }
        }
    }
}
