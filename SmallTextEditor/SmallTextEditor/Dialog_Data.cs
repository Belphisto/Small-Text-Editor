using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmallTextEditor
{
    public partial class Dialog_Data : Form
    {
        private DateTime thisDay;
        private DateTime allDay;

        public Dialog_Data()
        {
            InitializeComponent();

            thisDay = DateTime.Today;
            TodayTextBox.Text = thisDay.ToLongDateString();
        }

        private void Dialog_Data_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            allDay = monthCalendar1.SelectionStart;
            ChooseTextBox.Text = allDay.ToLongDateString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            allDay = monthCalendar1.SelectionStart;
            ChooseTextBox.Text = allDay.ToLongDateString();
        }

        private void DateFormatListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DateFormatListBox.SelectedIndex == 0)
            {
                ChooseTextBox.Text = allDay.ToShortDateString();
            }
            else if (DateFormatListBox.SelectedIndex == 1)
            {
                ChooseTextBox.Text = allDay.ToLongDateString();
            }
        }

        public string SelectedDate
        {
            get { return ChooseTextBox.Text; } // Получить текст "выбранная дата"
        }
    }
}
