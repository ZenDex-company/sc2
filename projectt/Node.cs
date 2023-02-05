using System.Collections.ObjectModel;

namespace projectt
{
    public class Node
    {
        public string Name { get; set; }
        public ObservableCollection<Node> Nodes { get; set; }
        public string Value { get; set; }
        public string Link { get; set; }
    }
}
