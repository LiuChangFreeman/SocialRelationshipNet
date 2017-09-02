using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构课程设计_社会关系网络.Model
{
    public class Node : NotificationObject
    {
        private Person person;
        private ObservableCollection<Person> friends;
        private double x;
        private double y;
        private string add;
        private string delete;
        public Person Person {
            get {
                return person;
            }
            set{
                person = value;
                RaisePropertyChanged("Person");
            }
        }
        public ObservableCollection<Person> Friends
        {
            get {
                if (friends == null)
                {
                    friends = new ObservableCollection<Person>();
                }
                return friends;
            }
            set
            {
                friends = value;
                RaisePropertyChanged("Friends");
            }
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                RaisePropertyChanged("X");
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y= value;
                RaisePropertyChanged("Y");
            }
        }
        public string Add
        {
            get
            {
                return add;
            }
            set
            {
                add = value;
                RaisePropertyChanged("Add");
            }
        }
        public string Delete
        {
            get
            {
                return delete;
            }
            set
            {
                delete = value;
                RaisePropertyChanged("Delete");
            }
        }
    }
        public class Graph : NotificationObject
    {

        private ObservableCollection<Node> nodes;
        private ObservableCollection<Group> groups;
        public ObservableCollection<Node> Nodes
        {
            get {
                if (nodes == null)
                {
                    nodes = new ObservableCollection<Node>();
                }
                return nodes;
            }
            set
            {
                nodes = value;
                RaisePropertyChanged("Nodes");
            }
        }
        public ObservableCollection<Group> Groups
        {
            get {
                if (groups == null)
                {
                    groups = new ObservableCollection<Group>();
                }
                return groups;
            }
            set
            {
                groups = value;
                RaisePropertyChanged("Groups");
            }
        }

    }
}
