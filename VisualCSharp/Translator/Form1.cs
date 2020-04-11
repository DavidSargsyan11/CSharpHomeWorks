using ByteTranslate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Translator
{
    public partial class Form1 : Form
    {
        ComboBox cb;

        BTranslator bt;
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedItem = "Русский";
            comboBox2.SelectedItem = "Английский";

            cb = new ComboBox();
            bt = new BTranslator();
            #region  Резервная коллекция ComboBox
            cb.Items.AddRange(new object[] {
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
            #endregion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Русский";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Английский";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "Немецкий";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "Французский";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb.SelectedItem = comboBox2.SelectedItem;

            comboBox2.SelectedItem = comboBox1.SelectedItem;

            comboBox1.SelectedItem = cb.SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Clear();

                richTextBox2.Text = bt.Translator(richTextBox1.Text, bt.getLangPair(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString()));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Translator v1.0 \n Tempest \n Переведено сервисом Яндекс.Переводчик http://translate.yandex.ru/", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
