using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

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

            statusStrip1.Items[0].Text = "Имя файла: " + Path.GetFileName(File_name);
            statusStrip1.Items[1].Text = DateTime.Now.ToShortDateString();
            statusStrip1.Items[2].Text = "Позиция: Строка " + 0 + ", Символ " + 0;
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
            statusStrip1.Items[0].Text = "Имя файла: " + Path.GetFileName(File_name);
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
            statusStrip1.Items[0].Text = "Имя файла: " + Path.GetFileName(File_name);
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
            statusStrip1.Items[0].Text = "Имя файла: " + Path.GetFileName(File_name);
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
            statusStrip1.Items[0].Text = "Имя файла: " + Path.GetFileName(File_name);
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
                case 4: {/*Вырезать*/ cutToolStripMenuItem_Click(sender, e); break; }
                case 5: {/*Копировать*/ copyToolStripMenuItem_Click(sender, e); break; }
                case 6: {/*Вставить*/ pasteToolStripMenuItem_Click(sender, e); break; }
            };
        }


        //Обработчики событий группы команд "Правка" по работе с текстом
        //Вырезать
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.SelectionLength > 0 && Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                Clipboard.SetData(DataFormats.Rtf, RichTextBox1.SelectedRtf);
                RichTextBox1.SelectedRtf = "";
            }
        }

        //Копировать
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Получить формат представления текста в буфере как Rtf формат.
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Rtf);
            // Проверить, есть ли выделение.
            if (RichTextBox1.SelectionLength > 0)
            {
                Clipboard.SetData(myFormat.Name, RichTextBox1.SelectedRtf);
            }
        }

        //Вставить
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                RichTextBox1.Paste(DataFormats.GetFormat(DataFormats.Rtf));
            }
        }

        //Выделить все
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectAll();
        }


        // Обработчики событий кнопок контекстного меню
        // дублируют пункты меню.
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (contextMenuStrip1.Items.IndexOf(e.ClickedItem))
            {
                case 0: {/*Вырезать*/ cutToolStripMenuItem_Click(sender, e); break; }
                case 1: {/*Копировать*/ copyToolStripMenuItem_Click(sender, e); break; }
                case 2: {/*Вставить*/ pasteToolStripMenuItem_Click(sender, e); break; }
                case 3: {/*Выделить все*/ selectAllToolStripMenuItem_Click(sender, e); break; }
            };
        }

        // изменить цвет шрифта выбранного текста
        private void colorFontToolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Применить выбранный цвет к выделенному тексту
                RichTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        //изменить цвет подложки выбранного текста
        private void colorBackgroundToolStripButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Применить выбранный цвет к выделенному тексту
                RichTextBox1.SelectionBackColor = colorDialog1.Color;
            }
        }

        //изменить шрифт выбранного текста
        private void fontToolStripButton1_Click(object sender, EventArgs e)
        {
            // установить текущий шрифт текста в диалоге
            fontDialog1.Font = RichTextBox1.SelectionFont;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void RichTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int lineNumber = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1;
            int columnNumber = RichTextBox1.SelectionStart - RichTextBox1.GetFirstCharIndexFromLine(lineNumber - 1) + 1;

            statusStrip1.Items[2].Text = "Позиция: Строка " + lineNumber + ", Символ " + columnNumber;
        }
    }

}