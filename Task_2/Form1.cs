using System;
using System.IO;
using System.Windows.Forms;

/*Написать программу «Проводник»
 ■ При первом запуске программа отображает список доступ-
ных дисков;
 ■ Программа должна содержать дерево дисков, строку адре-
са, меню, панель инструментов и окно для отображения со-
держимого папки;
 ■ Дерево дисков отображает только диски и папки (можно 
реализовать с помощью ListBox);
■ При двойном щелчке по папке – окно содержимого отобра-
жаются файлы и подпапки;
 ■ Программа должна иметь развернутое меню, контекстное 
меню и возможность работы с горячими клавишами.*/

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Libs.SetLocalDrive(ef_treeView);

            ef_treeView.AfterSelect += Ef_treeView_AfterSelect;

            ef_listView.MouseDoubleClick += открытьToolStripMenuItem_Click;

            ef_menu_open.Click += открытьToolStripMenuItem_Click;
            ef_menu_close.Click += выйтиИзПрограммыToolStripMenuItem_Click;

            ef_menu_about.Click += Ef_menu_about_Click;
        }

        private void Ef_menu_about_Click(object sender, EventArgs e)
        {
            string str = "Проводник v 1.0\r\r Разработчик: Поротиков Игорь Олегович\r";
            MessageBox.Show(str, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик собития выбора элемента в Tree View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ef_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string newPath = e.Node.FullPath.Replace("\\\\", "\\");
            ef_sbl_path.Text = $"Путь: {newPath}";

            if (e.Node.GetNodeCount(true) == 0)
            {
                Libs.GetSubDir(e.Node, e.Node.FullPath);
            }

            Libs.GetDirectories(e.Node.FullPath, ef_listView);

            ef_sbl_quantity.Text = $"Колличество эллементов: {ef_listView.Items.Count.ToString()}";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = ef_treeView.SelectedNode.FullPath + '\\' + ef_listView.FocusedItem.Text;

            //Проверка существования файла
            if (File.Exists(path))
            {
                //Комманда для открытия файла приложением по умолчанию
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                Libs.SearchNode(ef_treeView, path);
                Libs.GetDirectories(path, ef_listView);
            }
        }

        /// <summary>
        /// Обработка нажатия кнопы выйти из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выйтиИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
