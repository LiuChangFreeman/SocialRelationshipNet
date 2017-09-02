using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using 数据结构课程设计_社会关系网络.Model;
using 数据结构课程设计_社会关系网络.ViewModel;

namespace 数据结构课程设计_社会关系网络
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            InitialzeGraphView();
        }
        GraphView G;
        async void InitialzeGraphView()
        {
            Person HuaWei = new Person("HuaWei", "广东","一小","二中","同济","中国某硬件公司");
            Person Vivo = new Person("Vivo", "广东", "一小", "二中", "交大", "中国某硬件公司");
            Person XiaoMi= new Person("XiaoMi", "北京", "二小", "二中", "同济", "中国某硬件公司");
            Person Microsoft = new Person("Microsoft", "北京", "三小", "二中", "清华", "外国某软件公司");
            Person Xilinx = new Person("Xilinx", "上海", "二小", "三中", "哈佛", "外国某硬件公司");
            Person Adobe = new Person("Adobe", "上海", "二小", "三中", "清华", "外国某软件公司");
            Person AMD = new Person("AMD", "美国", "三小", "三中", "斯坦福", "外国某硬件公司");
            Person Intel = new Person("Intel", "上海", "三小", "三中", "交大", "外国某硬件公司");
            Person Apple = new Person("Apple", "美国", "三小", "三中", "斯坦福", "外国某硬件公司");
            Person Google = new Person("Google", "美国", "三小", "四中", "斯坦福", "外国某软件公司");
            Person Oppo = new Person("Oppo", "广东", "四小", "五中", "交大", "中国某硬件公司");
            Person Shengdiyage = new Person("Shengdiyage", "美国", "四小", "五中", "清华", "世界超级公司");
            Person Baidu = new Person("Baidu", "北京", "四小", "五中", "哈佛", "中国某软件公司");
            Person Ali=new Person("Ali", "上海", "五小", "四中", "同济", "中国某软件公司");
            Person Tencent = new Person("Tencent", "广东", "五小", "四中", "斯坦福", "中国某软件公司");
            Person Facebook = new Person("Facebook", "美国", "五小", "四中", "哈佛", "外国某软件公司");
            Group Phone = new Group();
            Phone.Name = "Phone";
            Phone.Persons.Add(HuaWei);
            Phone.Persons.Add(Apple);
            Phone.Persons.Add(Vivo);
            Phone.Persons.Add(Oppo);
            Phone.Persons.Add(XiaoMi);
            Group Computer = new Group();
            Computer.Name = "Computer";
            Computer.Persons.Add(Apple);
            Computer.Persons.Add(Intel);
            Computer.Persons.Add(AMD);
            Computer.Persons.Add(Adobe);
            Computer.Persons.Add(Microsoft);
            Computer.Persons.Add(Xilinx);
            Group ChinaIT = new Group();
            ChinaIT.Name = "ChinaIT";
            ChinaIT.Persons.Add(HuaWei);
            ChinaIT.Persons.Add(Tencent);
            ChinaIT.Persons.Add(Baidu);
            ChinaIT.Persons.Add(Ali);
            ChinaIT.Persons.Add(XiaoMi);
            Group AmericaIT = new Group();
            AmericaIT.Name = "AmericaIT";
            AmericaIT.Persons.Add(Microsoft);
            AmericaIT.Persons.Add(Facebook);
            AmericaIT.Persons.Add(Apple);
            AmericaIT.Persons.Add(Google);
            HuaWei.Groups.Add(Phone);
            HuaWei.Groups.Add(ChinaIT);
            Vivo.Groups.Add(Phone);
            XiaoMi.Groups.Add(Phone);
            XiaoMi.Groups.Add(ChinaIT);
            Microsoft.Groups.Add(Computer);
            Microsoft.Groups.Add(AmericaIT);
            Xilinx.Groups.Add(Computer);
            Adobe.Groups.Add(Computer);
            AMD.Groups.Add(Computer);
            Intel.Groups.Add(Computer);
            Apple.Groups.Add(Computer);
            Apple.Groups.Add(AmericaIT);
            Apple.Groups.Add(Phone);
            Google.Groups.Add(AmericaIT);
            Oppo.Groups.Add(Phone);
            Baidu.Groups.Add(ChinaIT);
            Ali.Groups.Add(ChinaIT);
            Tencent.Groups.Add(ChinaIT);
            Facebook.Groups.Add(AmericaIT);
            Node HuaWeiNode = new Node();
            HuaWeiNode.Person = HuaWei;
            HuaWeiNode.Friends.Add(Tencent);
            HuaWeiNode.Friends.Add(Google);
            HuaWeiNode.Friends.Add(Ali);
            Node VivoNode = new Node();
            VivoNode.Person = Vivo;
            VivoNode.Friends.Add(Tencent);
            VivoNode.Friends.Add(XiaoMi);
            VivoNode.Friends.Add(Ali);
            Node XiaoMiNode = new Node();
            XiaoMiNode.Person = XiaoMi;
            XiaoMiNode.Friends.Add(Microsoft);
            XiaoMiNode.Friends.Add(Intel);
            XiaoMiNode.Friends.Add(Xilinx);
            XiaoMiNode.Friends.Add(Ali);
            Node MicrosoftNode = new Node();
            MicrosoftNode.Person = Microsoft;
            MicrosoftNode.Friends.Add(XiaoMi);
            MicrosoftNode.Friends.Add(Xilinx);
            MicrosoftNode.Friends.Add(Intel);
            MicrosoftNode.Friends.Add(Adobe);
            MicrosoftNode.Friends.Add(AMD);
            MicrosoftNode.Friends.Add(Facebook);
            Node XilinxNode = new Node();
            XilinxNode.Person = Xilinx;
            XilinxNode.Friends.Add(XiaoMi);
            XilinxNode.Friends.Add(Microsoft);
            Node AdobeNode = new Node();
            AdobeNode.Person = Adobe;
            AdobeNode.Friends.Add(Microsoft);
            AdobeNode.Friends.Add(Apple);
            Node AMDNode = new Node();
            AMDNode.Person = AMD;
            AMDNode.Friends.Add(Microsoft);
            AMDNode.Friends.Add(Apple);
            AMDNode.Friends.Add(Facebook);
            Node IntelNode = new Node();
            IntelNode.Person = Intel;
            IntelNode.Friends.Add(Microsoft);
            IntelNode.Friends.Add(Apple);
            IntelNode.Friends.Add(Facebook);
            IntelNode.Friends.Add(XiaoMi);
            Node AppleNode = new Node();
            AppleNode.Person = Apple;
            AppleNode.Friends.Add(Adobe);
            AppleNode.Friends.Add(Intel);
            AppleNode.Friends.Add(AMD);
            AppleNode.Friends.Add(Facebook);
            Node GoogleNode = new Node();
            GoogleNode.Person = Google;
            GoogleNode.Friends.Add(HuaWei);
            GoogleNode.Friends.Add(Facebook);
            GoogleNode.Friends.Add(Baidu);
            Node OppoNode = new Node();
            OppoNode.Person = Oppo;
            OppoNode.Friends.Add(Baidu);
            Node ShengdiyageNode = new Node();
            ShengdiyageNode.Person = Shengdiyage;
            Node BaiduNode = new Node();
            BaiduNode.Person = Baidu;
            BaiduNode.Friends.Add(Google);
            BaiduNode.Friends.Add(Ali);
            BaiduNode.Friends.Add(Tencent);
            BaiduNode.Friends.Add(Oppo);
            Node AliNode = new Node();
            AliNode.Person = Ali;
            AliNode.Friends.Add(Tencent);
            AliNode.Friends.Add(Baidu);
            AliNode.Friends.Add(XiaoMi);
            AliNode.Friends.Add(Vivo);
            AliNode.Friends.Add(HuaWei);
            Node TencentNode = new Node();
            TencentNode.Person = Tencent;
            TencentNode.Friends.Add(Ali);
            TencentNode.Friends.Add(Baidu);
            TencentNode.Friends.Add(HuaWei);
            TencentNode.Friends.Add(Vivo);
            Node FacebookNode = new Node();
            FacebookNode.Person = Facebook;
            FacebookNode.Friends.Add(Microsoft);
            FacebookNode.Friends.Add(Google);
            FacebookNode.Friends.Add(Apple);
            FacebookNode.Friends.Add(Intel);
            FacebookNode.Friends.Add(AMD);
            G = new GraphView();
            G.FriendWeight = 20;
            G.BaseWeight = 10;
            G.GroupWeight=5;
            Friends.DataContext = G;
            Base.DataContext = G;
            Group.DataContext = G;
            G.Graph.Nodes.Add(HuaWeiNode);
            G.Graph.Nodes.Add(XiaoMiNode);
            G.Graph.Nodes.Add(VivoNode);
            G.Graph.Nodes.Add(MicrosoftNode);
            G.Graph.Nodes.Add(XilinxNode);
            G.Graph.Nodes.Add(AdobeNode);
            G.Graph.Nodes.Add(AMDNode);
            G.Graph.Nodes.Add(IntelNode);
            G.Graph.Nodes.Add(AppleNode);
            G.Graph.Nodes.Add(GoogleNode);
            G.Graph.Nodes.Add(OppoNode);
            G.Graph.Nodes.Add(ShengdiyageNode);
            G.Graph.Nodes.Add(BaiduNode);
            G.Graph.Nodes.Add(AliNode);
            G.Graph.Nodes.Add(TencentNode);
            G.Graph.Nodes.Add(FacebookNode);
            G.Graph.Groups.Add(Phone);
            G.Graph.Groups.Add(Computer);
            G.Graph.Groups.Add(ChinaIT);
            G.Graph.Groups.Add(AmericaIT);
            People.ItemsSource=G.Graph.Nodes;
            await Task.Delay(1);
            AdjustLayOut();
        }

        public List<T> GetChildObjects<T>(DependencyObject obj, string name) where T : FrameworkElement
        {
            DependencyObject child = null;
            List<T> childList = new List<T>();
            for (int i = 0; i <= VisualTreeHelper.GetChildrenCount(obj) - 1; i++)
            {
                child = VisualTreeHelper.GetChild(obj, i);
                if (child is T && (((T)child).Name == name || string.IsNullOrEmpty(name)))
                {
                    childList.Add((T)child);
                }
                childList.AddRange(GetChildObjects<T>(child, ""));
            }
            return childList;
        }

        async void AdjustLayOut()
        {
            WhiteBoard.Children.Clear();
            double r= (Width<Height?Width:Height)/2-120;
            double PI = 3.1415926;
            Point p = new Point { X = Width / 2-250,Y = Height / 2-100};
            int i= 0;
            List<Grid> units = GetChildObjects<Grid>(People, "");
            foreach (Grid t in units)
            {
                Node data = t.DataContext as Node;
                data.X = p.X+ r * Math.Cos(i * 2 * PI / units.Count)-40;
                data.Y = p.Y+ r * Math.Sin(i * 2 * PI / units.Count)-15;
                i = i + 1;
                data.Add = "Collapsed";
                data.Delete = "Collapsed";
            }
          /*  Ellipse e = new Ellipse { Width = 2*r, Height = 2*r, Stroke = Brushes.Red };
            e.SetValue(Canvas.LeftProperty, p.X-r);
            e.SetValue(Canvas.TopProperty, p.Y-r);
            WhiteBoard.Children.Add(e);*/
            await Task.Delay(1);
            foreach (Grid t in units)
            {
                Node data = t.DataContext as Node;
                foreach (Grid t_friend in units)
                {
                    Node data_friend = t_friend.DataContext as Node;
                    if (data_friend.Friends.Contains(data.Person))
                    {
                        Point P = t.TransformToAncestor(People).Transform(new Point(0, 0));
                        Point P_friend = t_friend.TransformToAncestor(People).Transform(new Point(0, 0));
                        Line line = new Line { X1 = P.X+t.ActualWidth/2, Y1 =P.Y+t.ActualHeight/2 , X2 = P_friend.X+ t_friend.ActualWidth/2, Y2 = P_friend.Y+ t_friend.ActualHeight/2, Stroke = Brushes.Black };
                        WhiteBoard.Children.Add(line);
                    }
                }
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            AdjustLayOut();
        }

        private void Unit_Click(object sender, RoutedEventArgs e)
        {
            Friends.IsEnabled = false;
            Group.IsEnabled = false;
            Base.IsEnabled = false;
            WhiteBoard.Children.Clear();
            List<Grid> buttons = GetChildObjects<Grid>(People, "");
            Infromation.DataContext = ((sender as Button).DataContext as Node).Person;
            foreach (Grid t in buttons)
            {
                Node data = t.DataContext as Node;
                data.Add = "Collapsed";
                data.Delete = "Collapsed";
            }
            ObservableCollection<Group> temp= (Infromation.DataContext as Person).Groups;
            foreach (Group G in G.Graph.Groups)
            {
                if (temp.Contains(G))
                {
                    G.Content = "退出";  
                }
                else
                {
                    G.Content = "加入";
                }
            }
            FindMayKonwPerson((sender as Button).DataContext as Node);
            List<Person> MayKonw = new List<Person>();
            foreach (Grid t in buttons)
            {
                Node data = t.DataContext as Node;
                if(data.Person.Score>0&& data.Person!= (Infromation.DataContext as Person))
                MayKonw.Add(data.Person);
            }
            MayKonw.Sort();
            ObservableCollection<Person> source= new ObservableCollection<Person>(MayKonw);
            Results.ItemsSource = source;
            Groups.ItemsSource = G.Graph.Groups;
            foreach (Grid t in buttons)
            {
                Node data = t.DataContext as Node;
                if (data.Person== Infromation.DataContext) {
                    foreach (Grid t_friend in buttons)
                    {
                        Node data_friend = t_friend.DataContext as Node;
                        if (data_friend.Friends.Contains(data.Person))
                        {
                            Point P = t.TransformToAncestor(People).Transform(new Point(0, 0));
                            Point P_friend = t_friend.TransformToAncestor(People).Transform(new Point(0, 0));
                            Line line = new Line { X1 = P.X + t.ActualWidth / 2, Y1 = P.Y + t.ActualHeight / 2, X2 = P_friend.X + t_friend.ActualWidth / 2, Y2 = P_friend.Y + t_friend.ActualHeight / 2, Stroke = Brushes.Red };
                            WhiteBoard.Children.Add(line);
                            data_friend.Delete = "Visible";
                        }
                        else
                        {
                            data_friend.Add ="Visible";
                        }
                    }
                    data.Add = "Collapsed";
                    data.Delete = "Collapsed";
                    break;
                }
            }
        }

        private void FindMayKonwPerson(Node host)
        {
            ObservableCollection<Node> total = new ObservableCollection<Node>();
            List<Grid> units = GetChildObjects<Grid>(People, "");
            foreach (Grid t in units)
            {
                total.Add(t.DataContext as Node);
                Person p = (t.DataContext as Node).Person;
            }
            foreach (Node n in total)
            {
                if (n.Person==host.Person)
                {
                    continue;
                }
                int friendcnt = 0;
                string FriendcntInformation = "共同的好友：";
                string BaseInformation = "共同的基本资料：";
                string GroupInformation = "共同的群组：";
                int basecnt = 0;
                int groupcnt = 0;
                if (!host.Friends.Contains(n.Person))
                {
                    foreach (Node t in total)
                    {
                        if (host.Friends.Contains(t.Person)&&n.Friends.Contains(t.Person))
                        {
                            FriendcntInformation += t.Person.Name + "、";
                            friendcnt = friendcnt + 1;
                        }
                    }
                }
                FriendcntInformation += "共" + friendcnt + "个。";
                if (host.Person.Regin == n.Person.Regin)
                {
                    basecnt++;
                    BaseInformation += host.Person.Regin + "、";
                }
                if (host.Person.Juniorschool == n.Person.Juniorschool)
                {
                    basecnt++;
                    BaseInformation += host.Person.Juniorschool + "、";
                }
                if (host.Person.Middleschool == n.Person.Middleschool)
                {
                    basecnt++;
                    BaseInformation += host.Person.Middleschool + "、";
                }
                if (host.Person.College == n.Person.College)
                {
                    basecnt++;
                    BaseInformation += host.Person.College + "、";
                }
                if (host.Person.Company == n.Person.Company)
                {
                    basecnt++;
                    BaseInformation += host.Person.Company + "、";
                }
                BaseInformation += "共" + basecnt + "个。";
                foreach (Group P in G.Graph.Groups)
                {
                    if (P.Persons.Contains(host.Person) && P.Persons.Contains(n.Person))
                    {
                        GroupInformation += P.Name + "、";
                        groupcnt++;
                    }
                }
                GroupInformation += "共" + groupcnt + "个。";      
                string infor= FriendcntInformation + '\n' + BaseInformation + '\n' + GroupInformation + '\n';
                n.Person.Information = infor.Replace("、共","共");
                n.Person.Score = G.FriendWeight * friendcnt + G.BaseWeight * basecnt + G.GroupWeight * groupcnt;
            }
        }

        private async void Add_Click(object sender, RoutedEventArgs e)
        {
            Person P = new Person("", "", "", "", "", "");
            Infromation.DataContext=P;
            Node N = new Node();
            N.Person = P;
            ObservableCollection<Node> source=People.ItemsSource as ObservableCollection<Node>;
            source.Add(N);
            await Task.Delay(1);
            AdjustLayOut();
        }

        private async void Remove_Click(object sender, RoutedEventArgs e)
        {
            Person n = (Infromation as Grid).DataContext as Person;
            ObservableCollection<Node> source = People.ItemsSource as ObservableCollection<Node>;
            foreach (Node t in source)
            {
                if (t.Person==n)
                {
                    source.Remove(t);
                    break;
                }
            }
            await Task.Delay(1);
            AdjustLayOut();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            WhiteBoard.Children.Clear();
            List<Grid> buttons = GetChildObjects<Grid>(People, "");
            Node target = (sender as Button).DataContext as Node;
            Person p = Infromation.DataContext as Person;
            foreach (Grid t in buttons)
            {
                Node source = t.DataContext as Node;
                if (source.Person == p)
                {
                    target.Friends.Remove(source.Person);
                    source.Friends.Remove(target.Person);
                }
            }
            foreach (Grid t in buttons)
            {
                Node data = t.DataContext as Node;
                data.Add = "Collapsed";
                data.Delete = "Collapsed";
            }
            foreach (Grid t in buttons)
            {
                Node data = t.DataContext as Node;
                if (data.Person == Infromation.DataContext)
                {
                    foreach (Grid t_friend in buttons)
                    {
                        Node data_friend = t_friend.DataContext as Node;
                        if (data_friend.Friends.Contains(data.Person))
                        {
                            Point P = t.TransformToAncestor(People).Transform(new Point(0, 0));
                            Point P_friend = t_friend.TransformToAncestor(People).Transform(new Point(0, 0));
                            Line line = new Line { X1 = P.X + t.ActualWidth / 2, Y1 = P.Y + t.ActualHeight / 2, X2 = P_friend.X + t_friend.ActualWidth / 2, Y2 = P_friend.Y + t_friend.ActualHeight / 2, Stroke = Brushes.Red };
                            WhiteBoard.Children.Add(line);
                            data_friend.Delete = "Visible";
                        }
                        else
                        {
                            data_friend.Add = "Visible";
                        }
                    }
                    data.Add = "Collapsed";
                    data.Delete = "Collapsed";
                    break;
                }
            }
        }

        private void add_Click_1(object sender, RoutedEventArgs e)
        {
            WhiteBoard.Children.Clear();
            List<Grid> buttons = GetChildObjects<Grid>(People, "");
            Node target = (sender as Button).DataContext as Node;
            Person p = Infromation.DataContext as Person;
            foreach (Grid t in buttons)
            {
                Node source = t.DataContext as Node;
                if (source.Person==p)
                {
                    target.Friends.Add(source.Person);
                    source.Friends.Add(target.Person);
                }
            }
            foreach (Grid t in buttons)
            {
                Node data = t.DataContext as Node;
                data.Add = "Collapsed";
                data.Delete = "Collapsed";
            }
            foreach (Grid t in buttons)
            {
                Node data = t.DataContext as Node;
                if (data.Person == Infromation.DataContext)
                {
                    foreach (Grid t_friend in buttons)
                    {
                        Node data_friend = t_friend.DataContext as Node;
                        if (data_friend.Friends.Contains(data.Person))
                        {
                            Point P = t.TransformToAncestor(People).Transform(new Point(0, 0));
                            Point P_friend = t_friend.TransformToAncestor(People).Transform(new Point(0, 0));
                            Line line = new Line { X1 = P.X + t.ActualWidth / 2, Y1 = P.Y + t.ActualHeight / 2, X2 = P_friend.X + t_friend.ActualWidth / 2, Y2 = P_friend.Y + t_friend.ActualHeight / 2, Stroke = Brushes.Red };
                            WhiteBoard.Children.Add(line);
                            data_friend.Delete = "Visible";
                        }
                        else
                        {
                            data_friend.Add = "Visible";
                        }
                    }
                    data.Add = "Collapsed";
                    data.Delete = "Collapsed";
                    break;
                }
            }
        }

        private void Adjust_Click(object sender, RoutedEventArgs e)
        {
            InitialzeGraphView();
        }

        private void Chioce_Click(object sender, RoutedEventArgs e)
        {
            Group G = (sender as Button).DataContext as Group;
            Person P = Infromation.DataContext as Person;
            if (P.Groups.Contains(G))
            {
                P.Groups.Remove(G);
                G.Persons.Remove(P);
                G.Content = "加入";
            }
            else
            {
                P.Groups.Add(G);
                G.Persons.Add(P);
                G.Content = "退出";
            }
        }

        private void Groups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Groups.SelectedIndex == -1)
                return;
            Selected.Text ="当前选定："+ (Groups.SelectedItem as Group).Name;
        }

        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            Group temp = new Group();
            temp.Content = "加入";
            G.Graph.Groups.Add(temp);
        }

        private void eleteGroup_Click(object sender, RoutedEventArgs e)
        {
            if (Groups.SelectedIndex == -1)
                return;
            Group t = Groups.SelectedItem as Group;
            foreach (Node n in G.Graph.Nodes)
            {
                Person p = n.Person;
                if (p.Groups.Contains(t))
                {
                    p.Groups.Remove(t);
                }
            }
            t.Persons.Clear();
            G.Graph.Groups.Remove(t);
            Selected.Text = "";
        }
    }
}
