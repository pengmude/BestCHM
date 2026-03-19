namespace BestCHM
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_New = new System.Windows.Forms.ToolStripButton();
            this.tsb_Open = new System.Windows.Forms.ToolStripButton();
            this.tsb_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Run = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Buy = new System.Windows.Forms.ToolStripButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.wbPreview = new System.Windows.Forms.WebBrowser();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.展开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.折叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(95, 27);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharCnWidth = 29;
            this.fastColoredTextBox1.CharHeight = 27;
            this.fastColoredTextBox1.CharWidth = 14;
            this.fastColoredTextBox1.CommentPrefix = null;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9F);
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
            this.fastColoredTextBox1.LeftBracket = '<';
            this.fastColoredTextBox1.LeftBracket2 = '(';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = '>';
            this.fastColoredTextBox1.RightBracket2 = ')';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(1190, 1061);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Text = "示例文本";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.注册ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1854, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(82, 35);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(82, 35);
            this.注册ToolStripMenuItem.Text = "注册";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(82, 35);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_New,
            this.tsb_Open,
            this.tsb_Save,
            this.toolStripSeparator1,
            this.tsb_Run,
            this.toolStripSeparator2,
            this.tsb_Buy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 39);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1854, 42);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_New
            // 
            this.tsb_New.Image = global::BestCHM.Properties.Resources.新建;
            this.tsb_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_New.Name = "tsb_New";
            this.tsb_New.Size = new System.Drawing.Size(98, 36);
            this.tsb_New.Text = "新建";
            this.tsb_New.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsb_New.Click += new System.EventHandler(this.tsb_New_Click);
            // 
            // tsb_Open
            // 
            this.tsb_Open.Image = global::BestCHM.Properties.Resources.打开;
            this.tsb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Open.Name = "tsb_Open";
            this.tsb_Open.Size = new System.Drawing.Size(98, 36);
            this.tsb_Open.Text = "打开";
            this.tsb_Open.Click += new System.EventHandler(this.tsb_Open_Click);
            // 
            // tsb_Save
            // 
            this.tsb_Save.Image = global::BestCHM.Properties.Resources.保存;
            this.tsb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Save.Name = "tsb_Save";
            this.tsb_Save.Size = new System.Drawing.Size(98, 36);
            this.tsb_Save.Text = "保存";
            this.tsb_Save.Click += new System.EventHandler(this.tsb_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // tsb_Run
            // 
            this.tsb_Run.Image = global::BestCHM.Properties.Resources.编译;
            this.tsb_Run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Run.Name = "tsb_Run";
            this.tsb_Run.Size = new System.Drawing.Size(187, 36);
            this.tsb_Run.Text = "编译为 CHM";
            this.tsb_Run.Click += new System.EventHandler(this.tsb_Run_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // tsb_Buy
            // 
            this.tsb_Buy.Image = global::BestCHM.Properties.Resources.购买;
            this.tsb_Buy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Buy.Name = "tsb_Buy";
            this.tsb_Buy.Size = new System.Drawing.Size(98, 36);
            this.tsb_Buy.Text = "购买";
            this.tsb_Buy.Click += new System.EventHandler(this.tsb_Buy_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.tabControl1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.panelRight.Size = new System.Drawing.Size(1232, 1134);
            this.panelRight.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1212, 1114);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fastColoredTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1196, 1067);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HTML源码";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.wbPreview);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1196, 1067);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "效果预览";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // wbPreview
            // 
            this.wbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbPreview.Location = new System.Drawing.Point(3, 3);
            this.wbPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPreview.Name = "wbPreview";
            this.wbPreview.Size = new System.Drawing.Size(1190, 1061);
            this.wbPreview.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.tableLayoutPanel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(3, 36, 0, 20);
            this.panelLeft.Size = new System.Drawing.Size(618, 1134);
            this.panelLeft.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 1078);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ImageIndex = 6;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(59, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 6;
            this.treeView1.Size = new System.Drawing.Size(553, 1072);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加节点ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.展开ToolStripMenuItem,
            this.折叠ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 194);
            // 
            // 添加节点ToolStripMenuItem
            // 
            this.添加节点ToolStripMenuItem.Name = "添加节点ToolStripMenuItem";
            this.添加节点ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.添加节点ToolStripMenuItem.Text = "添加";
            this.添加节点ToolStripMenuItem.Click += new System.EventHandler(this.添加节点ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 展开ToolStripMenuItem
            // 
            this.展开ToolStripMenuItem.Name = "展开ToolStripMenuItem";
            this.展开ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.展开ToolStripMenuItem.Text = "展开";
            this.展开ToolStripMenuItem.Click += new System.EventHandler(this.展开ToolStripMenuItem_Click);
            // 
            // 折叠ToolStripMenuItem
            // 
            this.折叠ToolStripMenuItem.Name = "折叠ToolStripMenuItem";
            this.折叠ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.折叠ToolStripMenuItem.Text = "折叠";
            this.折叠ToolStripMenuItem.Click += new System.EventHandler(this.折叠ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "添加.png");
            this.imageList1.Images.SetKeyName(1, "上.png");
            this.imageList1.Images.SetKeyName(2, "下.png");
            this.imageList1.Images.SetKeyName(3, "左.png");
            this.imageList1.Images.SetKeyName(4, "右.png");
            this.imageList1.Images.SetKeyName(5, "书本打开");
            this.imageList1.Images.SetKeyName(6, "书本合上");
            this.imageList1.Images.SetKeyName(7, "文档");
            this.imageList1.Images.SetKeyName(8, "问号文档");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxRight, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxLeft, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxDown, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxUp, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxAdd, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(50, 1072);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxRight.Image = global::BestCHM.Properties.Resources.右;
            this.pictureBoxRight.Location = new System.Drawing.Point(3, 259);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(44, 58);
            this.pictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRight.TabIndex = 11;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.Click += new System.EventHandler(this.pictureBoxRight_Click);
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLeft.Image = global::BestCHM.Properties.Resources.左;
            this.pictureBoxLeft.Location = new System.Drawing.Point(3, 195);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(44, 58);
            this.pictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLeft.TabIndex = 10;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.Click += new System.EventHandler(this.pictureBoxLeft_Click);
            // 
            // pictureBoxDown
            // 
            this.pictureBoxDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDown.Image = global::BestCHM.Properties.Resources.下;
            this.pictureBoxDown.Location = new System.Drawing.Point(3, 131);
            this.pictureBoxDown.Name = "pictureBoxDown";
            this.pictureBoxDown.Size = new System.Drawing.Size(44, 58);
            this.pictureBoxDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDown.TabIndex = 9;
            this.pictureBoxDown.TabStop = false;
            this.pictureBoxDown.Click += new System.EventHandler(this.pictureBoxDown_Click);
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxUp.Image = global::BestCHM.Properties.Resources.上;
            this.pictureBoxUp.Location = new System.Drawing.Point(3, 67);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(44, 58);
            this.pictureBoxUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUp.TabIndex = 8;
            this.pictureBoxUp.TabStop = false;
            this.pictureBoxUp.Click += new System.EventHandler(this.pictureBoxUp_Click);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxAdd.Image = global::BestCHM.Properties.Resources.添加;
            this.pictureBoxAdd.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(44, 58);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdd.TabIndex = 7;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 81);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelRight);
            this.splitContainer1.Size = new System.Drawing.Size(1854, 1134);
            this.splitContainer1.SplitterDistance = 618;
            this.splitContainer1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "“chmProj文件(*.chmProj)|*.chmProj|所有文件(*.*)|*.*”";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 1215);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BastCHM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_New;
        private System.Windows.Forms.ToolStripButton tsb_Open;
        private System.Windows.Forms.ToolStripButton tsb_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_Run;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_Buy;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser wbPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.PictureBox pictureBoxDown;
        private System.Windows.Forms.PictureBox pictureBoxUp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 展开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 折叠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}