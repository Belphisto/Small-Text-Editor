namespace SmallTextEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            exitStripMenuItem = new ToolStripMenuItem();
            диалогиToolStripMenuItem = new ToolStripMenuItem();
            DialogTextToolStripMenuItem = new ToolStripMenuItem();
            DialogDateToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            cutToolStripButton = new ToolStripButton();
            copyToolStripButton = new ToolStripButton();
            pasteToolStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            colorFontToolStripButton1 = new ToolStripButton();
            colorBackgroundToolStripButton2 = new ToolStripButton();
            fontToolStripButton1 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            InputWordToolStripTextBox = new ToolStripTextBox();
            toolStripSeparator6 = new ToolStripSeparator();
            FindToolStripButton = new ToolStripButton();
            RichTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cutContextToolStripMenuItem = new ToolStripMenuItem();
            copyContextToolStripMenuItem1 = new ToolStripMenuItem();
            pasteContextToolStripMenuItem = new ToolStripMenuItem();
            selectallContextToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            statusStrip1 = new StatusStrip();
            fileNameToolStripStatusLabel1 = new ToolStripStatusLabel();
            dateToolStripStatusLabel2 = new ToolStripStatusLabel();
            cursorToolStripStatusLabel3 = new ToolStripStatusLabel();
            CountToolStripStatusLabel = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, exitStripMenuItem, диалогиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(762, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(173, 22);
            newToolStripMenuItem.Text = "Создать";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(173, 22);
            openToolStripMenuItem.Text = "Открыть";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(170, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(173, 22);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(173, 22);
            saveAsToolStripMenuItem.Text = "Сохранить как";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(170, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(59, 20);
            editToolStripMenuItem.Text = "Правка";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(181, 22);
            cutToolStripMenuItem.Text = "Вырезать";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(181, 22);
            copyToolStripMenuItem.Text = "Копировать";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(181, 22);
            pasteToolStripMenuItem.Text = "Вставить";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(178, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(181, 22);
            selectAllToolStripMenuItem.Text = "Выделить все";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // exitStripMenuItem
            // 
            exitStripMenuItem.Name = "exitStripMenuItem";
            exitStripMenuItem.Size = new Size(54, 20);
            exitStripMenuItem.Text = "Выход";
            exitStripMenuItem.Click += exitStripMenuItem_Click;
            // 
            // диалогиToolStripMenuItem
            // 
            диалогиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DialogTextToolStripMenuItem, DialogDateToolStripMenuItem });
            диалогиToolStripMenuItem.Name = "диалогиToolStripMenuItem";
            диалогиToolStripMenuItem.Size = new Size(66, 20);
            диалогиToolStripMenuItem.Text = "Диалоги";
            // 
            // DialogTextToolStripMenuItem
            // 
            DialogTextToolStripMenuItem.Name = "DialogTextToolStripMenuItem";
            DialogTextToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            DialogTextToolStripMenuItem.Size = new Size(187, 22);
            DialogTextToolStripMenuItem.Text = "Диалог_текст";
            DialogTextToolStripMenuItem.Click += DialogTextToolStripMenuItem_Click;
            // 
            // DialogDateToolStripMenuItem
            // 
            DialogDateToolStripMenuItem.Name = "DialogDateToolStripMenuItem";
            DialogDateToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            DialogDateToolStripMenuItem.Size = new Size(187, 22);
            DialogDateToolStripMenuItem.Text = "Диалог_дата";
            DialogDateToolStripMenuItem.Click += DialogDateToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, toolStripSeparator2, cutToolStripButton, copyToolStripButton, pasteToolStripButton, toolStripSeparator3, colorFontToolStripButton1, colorBackgroundToolStripButton2, fontToolStripButton1, toolStripSeparator5, InputWordToolStripTextBox, toolStripSeparator6, FindToolStripButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(762, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(24, 24);
            newToolStripButton.Text = "Создать";
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(24, 24);
            openToolStripButton.Text = "Открыть";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(24, 24);
            saveToolStripButton.Text = "Сохранить";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = (Image)resources.GetObject("cutToolStripButton.Image");
            cutToolStripButton.ImageTransparentColor = Color.Magenta;
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Size = new Size(24, 24);
            cutToolStripButton.Text = "Вы&резать";
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = (Image)resources.GetObject("copyToolStripButton.Image");
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(24, 24);
            copyToolStripButton.Text = "&Копировать";
            // 
            // pasteToolStripButton
            // 
            pasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton.Image = (Image)resources.GetObject("pasteToolStripButton.Image");
            pasteToolStripButton.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton.Name = "pasteToolStripButton";
            pasteToolStripButton.Size = new Size(24, 24);
            pasteToolStripButton.Text = "&Вставить";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // colorFontToolStripButton1
            // 
            colorFontToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            colorFontToolStripButton1.Image = (Image)resources.GetObject("colorFontToolStripButton1.Image");
            colorFontToolStripButton1.ImageTransparentColor = Color.Magenta;
            colorFontToolStripButton1.Name = "colorFontToolStripButton1";
            colorFontToolStripButton1.Size = new Size(122, 24);
            colorFontToolStripButton1.Text = "Выбрать цвет текста";
            colorFontToolStripButton1.Click += colorFontToolStripButton1_Click;
            // 
            // colorBackgroundToolStripButton2
            // 
            colorBackgroundToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            colorBackgroundToolStripButton2.Image = (Image)resources.GetObject("colorBackgroundToolStripButton2.Image");
            colorBackgroundToolStripButton2.ImageTransparentColor = Color.Magenta;
            colorBackgroundToolStripButton2.Name = "colorBackgroundToolStripButton2";
            colorBackgroundToolStripButton2.Size = new Size(144, 24);
            colorBackgroundToolStripButton2.Text = "Выбрать цвет подложки";
            colorBackgroundToolStripButton2.Click += colorBackgroundToolStripButton2_Click;
            // 
            // fontToolStripButton1
            // 
            fontToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fontToolStripButton1.Image = (Image)resources.GetObject("fontToolStripButton1.Image");
            fontToolStripButton1.ImageTransparentColor = Color.Magenta;
            fontToolStripButton1.Name = "fontToolStripButton1";
            fontToolStripButton1.Size = new Size(100, 24);
            fontToolStripButton1.Text = "Выбрать шрифт";
            fontToolStripButton1.Click += fontToolStripButton1_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // InputWordToolStripTextBox
            // 
            InputWordToolStripTextBox.Name = "InputWordToolStripTextBox";
            InputWordToolStripTextBox.Size = new Size(100, 27);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 27);
            // 
            // FindToolStripButton
            // 
            FindToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            FindToolStripButton.Image = (Image)resources.GetObject("FindToolStripButton.Image");
            FindToolStripButton.ImageTransparentColor = Color.Magenta;
            FindToolStripButton.Name = "FindToolStripButton";
            FindToolStripButton.Size = new Size(45, 24);
            FindToolStripButton.Text = "Найти";
            FindToolStripButton.Click += FindToolStripButton_Click;
            // 
            // RichTextBox1
            // 
            RichTextBox1.AutoWordSelection = true;
            RichTextBox1.ContextMenuStrip = contextMenuStrip1;
            RichTextBox1.Cursor = Cursors.IBeam;
            RichTextBox1.Dock = DockStyle.Fill;
            RichTextBox1.Location = new Point(0, 51);
            RichTextBox1.Margin = new Padding(3, 2, 3, 2);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(762, 287);
            RichTextBox1.TabIndex = 4;
            RichTextBox1.Text = "";
            RichTextBox1.SelectionChanged += RichTextBox1_SelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cutContextToolStripMenuItem, copyContextToolStripMenuItem1, pasteContextToolStripMenuItem, selectallContextToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(149, 92);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // cutContextToolStripMenuItem
            // 
            cutContextToolStripMenuItem.Name = "cutContextToolStripMenuItem";
            cutContextToolStripMenuItem.Size = new Size(148, 22);
            cutContextToolStripMenuItem.Text = "Вырезать";
            // 
            // copyContextToolStripMenuItem1
            // 
            copyContextToolStripMenuItem1.Name = "copyContextToolStripMenuItem1";
            copyContextToolStripMenuItem1.Size = new Size(148, 22);
            copyContextToolStripMenuItem1.Text = "Копировать";
            // 
            // pasteContextToolStripMenuItem
            // 
            pasteContextToolStripMenuItem.Name = "pasteContextToolStripMenuItem";
            pasteContextToolStripMenuItem.Size = new Size(148, 22);
            pasteContextToolStripMenuItem.Text = "Вставить";
            // 
            // selectallContextToolStripMenuItem
            // 
            selectallContextToolStripMenuItem.Name = "selectallContextToolStripMenuItem";
            selectallContextToolStripMenuItem.Size = new Size(148, 22);
            selectallContextToolStripMenuItem.Text = "Выделить все";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Rtf файлы (*.rtf)|*.rtf|Все файлы (*.*)|*.*";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { fileNameToolStripStatusLabel1, dateToolStripStatusLabel2, cursorToolStripStatusLabel3, CountToolStripStatusLabel });
            statusStrip1.Location = new Point(0, 316);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(762, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // fileNameToolStripStatusLabel1
            // 
            fileNameToolStripStatusLabel1.AutoSize = false;
            fileNameToolStripStatusLabel1.Name = "fileNameToolStripStatusLabel1";
            fileNameToolStripStatusLabel1.Size = new Size(255, 17);
            fileNameToolStripStatusLabel1.Text = "Имя файла";
            // 
            // dateToolStripStatusLabel2
            // 
            dateToolStripStatusLabel2.AutoSize = false;
            dateToolStripStatusLabel2.Name = "dateToolStripStatusLabel2";
            dateToolStripStatusLabel2.Size = new Size(70, 17);
            dateToolStripStatusLabel2.Text = "Дата";
            // 
            // cursorToolStripStatusLabel3
            // 
            cursorToolStripStatusLabel3.AutoSize = false;
            cursorToolStripStatusLabel3.Name = "cursorToolStripStatusLabel3";
            cursorToolStripStatusLabel3.Size = new Size(255, 17);
            cursorToolStripStatusLabel3.Text = "строка, позиция";
            // 
            // CountToolStripStatusLabel
            // 
            CountToolStripStatusLabel.AutoSize = false;
            CountToolStripStatusLabel.Name = "CountToolStripStatusLabel";
            CountToolStripStatusLabel.Size = new Size(146, 17);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 338);
            Controls.Add(statusStrip1);
            Controls.Add(RichTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem exitStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private RichTextBox RichTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cutContextToolStripMenuItem;
        private ToolStripMenuItem copyContextToolStripMenuItem1;
        private ToolStripMenuItem pasteContextToolStripMenuItem;
        private ToolStripMenuItem selectallContextToolStripMenuItem;
        private ToolStripButton colorFontToolStripButton1;
        private ToolStripButton colorBackgroundToolStripButton2;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private ToolStripButton fontToolStripButton1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel fileNameToolStripStatusLabel1;
        private ToolStripStatusLabel dateToolStripStatusLabel2;
        private ToolStripStatusLabel cursorToolStripStatusLabel3;
        private ToolStripMenuItem диалогиToolStripMenuItem;
        private ToolStripMenuItem DialogTextToolStripMenuItem;
        private ToolStripMenuItem DialogDateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripTextBox InputWordToolStripTextBox;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton FindToolStripButton;
        private ToolStripStatusLabel CountToolStripStatusLabel;
    }
}