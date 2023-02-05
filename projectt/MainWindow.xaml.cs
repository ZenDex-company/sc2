using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace projectt
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Node> nodes { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            nodes = new ObservableCollection<Node>();
            nodes.Add(loadTempNodes());
            treeView1.Items.Add(nodes);
        }
        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var currentNode = (Node)e.NewValue;
            webBrowser1.Navigate(currentNode.Link);
        }
        bool ShowInfoTreeNode(string Name)
        {
            return false;
        }


        Node loadTempNodes() =>
            new Node
            {
                Name = "Угрозы ИБ",
                Link = "file:///C:/Users/xz_xzeev/source/repos/projectt/ugrozi.html",
                Nodes = new ObservableCollection<Node>
                {
                    new Node
                    {
                        Name ="Внутренние",
                        Link = "file:///C:/Users/xz_xzeev/source/repos/projectt/vntr.html",
                        Nodes = new ObservableCollection<Node>
                        {
                            new Node
                            {
                                Name="Антропогенные угрозы (Внутренние)",
                                Nodes = new ObservableCollection<Node>
                                {
                                    new Node{Name="Хищения"},
                                    new Node { Name = "Кража важных данных" },
                                    new Node { Name = "Ошибки организации" }
                                }
                            },
                            new Node
                            {
                                Name = "Техногенные угрозы",
                                Nodes = new ObservableCollection<Node>
                                {
                                    new Node {Name="Отказы технических средств"},
                                    new Node {Name="Сбои ПО в ИС и телекоммуникациях"},
                                    new Node {Name="Нарушене регламентов сбора, обработки и передачи информации"},
                                    new Node {Name="Ошибки персонала систем и т.д."}
                                }
                            },
                            new Node
                            {
                                Name = "Информационные",
                                Nodes = new ObservableCollection<Node>
                                {
                                    new Node {Name="Психологические"},
                                    new Node {Name="Мнение общества"}
                                }
                            },
                            new Node
                            {
                                Name = "Программноматематические",
                                Nodes = new ObservableCollection<Node>
                                {
                                    new Node {Name="Разрушение информационных файлов или системы доступа к ним" },
                                    new Node {Name="Видоизменение информации" },
                                    new Node {Name="Нарушение целостности" },
                                    new Node {Name="Подделка и изменение данных" },
                                    new Node {Name="Ошибки при расчётах или в статических сведениях" }
                                }
                            },
                        }
                    },
                    new Node
                    {
                        Name = "Внешние",
                        Nodes = new ObservableCollection<Node>
                        {
                            new Node
                            {
                                Name="Пользователи или люди, которые не являются сотрудниками",
                                Nodes = new ObservableCollection<Node>
                                {
                                    new Node {Name="Временные пользователи"},
                                    new Node {Name="Партнёры"},
                                    new Node {Name="Посетители"},
                                    new Node {Name="Разработчики",Link="https://mpei.space/oib/theory/2/"},
                                    new Node {Name="Внешние злоумышленники",Link="2" }
                                }
                            },
                            new Node {Name="Погодные явления"},
                            new Node {Name="Форс-мажорные обстоятельства"}
                        }
                    }
                }

            };
    }
}