namespace Task_1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNewDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditorSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelOpen = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelSave = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelNewDocument = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelCopy = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelCut = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelInsert = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelCancel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButtonRedactorSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.panelFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFont = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItemMenu
            // 
            this.toolStripMenuItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemSave,
            this.toolStripMenuItemNewDocument,
            this.toolStripMenuItemCopy,
            this.toolStripMenuItemCut,
            this.toolStripMenuItemInsert,
            this.toolStripMenuItemCancel,
            this.toolStripMenuItemEditorSettings,
            this.toolStripMenuItemSelectAll,
            this.toolStripMenuItemSaveAs});
            this.toolStripMenuItemMenu.Name = "toolStripMenuItemMenu";
            this.toolStripMenuItemMenu.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItemMenu.Text = "Меню";
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemOpen.Text = "Открыть";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemSave.Text = "Сохранить";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // toolStripMenuItemNewDocument
            // 
            this.toolStripMenuItemNewDocument.Name = "toolStripMenuItemNewDocument";
            this.toolStripMenuItemNewDocument.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemNewDocument.Text = "Новый документ";
            this.toolStripMenuItemNewDocument.Click += new System.EventHandler(this.toolStripMenuItemNewDocument_Click);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemCopy.Text = "Копирровать";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItemCopy_Click);
            // 
            // toolStripMenuItemCut
            // 
            this.toolStripMenuItemCut.Name = "toolStripMenuItemCut";
            this.toolStripMenuItemCut.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemCut.Text = "Вырезать";
            this.toolStripMenuItemCut.Click += new System.EventHandler(this.toolStripMenuItemCut_Click);
            // 
            // toolStripMenuItemInsert
            // 
            this.toolStripMenuItemInsert.Name = "toolStripMenuItemInsert";
            this.toolStripMenuItemInsert.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemInsert.Text = "Вставить";
            this.toolStripMenuItemInsert.Click += new System.EventHandler(this.toolStripMenuItemInsert_Click);
            // 
            // toolStripMenuItemCancel
            // 
            this.toolStripMenuItemCancel.Name = "toolStripMenuItemCancel";
            this.toolStripMenuItemCancel.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemCancel.Text = "Отменить";
            this.toolStripMenuItemCancel.Click += new System.EventHandler(this.toolStripMenuItemCancel_Click);
            // 
            // toolStripMenuItemEditorSettings
            // 
            this.toolStripMenuItemEditorSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFontColor,
            this.toolStripMenuItemBackgroundColor,
            this.toolStripMenuItemFont});
            this.toolStripMenuItemEditorSettings.Name = "toolStripMenuItemEditorSettings";
            this.toolStripMenuItemEditorSettings.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemEditorSettings.Text = "Настройки редактора";
            // 
            // ToolStripMenuItemFontColor
            // 
            this.ToolStripMenuItemFontColor.Name = "ToolStripMenuItemFontColor";
            this.ToolStripMenuItemFontColor.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemFontColor.Text = "Цвет шрифта";
            this.ToolStripMenuItemFontColor.Click += new System.EventHandler(this.ToolStripMenuItemFontColor_Click);
            // 
            // toolStripMenuItemBackgroundColor
            // 
            this.toolStripMenuItemBackgroundColor.Name = "toolStripMenuItemBackgroundColor";
            this.toolStripMenuItemBackgroundColor.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemBackgroundColor.Text = "Цвет фона";
            this.toolStripMenuItemBackgroundColor.Click += new System.EventHandler(this.toolStripMenuItemBackgroundColor_Click);
            // 
            // toolStripMenuItemFont
            // 
            this.toolStripMenuItemFont.Name = "toolStripMenuItemFont";
            this.toolStripMenuItemFont.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemFont.Text = "Шрифт";
            this.toolStripMenuItemFont.Click += new System.EventHandler(this.toolStripMenuItemFont_Click);
            // 
            // toolStripMenuItemSelectAll
            // 
            this.toolStripMenuItemSelectAll.Name = "toolStripMenuItemSelectAll";
            this.toolStripMenuItemSelectAll.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemSelectAll.Text = "Выделить всё";
            this.toolStripMenuItemSelectAll.Click += new System.EventHandler(this.toolStripMenuItemSelectAll_Click);
            // 
            // toolStripMenuItemSaveAs
            // 
            this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItemSaveAs.Text = "Сохранить как";
            this.toolStripMenuItemSaveAs.Click += new System.EventHandler(this.toolStripMenuItemSaveAs_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelOpen,
            this.toolStripSeparator1,
            this.toolStripLabelSave,
            this.toolStripSeparator2,
            this.toolStripLabelNewDocument,
            this.toolStripSeparator3,
            this.toolStripLabelCopy,
            this.toolStripSeparator4,
            this.toolStripLabelCut,
            this.toolStripSeparator5,
            this.toolStripLabelInsert,
            this.toolStripSeparator6,
            this.toolStripLabelCancel,
            this.toolStripSeparator7,
            this.toolStripDropDownButtonRedactorSettings});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripLabelOpen
            // 
            this.toolStripLabelOpen.Name = "toolStripLabelOpen";
            this.toolStripLabelOpen.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabelOpen.Text = "Открыть";
            this.toolStripLabelOpen.Click += new System.EventHandler(this.toolStripLabelOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelSave
            // 
            this.toolStripLabelSave.Name = "toolStripLabelSave";
            this.toolStripLabelSave.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabelSave.Text = "Сохранить";
            this.toolStripLabelSave.Click += new System.EventHandler(this.toolStripLabelSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelNewDocument
            // 
            this.toolStripLabelNewDocument.Name = "toolStripLabelNewDocument";
            this.toolStripLabelNewDocument.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabelNewDocument.Text = "Новый документ";
            this.toolStripLabelNewDocument.Click += new System.EventHandler(this.toolStripLabelNewDocument_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelCopy
            // 
            this.toolStripLabelCopy.Name = "toolStripLabelCopy";
            this.toolStripLabelCopy.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabelCopy.Text = "Копировать";
            this.toolStripLabelCopy.Click += new System.EventHandler(this.toolStripLabelCopy_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelCut
            // 
            this.toolStripLabelCut.Name = "toolStripLabelCut";
            this.toolStripLabelCut.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabelCut.Text = "Вырезать";
            this.toolStripLabelCut.Click += new System.EventHandler(this.toolStripLabelCut_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelInsert
            // 
            this.toolStripLabelInsert.Name = "toolStripLabelInsert";
            this.toolStripLabelInsert.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabelInsert.Text = "Вставить";
            this.toolStripLabelInsert.Click += new System.EventHandler(this.toolStripLabelInsert_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelCancel
            // 
            this.toolStripLabelCancel.Name = "toolStripLabelCancel";
            this.toolStripLabelCancel.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabelCancel.Text = "Отменить";
            this.toolStripLabelCancel.Click += new System.EventHandler(this.toolStripLabelCancel_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButtonRedactorSettings
            // 
            this.toolStripDropDownButtonRedactorSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonRedactorSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelFontColor,
            this.panelBackgroundColor,
            this.panelFont});
            this.toolStripDropDownButtonRedactorSettings.Image = global::Task_1.Properties.Resources.FauxS_XP__Cobalt__V1_5_Icon_28;
            this.toolStripDropDownButtonRedactorSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonRedactorSettings.Name = "toolStripDropDownButtonRedactorSettings";
            this.toolStripDropDownButtonRedactorSettings.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButtonRedactorSettings.Text = "Настройки редактора";
            this.toolStripDropDownButtonRedactorSettings.ToolTipText = "Настройки редактора";
            // 
            // panelFontColor
            // 
            this.panelFontColor.Name = "panelFontColor";
            this.panelFontColor.Size = new System.Drawing.Size(180, 22);
            this.panelFontColor.Text = "Цвет шрифта";
            this.panelFontColor.Click += new System.EventHandler(this.panelFontColor_Click);
            // 
            // panelBackgroundColor
            // 
            this.panelBackgroundColor.Name = "panelBackgroundColor";
            this.panelBackgroundColor.Size = new System.Drawing.Size(180, 22);
            this.panelBackgroundColor.Text = "Цвет фона";
            this.panelBackgroundColor.Click += new System.EventHandler(this.panelBackgroundColor_Click);
            // 
            // panelFont
            // 
            this.panelFont.Name = "panelFont";
            this.panelFont.Size = new System.Drawing.Size(180, 22);
            this.panelFont.Text = "Шрифт";
            this.panelFont.Click += new System.EventHandler(this.panelFont_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuItemCopy,
            this.ContextMenuItemCut,
            this.ContextMenuItemInsert,
            this.ContextMenuItemCancel});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(140, 92);
            // 
            // ContextMenuItemCopy
            // 
            this.ContextMenuItemCopy.Name = "ContextMenuItemCopy";
            this.ContextMenuItemCopy.Size = new System.Drawing.Size(139, 22);
            this.ContextMenuItemCopy.Text = "Копировать";
            this.ContextMenuItemCopy.Click += new System.EventHandler(this.ContextMenuItemCopy_Click);
            // 
            // ContextMenuItemCut
            // 
            this.ContextMenuItemCut.Name = "ContextMenuItemCut";
            this.ContextMenuItemCut.Size = new System.Drawing.Size(139, 22);
            this.ContextMenuItemCut.Text = "Вырезать";
            this.ContextMenuItemCut.Click += new System.EventHandler(this.ContextMenuItemCut_Click);
            // 
            // ContextMenuItemInsert
            // 
            this.ContextMenuItemInsert.Name = "ContextMenuItemInsert";
            this.ContextMenuItemInsert.Size = new System.Drawing.Size(139, 22);
            this.ContextMenuItemInsert.Text = "Вставить";
            this.ContextMenuItemInsert.Click += new System.EventHandler(this.ContextMenuItemInsert_Click);
            // 
            // ContextMenuItemCancel
            // 
            this.ContextMenuItemCancel.Name = "ContextMenuItemCancel";
            this.ContextMenuItemCancel.Size = new System.Drawing.Size(139, 22);
            this.ContextMenuItemCancel.Text = "Отменить";
            this.ContextMenuItemCancel.Click += new System.EventHandler(this.ContextMenuItemCancel_Click);
            // 
            // textBox
            // 
            this.textBox.ContextMenuStrip = this.contextMenuStrip;
            this.textBox.Location = new System.Drawing.Point(13, 53);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(775, 385);
            this.textBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewDocument;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInsert;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditorSettings;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFontColor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFont;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAs;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabelOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelNewDocument;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabelInsert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemInsert;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCancel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonRedactorSettings;
        private System.Windows.Forms.ToolStripMenuItem panelFontColor;
        private System.Windows.Forms.ToolStripMenuItem panelBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem panelFont;
    }
}

