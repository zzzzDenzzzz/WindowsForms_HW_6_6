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
            Libs.SetLocalDrive(treeView);
        }

        /// <summary>
        /// Обработчик собития выбора элемента в TreeView
        /// </summary>
        private void TreeViewSelect(object sender, TreeViewEventArgs e)
        {
            string newPath = e.Node.FullPath.Replace("\\\\", "\\");
            toolStripStatusLabel_path.Text = $"Путь: {newPath}";

            if (e.Node.GetNodeCount(true) == 0)
            {
                Libs.GetSubDir(e.Node, e.Node.FullPath);
            }

            Libs.GetDirectories(e.Node.FullPath, listView);

            toolStripStatusLabel_quantityElement.Text = $"Колличество эллементов: {listView.Items.Count}";
        }

        /// <summary>
        /// открытие папки и диска
        /// </summary>
        private void OpenFile(object sender, EventArgs e)
        {
            string path = "";

            try
            {
                path = treeView.SelectedNode.FullPath + '\\' + listView.FocusedItem.Text;
            }
            catch (Exception)
            {
                return;
            }

            //Проверка существования файла
            if (File.Exists(path))
            {
                //Комманда для открытия файла приложением по умолчанию
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                Libs.SearchNode(treeView, path);
                Libs.GetDirectories(path, listView);
            }
        }

        /// <summary>
        /// выход из программы
        /// </summary>
        private void Exit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
