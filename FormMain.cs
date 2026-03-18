using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BestCHM
{
    public partial class FormMain : Form
    {
        private string projectPath = "";
        private List<DirectoryItem> directoryItems = new List<DirectoryItem>();

        public FormMain()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            //var root = treeView.Nodes[0];
            //AddTreeNode(root, "1. 视觉安装", "folder.png", "index.html");
            //AddTreeNode(root, "2. 相机成像调试", "folder.png", "cam_debug.html");
            //AddTreeNode(root, "3. 图像 ROI 设置", "folder.png", "roi.html");
            //AddTreeNode(root, "4. 视觉软件安装", "folder.png", "install.html");
            //AddTreeNode(root, "5. 重新添加相机和PLC", "folder.png", "add_camera.html");
            //AddTreeNode(root, "6. 运行测试", "folder.png", "test.html");
        }

        private void AddTreeNode(TreeNode parent, string text, string icon, string filename)
        {
            var node = new TreeNode(text);
            node.Tag = new DirectoryItem { Title = text, Filename = filename };
            node.ImageKey = icon;
            node.SelectedImageKey = icon;
            parent.Nodes.Add(node);
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

        private class DirectoryItem
        {
            public string Title { get; set; }
            public string Filename { get; set; }
            public string Icon { get; set; }
        }

        private void buttonUp1_Click(object sender, EventArgs e)
        {
            var root = treeView1.Nodes[0];
            AddTreeNode(root, "节点", "folder.png", "index.html");
        }
    }
}
