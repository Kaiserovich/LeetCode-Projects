using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace PracticeConsoleApp
{

    public interface INode
    {
        /// <summary>
        /// Разновидность узла
        /// </summary>
        VarietyNode Variety { get; set; }
        /// <summary>
        /// ID узла дерева
        /// </summary>
        long IDNode { get; set; }
        /// <summary>
        /// ID дерева
        /// </summary>
        long IDTree { get; set; }
        /// <summary>
        /// Ссылка на родительский узел
        /// </summary>
        INode ParentNode { get; set; }
        /// <summary>
        /// Список дочерних узлов
        /// </summary>
        ObservableCollection<INode> Nodes { get; set; }
        /// <summary>
        /// Текстовое значение элемента
        /// </summary>
        string Text { get; }
        /// <summary>
        /// Выбран элемент или нет
        /// </summary>
        bool IsSelected { get; set; }
        /// <summary>
        /// Развернут элемент или нет
        /// </summary>
        bool IsExpand { get; set; }
        /// <summary>
        /// Показывать ли узел
        /// </summary>
        bool IsVisibile { get; set; }
    }

    public class Node : INode
    {
        public VarietyNode Variety { get; set; }
        public long IDNode { get; set; }
        public long IDTree { get; set; }
        public INode ParentNode { get; set; }
        public ObservableCollection<INode> Nodes { get; set; }
        public string Text { get; set; }
        public bool IsSelected { get; set; }
        public bool IsExpand { get; set; }
        public bool IsVisibile { get; set; }
    }

    public class MyClass
    {
        //предыстория:
        //на вход поступает массив данных,все элементы уникальные
        //из данных массива строятся деревья, получается список деревьев
        //дальше этот список деревьев разбивается на части (страницы) для вывода пользователю
        //формируется словарь, Key - порядковый номер страницы, Value - список деревьев на страницу
        private Dictionary<int, List<INode>> _CacheTree;

        public MyClass()
        {
            _CacheTree = new Dictionary<int, List<INode>>();

            int listCount = 9;
            int nodeCount = 4;
            int numberOfList = 1;

            List<INode> nodeList = new List<INode>();
            for (int i = 0; i < listCount; i++)
            {
                INode[] nodes = new INode[nodeCount];
                for (int j = nodeCount-1; j >= 0; j--)
                {
                    if (j  == 0)
                    {
                        nodes[j] = new Node
                        {
                            Text = $"{i}{j}",
                            Nodes = new ObservableCollection<INode> { nodes[1], nodes[2] }
                        };
                    }
                    else if (j == 2)
                    {
                        nodes[j] = new Node
                        {
                            Text = $"{i}{j}",
                            Nodes = new ObservableCollection<INode>{nodes[3]}
                    };
                    }
                    else
                    {
                        nodes[j] = new Node
                        {
                            Text = $"{i}{j}"
                        };
                    }
                    
                }
                nodeList.Add(nodes.FirstOrDefault());
                if (i % 2 == 1)
                {
                    _CacheTree.Add(numberOfList, nodeList);
                    numberOfList++;
                    nodeList = new List<INode>();
                }

            }
        }

        /// <summary>
        /// метод для поиска элемента
        /// </summary>
        /// <param name="inputValue">пользовательский текстовый ввод для поиска</param>
        public List<INode> Search(string inputValue)
        {
            if (_CacheTree == null) return null;

            int dictionarypPagesCount = _CacheTree.Count;
            List<INode> nodeList;
            List<INode> resultNodeList = new List<INode>();

            for (int pageNumber = 1; pageNumber <= dictionarypPagesCount; pageNumber++)
            {
                _CacheTree.TryGetValue(pageNumber, out nodeList);

                int listCount = nodeList.Count;
                nodeList.RemoveRange(0, 1);
                for (int j = 0; j < listCount; j++)
                {
                }

            }
            return null;
        }
    }

    /// <summary>
    /// Разновидность узла
    /// </summary>
    public enum VarietyNode
    {
        /// <summary>
        /// Не определено
        /// </summary>
        Undefined = 0,
        /// <summary>
        /// Узел группировки
        /// </summary>
        Group = 1,
        /// <summary>
        /// Корневой узел дерева
        /// </summary>
        Root = 2,
        /// <summary>
        /// Просто узел
        /// </summary>
        Node = 3
    }
}
