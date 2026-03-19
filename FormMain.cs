using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static BestCHM.TreeViewOperator;

namespace BestCHM
{
    public partial class FormMain : Form
    {
        private string projectPath = "";
        private Dictionary<TreeNode, DirectoryItem> nodeDatas = new Dictionary<TreeNode, DirectoryItem>();
        private string solFileName = string.Empty; // 方案文件
        public FormMain()
        {
            InitializeComponent();
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var item = e.Node.Tag as DirectoryItem;
            if (item == null) return;

            // 加载 HTML 内容
            var htmlPath = Path.Combine(projectPath, item.Filename);
            if (File.Exists(htmlPath))
            {
                fastColoredTextBox1.Text = File.ReadAllText(htmlPath, Encoding.UTF8);
                wbPreview.DocumentText = fastColoredTextBox1.Text;
            }
            else
            {
                fastColoredTextBox1.Text = "<!DOCTYPE html><html><head><title>" + item.Title + "</title></head><body><h1>" + item.Title + "</h1><p>内容未找到。</p ></body></html>";
                wbPreview.DocumentText = fastColoredTextBox1.Text;
            }
        }

        private void BtnCompile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(projectPath))
            {
                MessageBox.Show("请先选择项目路径！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                GenerateHHP();
                GenerateHHCTree();
                GenerateHHKIndex();

                var hhpPath = Path.Combine(projectPath, "project.hhp");
                var hhcPath = @"C:\Program Files (x86)\HTML Help Workshop\hhc.exe";

                var psi = new ProcessStartInfo
                {
                    FileName = hhcPath,
                    Arguments = $"\"{hhpPath}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                using (var proc = Process.Start(psi))
                {
                    proc.WaitForExit();
                    if (proc.ExitCode == 0)
                    {
                        MessageBox.Show("✅ CHM 文件生成成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("❌ 编译失败：" + proc.StandardError.ReadToEnd(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateHHP()
        {
            var hhpContent = @"
            [OPTIONS]
            Auto Index=Yes
            Binary TOC=Yes
            Compatibility=1.1 or later
            Compiled file=Help.chm
            Contents file=project.hhc
            Default Window=Main
            Default topic=index.html
            Display compile progress=Yes
            Full-text search=Yes
            Index file=project.hhk
            Language=0x804 Chinese (Simplified)

            [WINDOWS]
            Main=,""project.hhc"",""project.hhk"",""index.html""

            [FILES]
            index.html
            cam_debug.html
            roi.html
            install.html
            add_camera.html
            test.html

            [INFOTYPES]
            ";
            File.WriteAllText(Path.Combine(projectPath, "project.hhp"), hhpContent, Encoding.UTF8);
        }

        private void GenerateHHCTree()
        {
            var sb = new StringBuilder();
            sb.AppendLine(@"<!DOCTYPE HTML PUBLIC ""-//IETF//DTD HTML//EN"">");
            sb.AppendLine("<HTML><HEAD>");
            sb.AppendLine("<meta name=\"GENERATOR\" content=\"CHMEditor v1.0\">");
            sb.AppendLine("</HEAD><BODY>");
            sb.AppendLine("<UL>");

            foreach (var node1 in treeView1.Nodes[0].Nodes)
            {
                var node = node1 as TreeNode;
                var item = node?.Tag as DirectoryItem;
                if (item != null)
                {
                    sb.AppendLine($"<LI><OBJECT type=\"text/sitemap\">");
                    sb.AppendLine($"<param name=\"Name\" value=\"{item.Title}\">");
                    sb.AppendLine($"<param name=\"Local\" value=\"{item.Filename}\">");
                    sb.AppendLine($"</OBJECT></LI>");
                }
            }

            sb.AppendLine("</UL></BODY></HTML>");
            File.WriteAllText(Path.Combine(projectPath, "project.hhc"), sb.ToString(), Encoding.UTF8);
        }

        private void GenerateHHKIndex()
        {
            var sb = new StringBuilder();
            sb.AppendLine(@"<!DOCTYPE HTML PUBLIC ""-//IETF//DTD HTML//EN"">");
            sb.AppendLine("<HTML><HEAD>");
            sb.AppendLine("<meta name=\"GENERATOR\" content=\"CHMEditor v1.0\">");
            sb.AppendLine("</HEAD><BODY>");
            sb.AppendLine("<UL>");

            foreach (var node1 in treeView1.Nodes[0].Nodes)
            {
                var node = node1 as TreeNode;
                var item = node?.Tag as DirectoryItem;
                if (item != null)
                {
                    sb.AppendLine($"<LI><OBJECT type=\"text/sitemap\">");
                    sb.AppendLine($"<param name=\"Name\" value=\"{item.Title}\">");
                    sb.AppendLine($"<param name=\"Local\" value=\"{item.Filename}\">");
                    sb.AppendLine($"</OBJECT></LI>");
                }
            }

            sb.AppendLine("</UL></BODY></HTML>");
            File.WriteAllText(Path.Combine(projectPath, "project.hhk"), sb.ToString(), Encoding.UTF8);
        }

        /// <summary>
        /// 展开到指定节点的函数
        /// </summary>
        /// <param name="treeView">目标树控件</param>
        /// <param name="targetNode">要展开并选中的节点</param>
        private void ExpandToNode(System.Windows.Forms.TreeView treeView, TreeNode targetNode)
        {
            // 先折叠所有节点
            //treeView.CollapseAll();

            // 展开从根节点到目标节点的所有父节点
            TreeNode node = targetNode;
            while (node != null)
            {
                node.Expand();
                node = node.Parent;
            }

            // 确保节点可见（滚动到节点位置）
            targetNode.EnsureVisible();
        }
        /// <summary>
        /// 切换标签页时触发，可以在这里实现预览和编辑区域的同步更新等逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab.Text == "效果预览")
            {
                PreviewHtml();
            }
        }
        // 核心方法：将FastColoredTextBox中的HTML文本呈现到WebBrowser控件中
        private void PreviewHtml()
        {
            try
            {
                // 获取FastColoredTextBox中的HTML文本
                string htmlContent = fastColoredTextBox1.Text;

                // 将HTML内容设置到WebBrowser控件中显示
                wbPreview.DocumentText = htmlContent;

                // 或者使用NavigateToString方法（适用于较新版本的WebBrowser控件）
                wbPreview.Document.Write(htmlContent);
                wbPreview.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"预览HTML时发生错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DirectoryItem itemInit = new DirectoryItem
            {
                Title = "新节点",
                Filename = "",
                Icon = NodeIcon.文档.ToString()
            };
            FormNodeSetting formNodeSetting = new FormNodeSetting(itemInit);
            formNodeSetting.PublishNodeInfos += NewNode;
            formNodeSetting.ShowDialog();
        }

        private void NewNode(object s, DirectoryItem nodeInfo)
        {
            TreeNode parent = treeView1.SelectedNode;

            if (treeView1.Nodes.Count == 0)
            {
                // 添加首个节点时
                var node = new TreeNode(nodeInfo.Title);
                node.Tag = nodeInfo;
                node.ImageKey = nodeInfo.Icon;
                node.SelectedImageKey = nodeInfo.Icon;
                treeView1.Nodes.Add(node);
                nodeDatas[node] = nodeInfo;
            }
            else
            {
                if (parent == null) return;  // 没有选中节点直接返回
                var newNode = AddTreeNode(parent, nodeInfo);
                nodeDatas[newNode] = nodeInfo;
                ExpandToNode(treeView1, newNode);
                treeView1.SelectedNode = parent;
            }
        }

        /// <summary>
        /// 上移节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxUp_Click(object sender, EventArgs e)
        {
            MoveTreeNode(treeView1, MoveDirection.Up);
        }
        /// <summary>
        /// 下移节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDown_Click(object sender, EventArgs e)
        {
            MoveTreeNode(treeView1, MoveDirection.Down);
        }
        /// <summary>
        /// 左移节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {
            MoveTreeNode(treeView1, MoveDirection.Left);
        }
        /// <summary>
        /// 右移节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            MoveTreeNode(treeView1, MoveDirection.Right);
        }
        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryItem itemInit = new DirectoryItem
            {
                Title = "新节点",
                Filename = "",
                Icon = NodeIcon.文档.ToString()
            };
            FormNodeSetting formNodeSetting = new FormNodeSetting(itemInit);
            formNodeSetting.PublishNodeInfos += NewNode;
            formNodeSetting.ShowDialog();
        }
        /// <summary>
        /// 删除当前节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否删除当前节点及其子节点？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                nodeDatas.Remove(treeView1.SelectedNode);
                treeView1.SelectedNode.Remove();
            }
        }
        /// <summary>
        /// 展开当前节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 展开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.ExpandAll();
        }
        /// <summary>
        /// 折叠当前节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 折叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Collapse();
        }
        /// <summary>
        /// 设置当前节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                FormNodeSetting formNodeSetting = new FormNodeSetting(nodeDatas[treeView1.SelectedNode]);
                formNodeSetting.PublishNodeInfos += (s, nodeInfo) =>
                {
                    treeView1.SelectedNode.Text = nodeInfo.Title;
                    treeView1.SelectedNode.ImageKey = nodeInfo.Icon;
                    treeView1.SelectedNode.SelectedImageKey = nodeInfo.Icon;
                    nodeDatas[treeView1.SelectedNode] = nodeInfo;
                };
                formNodeSetting.ShowDialog();
            }
        }
        /// <summary>
        /// 新建chm项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_New_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 打开chm项目
        /// </summary>
        private void tsb_Open_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonText = File.ReadAllText(openFileDialog1.FileName);
                    var dataModel = JsonConvert.DeserializeObject<List<ConfigureInfos>>(jsonText);
                    if (dataModel == null)
                    {
                        MessageBox.Show($"打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    treeView1.Nodes.Clear();
                    var restoreNodes = ConvertDtoToTree(dataModel);
                    treeView1.Nodes.AddRange(restoreNodes.ToArray());
                    treeView1.ExpandAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"打开失败！原因：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Save_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count != 0)
            {
                try
                {
                    // 步骤1：将树节点集合转换成可序列化的配置信息
                    List<TreeNode> nodes = new List<TreeNode>();
                    foreach (TreeNode node in treeView1.Nodes)
                    {
                        nodes.Add(node);
                    }
                    var dataModel = ConvertTreeToDto(nodes);

                    // 步骤2：使用ConfigureSave类将配置信息保存到文件
                    string jsonText = JsonConvert.SerializeObject(dataModel, Formatting.Indented);
                    if(solFileName != string.Empty)
                        File.WriteAllText(solFileName, jsonText);
                    else
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            Filter = "CHM项目文件 (*.chmProj)|*.chmProj",
                            Title = "保存CHM项目配置"
                        };
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(saveFileDialog.FileName, jsonText);
                            solFileName = saveFileDialog.FileName;
                        }
                    }
                    MessageBox.Show($"保存成功！路径：{solFileName}");
                }
                catch (Exception)
                {
                    MessageBox.Show($"保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
        /// <summary>
        /// 将树节点集合转换成可序列化的配置信息
        /// </summary>
        /// <param name="treeNode"></param>
        /// <returns></returns>
        private List<ConfigureInfos> ConvertTreeToDto(List<TreeNode> treeNode)
        {
            var list = new List<ConfigureInfos>();
            foreach (TreeNode node in treeNode.ToArray())
            {
                List<TreeNode> nodes1 = new List<TreeNode>();
                foreach (TreeNode node1 in node.Nodes)
                {
                    nodes1.Add(node1);
                }
                var nodes = node.Nodes;
                var dto = new ConfigureInfos
                {
                    NodeName = node.Text,
                    ImageKey = node.ImageKey,
                    SelectedImageKey = node.SelectedImageKey,
                    Children = ConvertTreeToDto(nodes1),
                    FilePath = nodeDatas.ContainsKey(node) ? nodeDatas[node].Filename : ""
                };
                list.Add(dto);
            }
            return list;
        }
        /// <summary>
        /// 序列化信息转成树节点集合
        /// </summary>
        /// <param name="configureInfos"></param>
        /// <returns></returns>
        private List<TreeNode> ConvertDtoToTree(List<ConfigureInfos> configureInfos)
        {
            var list = new List<TreeNode>();
            foreach (var info in configureInfos)
            {
                var item = new DirectoryItem()
                {
                    Title = info.NodeName,
                    Filename = info.FilePath,
                    Icon = info.ImageKey
                };
                var node = new TreeNode(info.NodeName)
                {
                    Text = info.NodeName,
                    ImageKey = info.ImageKey,
                    SelectedImageKey = info.SelectedImageKey,
                    Tag = item
                };
                var children = ConvertDtoToTree(info.Children);
                nodeDatas[node] = item;
                node.Nodes.AddRange(children.ToArray());
                list.Add(node);
            }
            return list;
        }
        /// <summary>
        /// 编译
        /// </summary>
        private void tsb_Run_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 购买
        /// </summary>
        private void tsb_Buy_Click(object sender, EventArgs e)
        {

        }
    }
}
