namespace BestCHM
{
    partial class FormNodeSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNodeSetting));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIcon = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxIcon = new System.Windows.Forms.ComboBox();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.48289F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.44106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelIcon, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxIcon, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFilePath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonOK, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1052, 432);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelIcon
            // 
            this.labelIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIcon.AutoSize = true;
            this.labelIcon.Location = new System.Drawing.Point(673, 58);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(124, 28);
            this.labelIcon.TabIndex = 0;
            this.labelIcon.Text = "节点图标";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(51, 58);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(124, 28);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "节点名称";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxName, 2);
            this.textBoxName.Location = new System.Drawing.Point(246, 52);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(374, 39);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "新节点";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxIcon
            // 
            this.comboBoxIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxIcon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIcon.FormattingEnabled = true;
            this.comboBoxIcon.Items.AddRange(new object[] {
            "书本打开",
            "书本合上",
            "文档",
            "问号文档"});
            this.comboBoxIcon.Location = new System.Drawing.Point(843, 54);
            this.comboBoxIcon.Name = "comboBoxIcon";
            this.comboBoxIcon.Size = new System.Drawing.Size(206, 40);
            this.comboBoxIcon.TabIndex = 2;
            this.comboBoxIcon.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxFilePath, 3);
            this.textBoxFilePath.Location = new System.Drawing.Point(246, 196);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(584, 39);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "绑定HTML文件";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(887, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Location = new System.Drawing.Point(676, 331);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 57);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOK.Location = new System.Drawing.Point(264, 331);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(117, 57);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "书本打开");
            this.imageList1.Images.SetKeyName(1, "书本合上");
            this.imageList1.Images.SetKeyName(2, "文档");
            this.imageList1.Images.SetKeyName(3, "问号文档");
            // 
            // FormNodeSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 472);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNodeSetting";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "节点设置";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelIcon;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxIcon;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ImageList imageList1;
    }
}