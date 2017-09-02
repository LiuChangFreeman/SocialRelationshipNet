using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 数据结构课程设计_社会关系网络.Model;

namespace 数据结构课程设计_社会关系网络.ViewModel
{
    public class GraphView : NotificationObject
    {
        private Graph graph;
        private int friendWeight;
        private int baseWeight;
        private int groupWeight;
        public Graph Graph
        {
            get {
                if (graph==null)
                {
                    graph = new Graph();
                }
                return graph;
            }
            set
            {
                graph = value;
                RaisePropertyChanged("Graph");
            }
        }
        public int FriendWeight
        {
            get { return friendWeight; }
            set
            {
                friendWeight = value;
                RaisePropertyChanged("FriendWeight");
            }
        }
        public int BaseWeight
        {
            get { return baseWeight; }
            set
            {
                baseWeight = value;
                RaisePropertyChanged("BaseWeight");
            }
        }
        public int GroupWeight
        {
            get { return groupWeight; }
            set
            {
                groupWeight = value;
                RaisePropertyChanged("GroupWeight");
            }
        }
    }
}
