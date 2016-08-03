using System;
using System.Windows.Forms;

namespace Complex_Strings_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string ToRusBack(string input)
        {
            input = input.Replace('À', 'Б');
            input = input.Replace('Á', 'В');
            input = input.Replace('Â', 'Г');
            input = input.Replace('Ä', 'Д');
            input = input.Replace('Æ', 'Ж');
            input = input.Replace('Ç', 'З');
            input = input.Replace('È', 'И');
            input = input.Replace('É', 'Й');
            input = input.Replace('Ê', 'К');
            input = input.Replace('Ì', 'Л');
            input = input.Replace('Í', 'М');
            input = input.Replace('Î', 'Н');
            input = input.Replace('Ï', 'П');
            input = input.Replace('Ò', 'Т');
            input = input.Replace('Ó', 'У');
            input = input.Replace('Ñ', 'Ф');
            input = input.Replace('²', 'Ф');
            input = input.Replace('Œ', 'Ц');
            input = input.Replace('Ù', 'Ч');
            input = input.Replace('Ú', 'Ш');
            input = input.Replace('Û', 'Щ');
            input = input.Replace('µ', 'Ъ');
            input = input.Replace('Å', 'Ъ');
            input = input.Replace('Ÿ', 'Ы');
            input = input.Replace('Ö', 'Ь');
            input = input.Replace('Ë', 'Э');
            input = input.Replace('Ô', 'Ю');
            input = input.Replace('Ü', 'Я');
            input = input.Replace('à', 'б');
            input = input.Replace('á', 'в');
            input = input.Replace('â', 'г');
            input = input.Replace('ä', 'д');
            input = input.Replace('æ', 'ж');
            input = input.Replace('ç', 'з');
            input = input.Replace('è', 'и');
            input = input.Replace('é', 'й');
            input = input.Replace('ê', 'к');
            input = input.Replace('ì', 'л');
            input = input.Replace('í', 'м');
            input = input.Replace('î', 'н');
            input = input.Replace('ï', 'п');
            input = input.Replace('ò', 'т');
            input = input.Replace('ó', 'у');
            input = input.Replace('ñ', 'ф');
            input = input.Replace('³', 'ф');
            input = input.Replace('œ', 'ц');
            input = input.Replace('ù', 'ч');
            input = input.Replace('ú', 'ш');
            input = input.Replace('û', 'щ');
            input = input.Replace('°', 'ъ');
            input = input.Replace('å', 'ъ');
            input = input.Replace('ÿ', 'ы');
            input = input.Replace('ö', 'ь');
            input = input.Replace('ë', 'э');
            input = input.Replace('ô', 'ю');
            input = input.Replace('ü', 'я');
            return input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ToRusBack(richTextBox1.Text);
        }
    }
}
