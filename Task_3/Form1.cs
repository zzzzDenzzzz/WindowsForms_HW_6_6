using System;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        MenuStrip menu;
        ToolStripMenuItem item;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// добавляет меню
        /// </summary>
        private void button_addMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox_topLevelUp.Text != "")
            {
                menu = new MenuStrip();
                item = new ToolStripMenuItem(textBox_topLevelUp.Text);
                menu.Items.Add(item);
                menu.Dock = DockStyle.Left;
                Controls.Add(menu);
            }
        }

        /// <summary>
        /// добавляет в текущее меню подменю
        /// </summary>
        private void button_addSubMenu_Click(object sender, EventArgs e)
        {
            item.DropDownItems.Add(new ToolStripMenuItem(textBox_subItem.Text));
            menu.Items.Add(item);
        }
    }
}
