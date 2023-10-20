using System.Windows.Forms;

namespace SmallTextEditor
{
    public partial class MainForm : Form
    {
        string File_name = "Noname.rtf";
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Предварительно проверить, что есть в окне и предложить сохранить.
            if (RichTextBox1.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Хотите сохранить изменения перед созданием нового документа?", "Сохранение", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    // Сохранить документ
                    MessageBox.Show("Сдесь будет сохранение файла!");
                    //SaveDocument();
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}