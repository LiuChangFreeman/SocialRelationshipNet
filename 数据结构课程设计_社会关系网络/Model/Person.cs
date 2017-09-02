using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace 数据结构课程设计_社会关系网络.Model
{
    public class Person : NotificationObject, IComparable<Person>
    {
        private string name;
        private string regin;
        private string juniorschool;
        private string middleschool;
        private string college;
        private string company;
        private string information;
        private int score;
        private ObservableCollection<Group> groups;
        public Person(string name,string regin, string juniorschool, string middleschool, string college, string company)
        {
            Name = name;
            Regin = regin;
            Juniorschool = juniorschool;
            Middleschool = middleschool;
            College = college;
            Company = company;
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }
        public string Regin
        {
            get { return regin; }
            set
            {
                regin = value;
                RaisePropertyChanged("Regin");
            }
        }
        public string Juniorschool
        {
            get { return juniorschool; }
            set
            {
                juniorschool = value;
                RaisePropertyChanged("Juniorschool");
            }
        }
        public string Middleschool
        {
            get { return middleschool; }
            set
            {
                middleschool = value;
                RaisePropertyChanged("Middleschool");
            }
        }
        public string College
        {
            get { return college; }
            set
            {
                college = value;
                RaisePropertyChanged("College");
            }
        }
        public string Company
        {
            get { return company; }
            set
            {
                company = value;
                RaisePropertyChanged("Company");
            }
        }
        public string Information
        {
            get { return information; }
            set
            {
                information = value;
                RaisePropertyChanged("Information");
            }
        }
        public int Score
        {
            get { return score; }
            set
            {
                score = value;
                RaisePropertyChanged("Score");
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

        public int CompareTo(Person other)
        {
            if (null == other)
            {
                return 1;
            }
            return other.Score.CompareTo(this.Score);
        }
    }
}