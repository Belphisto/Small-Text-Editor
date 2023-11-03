namespace SmallTextEditor
{
    partial class Dialog_Text
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
            OkButton = new Button();
            CancelButton = new Button();
            LastWordtextBox = new TextBox();
            NewWordTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Слово";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 78);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Новое";
            // 
            // OkButton
            // 
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(63, 123);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(82, 36);
            OkButton.TabIndex = 2;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(188, 123);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(82, 36);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // LastWordtextBox
            // 
            LastWordtextBox.Location = new Point(88, 21);
            LastWordtextBox.Name = "LastWordtextBox";
            LastWordtextBox.Size = new Size(194, 23);
            LastWordtextBox.TabIndex = 4;
            // 
            // NewWordTextBox
            // 
            NewWordTextBox.Location = new Point(88, 75);
            NewWordTextBox.Name = "NewWordTextBox";
            NewWordTextBox.Size = new Size(194, 23);
            NewWordTextBox.TabIndex = 5;
            // 
            // Dialog_Text
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 190);
            Controls.Add(NewWordTextBox);
            Controls.Add(LastWordtextBox);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialog_Text";
            ShowIcon = false;
            Text = "Dialog_Text";
            Load += Dialog_Text_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button OkButton;
        private Button CancelButton;
        private TextBox LastWordtextBox;
        private TextBox NewWordTextBox;
    }
}