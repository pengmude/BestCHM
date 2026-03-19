using System.Collections.Generic;
using System.Windows.Forms;

namespace BestCHM
{
    public class TreeViewOperator
    {
        /// <summary>
        /// 节点图标枚举
        /// </summary>
        public enum NodeIcon
        {
            书本合上,
            书本打开,
            文档,
            问号文档
        }
        /// <summary>
        /// 每个节点项
        /// </summary>
        public class DirectoryItem
        {
            public string Title { get; set; }
            public string Filename { get; set; }
            public string Icon { get; set; }
        }

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="text"></param>
        /// <param name="icon"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static TreeNode AddTreeNode(TreeNode parent, DirectoryItem item)
        {
            var node = new TreeNode(item.Title);
            node.Tag = item;
            node.ImageKey = item.Icon;
            node.SelectedImageKey = item.Icon;
            parent.Nodes.Add(node);
            return node;
        }

        /// <summary>
        /// 节点移动方向枚举
        /// </summary>
        public enum MoveDirection
        {
            Up,
            Down,
            Left,
            Right
        }
        /// <summary>
        /// 移动树节点的通用方法
        /// </summary>
        /// <param name="treeView">目标树控件</param>
        /// <param name="direction">移动方向</param>
        public static void MoveTreeNode(TreeView treeView, MoveDirection direction)
        {
            TreeNode selectedNode = treeView.SelectedNode;
            if (selectedNode == null) return;

            switch (direction)
            {
                case MoveDirection.Up:
                    MoveNodeUp(selectedNode);
                    break;
                case MoveDirection.Down:
                    MoveNodeDown(selectedNode);
                    break;
                case MoveDirection.Left:
                    MoveNodeLeft(selectedNode);
                    break;
                case MoveDirection.Right:
                    MoveNodeRight(selectedNode);
                    break;
            }
        }

        /// <summary>
        /// 上移节点：与同级上一个节点交换位置
        /// </summary>
        /// <param name="node">要移动的节点</param>
        private static void MoveNodeUp(TreeNode node)
        {
            TreeNode parent = node.Parent;
            TreeNodeCollection nodes = parent == null ? node.TreeView.Nodes : parent.Nodes;
            int index = node.Index;

            // 如果是第一个节点，无法上移
            if (index == 0) return;

            // 从原位置移除
            nodes.RemoveAt(index);
            // 插入到上一个位置
            nodes.Insert(index - 1, node);

            // 保持选中状态
            node.TreeView.SelectedNode = node;
        }

        /// <summary>
        /// 下移节点：与同级下一个节点交换位置
        /// </summary>
        /// <param name="node">要移动的节点</param>
        private static void MoveNodeDown(TreeNode node)
        {
            TreeNode parent = node.Parent;
            TreeNodeCollection nodes = parent == null ? node.TreeView.Nodes : parent.Nodes;
            int index = node.Index;
            int lastIndex = nodes.Count - 1;

            // 如果是最后一个节点，无法下移
            if (index == lastIndex) return;

            // 从原位置移除
            nodes.RemoveAt(index);
            // 插入到下一个位置
            nodes.Insert(index + 1, node);

            // 保持选中状态
            node.TreeView.SelectedNode = node;
        }

        /// <summary>
        /// 左移节点：提升一个层级，与父节点平级
        /// </summary>
        /// <param name="node">要移动的节点</param>
        private static void MoveNodeLeft(TreeNode node)
        {
            TreeNode parent = node.Parent;
            // 如果没有父节点，无法左移
            if (parent == null) return;

            TreeNode grandParent = parent.Parent;
            TreeNodeCollection targetNodes = grandParent == null ? node.TreeView.Nodes : grandParent.Nodes;
            int parentIndex = parent.Index;

            // 从原父节点中移除
            parent.Nodes.Remove(node);
            // 插入到父节点的下一个位置
            targetNodes.Insert(parentIndex + 1, node);

            // 保持选中状态
            node.TreeView.SelectedNode = node;
        }

        /// <summary>
        /// 右移节点：降低一个层级，成为上一个兄弟节点的子节点
        /// </summary>
        /// <param name="node">要移动的节点</param>
        private static void MoveNodeRight(TreeNode node)
        {
            TreeNode parent = node.Parent;
            TreeNodeCollection nodes = parent == null ? node.TreeView.Nodes : parent.Nodes;
            int index = node.Index;

            // 如果是第一个节点，无法右移
            if (index == 0) return;

            TreeNode upperSibling = nodes[index - 1];

            // 从原位置移除
            nodes.RemoveAt(index);
            // 添加到上一个兄弟节点的子节点中
            upperSibling.Nodes.Add(node);
            upperSibling.Expand();

            // 保持选中状态
            node.TreeView.SelectedNode = node;
        }
    }
}
