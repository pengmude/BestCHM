using System;
using System.Drawing;
using System.Windows.Forms;
using static BestCHM.TreeViewOperator;
using ComboBox = System.Windows.Forms.ComboBox;

namespace BestCHM
{
    public partial class FormNodeSetting : Form
    {
        public EventHandler<DirectoryItem> PublishNodeInfos; // 发布节点信息的事件
        public FormNodeSetting()
        {
            InitializeComponent();
        }

        public FormNodeSetting(DirectoryItem item)
        {
            InitializeComponent();
            textBoxName.Text = item.Title;
            textBoxFilePath.Text = item.Filename;
            comboBoxIcon.SelectedItem = item.Icon;
        }

        /// <summary>
        /// 自定义绘制ComboBox项（只显示图片，不显示文本）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox cb = sender as ComboBox;
            int index = cb.SelectedIndex;
            e.DrawBackground();

            // 获取图片键
            string imageKey = cb.Items[e.Index].ToString();

            // 绘制图片
            if (imageList1.Images.ContainsKey(imageKey))
            {
                Image img = imageList1.Images[imageKey];
                Rectangle imageRect = new Rectangle(
                    (e.Bounds.Left + e.Bounds.Right) / 3,
                    e.Bounds.Top + (e.Bounds.Height - img.Height) / 2,
                    img.Width,
                    img.Height
                );
                e.Graphics.DrawImage(img, imageRect);
            }

            e.DrawFocusRectangle();
            cb.SelectedIndex = index == -1 ? 0 : index;
        }
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            var infos = new DirectoryItem
            {
                Title = textBoxName.Text,
                Icon = comboBoxIcon.Text,
                Filename = textBoxFilePath.Text
            };
            PublishNodeInfos.Invoke(this, infos);
            Close();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
