using System.Windows.Forms;

namespace SmallTextEditor
{
    public partial class MainForm : Form
    {
        string File_name = "Noname.rtf";
        public MainForm()
        {
            InitializeComponent();
            //openFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory(); - директория по умолчанию
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //директория в "Мои документы"
        }

        //создать новый файл
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Предварительно проверить, что есть в окне и предложить сохранить.
            if (RichTextBox1.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Хотите сохранить изменения перед созданием нового документа?", "Сохранение", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    // Сохранить документ
                    saveToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    // Пользователь отменил операцию "Создать"
                    return;
                }
            }

            // Очистить окно редактирования и установить имя файла в "Noname.rtf"
            RichTextBox1.Text = "";
            File_name = "Noname.rtf";
        }

        //открыть файл (директория "Мои документы" по умолчанию
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Имя файла в поле ввода имени.
            openFileDialog1.FileName = File_name;
            // Показать диалог и ждать ОК.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File_name = openFileDialog1.FileName;
                RichTextBox1.LoadFile(File_name, RichTextBoxStreamType.RichText);
            }
            else // Не ОК или еще что-то.
                ;
        }

        //сохранить
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отследить первоначальное сохранение.
            if (File_name == "Noname.rtf")
                // Вызвать пункт меню "Сохранить как".
                // Можно предварительно сообщить – MessageBox.
                saveAsToolStripMenuItem_Click(sender, e);
            else
                // Сохранить текст в файле.
                RichTextBox1.SaveFile(File_name, RichTextBoxStreamType.RichText);
        }

        // Сохранить с именем.
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Имя файла в поле ввода имени.
            saveFileDialog1.FileName = File_name;
            // Показать диалог и ждать ОК.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File_name = saveFileDialog1.FileName + ".rtf";
                RichTextBox1.SaveFile(File_name, RichTextBoxStreamType.RichText);
            }
            else // Не ОК или еще что-то.
                ;

        }

        private void exitStripMenuItem_Click(object sender, EventArgs e)
        {
            // Уточнить у пользователя операцию выхода
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        // Обработчики событий кнопок инструментальной панели
        // дублируют пункты меню.
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (toolStrip1.Items.IndexOf(e.ClickedItem))
            {
                case 0: {/*Создать*/ newToolStripMenuItem_Click(sender, e); break; }
                case 1: {/*Открыть*/ openToolStripMenuItem_Click(sender, e); break; }
                case 2: {/*Сохранить*/ saveToolStripMenuItem_Click(sender, e); break; }
            };
        }

        //Обработчики событий группы команд "Правка" по работе с текстом
        //Вырезать
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.Cut();
        }

        //Копировать
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.Copy();
        }

        //Вставить
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.Paste();
        }

        //Выделить все
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectAll();
        }
    }

}