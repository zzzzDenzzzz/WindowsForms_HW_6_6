using System;
using System.Windows.Forms;

/*Создайте Windows Forms приложение
 ■ Добавьте на него текстовое поле с именем TopLevelMenu;
 ■ Добавьте текстовое поле с именем SubItem;
 ■ Добавьте кнопку «Добавить пункт меню»;
 ■ Добавьте кнопку «Добавить подменю»;
 ■ При  нажатии  на  кнопку  «Добавить  пункт  меню»  должен 
добавляться  пункт  меню  верхнего  уровня,  с  именем  ука-
занным в поле TopLevelMenu;
 ■ При  нажатии  на  кнопку  «Добавить  подменю»  в  текущее 
меню  должен  добавляться  подпункт  меню  с  именем  ука-
занным в поле SubItem.*/

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
            if (textBox_subItem.Text != "")
            {
                item.DropDownItems.Add(new ToolStripMenuItem(textBox_subItem.Text));
                menu.Items.Add(item);
            }
        }
    }
}
