namespace Task_3
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
            this.label_topLevelUp = new System.Windows.Forms.Label();
            this.label_subItem = new System.Windows.Forms.Label();
            this.textBox_topLevelUp = new System.Windows.Forms.TextBox();
            this.textBox_subItem = new System.Windows.Forms.TextBox();
            this.button_addMenuItem = new System.Windows.Forms.Button();
            this.button_addSubMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_topLevelUp
            // 
            this.label_topLevelUp.AutoSize = true;
            this.label_topLevelUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_topLevelUp.Location = new System.Drawing.Point(43, 25);
            this.label_topLevelUp.Name = "label_topLevelUp";
            this.label_topLevelUp.Size = new System.Drawing.Size(122, 23);
            this.label_topLevelUp.TabIndex = 0;
            this.label_topLevelUp.Text = "TopLevelUp";
            // 
            // label_subItem
            // 
            this.label_subItem.AutoSize = true;
            this.label_subItem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_subItem.Location = new System.Drawing.Point(300, 25);
            this.label_subItem.Name = "label_subItem";
            this.label_subItem.Size = new System.Drawing.Size(92, 23);
            this.label_subItem.TabIndex = 1;
            this.label_subItem.Text = "SubItem";
            // 
            // textBox_topLevelUp
            // 
            this.textBox_topLevelUp.Location = new System.Drawing.Point(12, 68);
            this.textBox_topLevelUp.Name = "textBox_topLevelUp";
            this.textBox_topLevelUp.Size = new System.Drawing.Size(189, 21);
            this.textBox_topLevelUp.TabIndex = 2;
            // 
            // textBox_subItem
            // 
            this.textBox_subItem.Location = new System.Drawing.Point(259, 68);
            this.textBox_subItem.Name = "textBox_subItem";
            this.textBox_subItem.Size = new System.Drawing.Size(189, 21);
            this.textBox_subItem.TabIndex = 3;
            // 
            // button_addMenuItem
            // 
            this.button_addMenuItem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addMenuItem.Location = new System.Drawing.Point(13, 112);
            this.button_addMenuItem.Name = "button_addMenuItem";
            this.button_addMenuItem.Size = new System.Drawing.Size(188, 69);
            this.button_addMenuItem.TabIndex = 4;
            this.button_addMenuItem.Text = "Добавить пункт меню";
            this.button_addMenuItem.UseVisualStyleBackColor = true;
            this.button_addMenuItem.Click += new System.EventHandler(this.button_addMenuItem_Click);
            // 
            // button_addSubMenu
            // 
            this.button_addSubMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addSubMenu.Location = new System.Drawing.Point(260, 112);
            this.button_addSubMenu.Name = "button_addSubMenu";
            this.button_addSubMenu.Size = new System.Drawing.Size(188, 69);
            this.button_addSubMenu.TabIndex = 5;
            this.button_addSubMenu.Text = "Добавить подменю";
            this.button_addSubMenu.UseVisualStyleBackColor = true;
            this.button_addSubMenu.Click += new System.EventHandler(this.button_addSubMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(460, 249);
            this.Controls.Add(this.button_addSubMenu);
            this.Controls.Add(this.button_addMenuItem);
            this.Controls.Add(this.textBox_subItem);
            this.Controls.Add(this.textBox_topLevelUp);
            this.Controls.Add(this.label_subItem);
            this.Controls.Add(this.label_topLevelUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_topLevelUp;
        private System.Windows.Forms.Label label_subItem;
        private System.Windows.Forms.TextBox textBox_topLevelUp;
        private System.Windows.Forms.TextBox textBox_subItem;
        private System.Windows.Forms.Button button_addMenuItem;
        private System.Windows.Forms.Button button_addSubMenu;
    }
}

