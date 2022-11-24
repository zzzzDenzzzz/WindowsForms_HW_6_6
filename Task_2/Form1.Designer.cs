namespace Task_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip_menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_explorer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_quantityElement = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_path = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.menuStrip_menu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_menu
            // 
            this.menuStrip_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_explorer});
            this.menuStrip_menu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_menu.Name = "menuStrip_menu";
            this.menuStrip_menu.Size = new System.Drawing.Size(695, 24);
            this.menuStrip_menu.TabIndex = 0;
            this.menuStrip_menu.Text = "menuStrip1";
            // 
            // toolStripMenuItem_explorer
            // 
            this.toolStripMenuItem_explorer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_open,
            this.toolStripMenuItem2,
            this.toolStripMenuItem_exit});
            this.toolStripMenuItem_explorer.Name = "toolStripMenuItem_explorer";
            this.toolStripMenuItem_explorer.Size = new System.Drawing.Size(75, 20);
            this.toolStripMenuItem_explorer.Text = "Проводник";
            // 
            // toolStripMenuItem_open
            // 
            this.toolStripMenuItem_open.Name = "toolStripMenuItem_open";
            this.toolStripMenuItem_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem_open.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_open.Text = "Открыть";
            this.toolStripMenuItem_open.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem_exit
            // 
            this.toolStripMenuItem_exit.Name = "toolStripMenuItem_exit";
            this.toolStripMenuItem_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItem_exit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_exit.Text = "&Выход";
            this.toolStripMenuItem_exit.Click += new System.EventHandler(this.Exit);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(215, 24);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(480, 343);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.DoubleClick += new System.EventHandler(this.OpenFile);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Treetog-I-Documents.ico");
            this.imageList.Images.SetKeyName(1, "Double-J-Design-Origami-File.ico");
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_quantityElement,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_path});
            this.statusStrip.Location = new System.Drawing.Point(0, 367);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(695, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_quantityElement
            // 
            this.toolStripStatusLabel_quantityElement.Name = "toolStripStatusLabel_quantityElement";
            this.toolStripStatusLabel_quantityElement.Size = new System.Drawing.Size(136, 17);
            this.toolStripStatusLabel_quantityElement.Text = "Колличество элементов: ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // toolStripStatusLabel_path
            // 
            this.toolStripStatusLabel_path.Name = "toolStripStatusLabel_path";
            this.toolStripStatusLabel_path.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel_path.Text = "Путь: ";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView.Location = new System.Drawing.Point(0, 24);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(209, 343);
            this.treeView.TabIndex = 5;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 389);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip_menu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проводник";
            this.menuStrip_menu.ResumeLayout(false);
            this.menuStrip_menu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_menu;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_quantityElement;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_path;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_explorer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_open;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_exit;
    }
}

