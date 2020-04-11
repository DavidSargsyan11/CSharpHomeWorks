namespace Translator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgrammToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Справка ";
            // 
            // aboutProgrammToolStripMenuItem
            // 
            this.aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            this.aboutProgrammToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.aboutProgrammToolStripMenuItem.Text = "Справка о программе";
            this.aboutProgrammToolStripMenuItem.Click += new System.EventHandler(this.aboutProgrammToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(293, 175);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(362, 77);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(293, 175);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(313, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 34);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 24);
            this.button3.TabIndex = 5;
            this.button3.Text = "Русский";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(97, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 24);
            this.button4.TabIndex = 6;
            this.button4.Text = "Английский";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(362, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 24);
            this.button5.TabIndex = 7;
            this.button5.Text = "Немецкий";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(447, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 24);
            this.button6.TabIndex = 8;
            this.button6.Text = "Французкий";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Азербайджанский",
            "Албанский",
            "Амхарский ",
            "Английский",
            "Арабский",
            "Армянский",
            "Африкаанс",
            "Баскский",
            "Башкирский",
            "Белорусский",
            "Бенгальский",
            "Бирманский ",
            "Болгарский",
            "Боснийский",
            "Валлийский",
            "Венгерский",
            "Вьетнамский",
            "Гаитянский",
            "Галисийский",
            "Горномарийский ",
            "Греческий",
            "Грузинский",
            "Гуджарати",
            "Датский",
            "Иврит",
            "Идиш",
            "Индонезийский",
            "Ирландский",
            "Исландский",
            "Испанский",
            "Итальянский",
            "Казахский",
            "Казахский (латиница) ",
            "Каннада",
            "Каталанский",
            "Киргизский ",
            "Китайский",
            "Корейский",
            "Коса ",
            "Кхмерский",
            "Лаосский ",
            "Латынь",
            "Латышский",
            "Литовский",
            "Люксембургский",
            "Македонский",
            "Малагасийский",
            "Малайский",
            "Малаялам ",
            "Мальтийский",
            "Маори",
            "Маратхи",
            "Марийский ",
            "Монгольский ",
            "Немецкий",
            "Непальский",
            "Нидерландский",
            "Норвежский",
            "Панджаби",
            "Папьяменто ",
            "Персидский",
            "Польский",
            "Португальский",
            "Румынский",
            "Русский",
            "Себуанский",
            "Сербский",
            "Сингальский",
            "Словацкий",
            "Словенский",
            "Суахили",
            "Сунданский",
            "Тагальский",
            "Таджикский ",
            "Тайский",
            "Тамильский ",
            "Татарский",
            "Телугу ",
            "Турецкий",
            "Удмуртский ",
            "Узбекский",
            "Узбекский (кириллица)",
            "Украинский",
            "Урду",
            "Финский",
            "Французский",
            "Хинди",
            "Хорватский",
            "Чешский",
            "Чувашский",
            "Шведский",
            "Шотландский (гэльский)",
            "Эльфийский (синдарин) ",
            "Эмодзи",
            "Эсперанто",
            "Эстонский",
            "Яванский",
            "Японский"});
            this.comboBox1.Location = new System.Drawing.Point(184, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Азербайджанский",
            "Албанский",
            "Амхарский ",
            "Английский",
            "Арабский",
            "Армянский",
            "Африкаанс",
            "Баскский",
            "Башкирский",
            "Белорусский",
            "Бенгальский",
            "Бирманский ",
            "Болгарский",
            "Боснийский",
            "Валлийский",
            "Венгерский",
            "Вьетнамский",
            "Гаитянский",
            "Галисийский",
            "Горномарийский ",
            "Греческий",
            "Грузинский",
            "Гуджарати",
            "Датский",
            "Иврит",
            "Идиш",
            "Индонезийский",
            "Ирландский",
            "Исландский",
            "Испанский",
            "Итальянский",
            "Казахский",
            "Казахский (латиница) ",
            "Каннада",
            "Каталанский",
            "Киргизский ",
            "Китайский",
            "Корейский",
            "Коса ",
            "Кхмерский",
            "Лаосский ",
            "Латынь",
            "Латышский",
            "Литовский",
            "Люксембургский",
            "Македонский",
            "Малагасийский",
            "Малайский",
            "Малаялам ",
            "Мальтийский",
            "Маори",
            "Маратхи",
            "Марийский ",
            "Монгольский ",
            "Немецкий",
            "Непальский",
            "Нидерландский",
            "Норвежский",
            "Панджаби",
            "Папьяменто ",
            "Персидский",
            "Польский",
            "Португальский",
            "Румынский",
            "Русский",
            "Себуанский",
            "Сербский",
            "Сингальский",
            "Словацкий",
            "Словенский",
            "Суахили",
            "Сунданский",
            "Тагальский",
            "Таджикский ",
            "Тайский",
            "Тамильский ",
            "Татарский",
            "Телугу ",
            "Турецкий",
            "Удмуртский ",
            "Узбекский",
            "Узбекский (кириллица)",
            "Украинский",
            "Урду",
            "Финский",
            "Французский",
            "Хинди",
            "Хорватский",
            "Чешский",
            "Чувашский",
            "Шведский",
            "Шотландский (гэльский)",
            "Эльфийский (синдарин) ",
            "Эмодзи",
            "Эсперанто",
            "Эстонский",
            "Яванский",
            "Японский"});
            this.comboBox2.Location = new System.Drawing.Point(532, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(573, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "Перевести";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Переведено сервисом <<Яндекс.Переводчик>> ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(521, 307);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://translate.yandex.ru/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 329);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Translator v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgrammToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

