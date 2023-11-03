using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallTextEditor
{
    public partial class Dialog_Text : Form
    {
        public Dialog_Text()
        {
            InitializeComponent();
        }

        public Dialog_Text(string selectedText)
        {
            InitializeComponent();
            LastWordtextBox.Text = selectedText;
        }

        public string NewText
        {
            get { return NewWordTextBox.Text; } // Получить текст из поля "новое слово"
        }

        private void Dialog_Text_Load(object sender, EventArgs e)
        {

        }
    }
}
