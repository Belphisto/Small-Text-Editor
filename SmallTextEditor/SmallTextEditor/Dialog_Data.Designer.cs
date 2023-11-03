namespace SmallTextEditor
{
    partial class Dialog_Data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            DateFormatListBox = new ListBox();
            OkButton = new Button();
            CancelButton = new Button();
            TodayTextBox = new TextBox();
            ChooseTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 252);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Сегодня";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 291);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Выбрано";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(34, 67);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // DateFormatListBox
            // 
            DateFormatListBox.FormattingEnabled = true;
            DateFormatListBox.ItemHeight = 15;
            DateFormatListBox.Items.AddRange(new object[] { "Корткий формат даты", "Длинный формат даты" });
            DateFormatListBox.Location = new Point(34, 21);
            DateFormatListBox.Name = "DateFormatListBox";
            DateFormatListBox.Size = new Size(178, 34);
            DateFormatListBox.TabIndex = 5;
            DateFormatListBox.SelectedIndexChanged += DateFormatListBox_SelectedIndexChanged;
            // 
            // OkButton
            // 
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(34, 335);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(61, 30);
            OkButton.TabIndex = 6;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(151, 335);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(61, 30);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // TodayTextBox
            // 
            TodayTextBox.Location = new Point(92, 249);
            TodayTextBox.Name = "TodayTextBox";
            TodayTextBox.Size = new Size(120, 23);
            TodayTextBox.TabIndex = 8;
            // 
            // ChooseTextBox
            // 
            ChooseTextBox.Location = new Point(92, 288);
            ChooseTextBox.Name = "ChooseTextBox";
            ChooseTextBox.Size = new Size(120, 23);
            ChooseTextBox.TabIndex = 9;
            // 
            // Dialog_Data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 378);
            Controls.Add(ChooseTextBox);
            Controls.Add(TodayTextBox);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(DateFormatListBox);
            Controls.Add(monthCalendar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dialog_Data";
            Text = "Dialog_Data";
            Load += Dialog_Data_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private ListBox DateFormatListBox;
        private Button OkButton;
        private Button CancelButton;
        private TextBox TodayTextBox;
        private TextBox ChooseTextBox;
    }
}