namespace notebook
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПервогоВхожденияДвухСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.обработкаТекстаToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.проверкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem1,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Создать";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.статистикаToolStripMenuItem_Click);
            // 
            // обработкаТекстаToolStripMenuItem
            // 
            this.обработкаТекстаToolStripMenuItem.Name = "обработкаТекстаToolStripMenuItem";
            this.обработкаТекстаToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.обработкаТекстаToolStripMenuItem.Text = "Обработка текста";
            this.обработкаТекстаToolStripMenuItem.Click += new System.EventHandler(this.обработкаТекстаToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПервогоВхожденияДвухСловToolStripMenuItem,
            this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem,
            this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поискПервогоВхожденияДвухСловToolStripMenuItem
            // 
            this.поискПервогоВхожденияДвухСловToolStripMenuItem.Name = "поискПервогоВхожденияДвухСловToolStripMenuItem";
            this.поискПервогоВхожденияДвухСловToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.поискПервогоВхожденияДвухСловToolStripMenuItem.Text = "Поиск первого вхождения двух слов";
            this.поискПервогоВхожденияДвухСловToolStripMenuItem.Click += new System.EventHandler(this.поискПервогоВхожденияДвухСловToolStripMenuItem_Click);
            // 
            // поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem
            // 
            this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem.Name = "поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem";
            this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem.Text = "Поиск первого вхождения фамилии с инициалами";
            this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem.Click += new System.EventHandler(this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem_Click);
            // 
            // поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem
            // 
            this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem.Name = "поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem";
            this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem.Text = "Поиск всех корректных электронных адресов";
            this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem.Click += new System.EventHandler(this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem_Click);
            // 
            // проверкаToolStripMenuItem
            // 
            this.проверкаToolStripMenuItem.Name = "проверкаToolStripMenuItem";
            this.проверкаToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.проверкаToolStripMenuItem.Text = "Проверка";
            this.проверкаToolStripMenuItem.Click += new System.EventHandler(this.проверкаToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(692, 338);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 364);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Блокнот";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem обработкаТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПервогоВхожденияДвухСловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem;
    }
}

