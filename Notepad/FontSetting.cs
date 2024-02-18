using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FontSetting : Form //табличка для насторек шрифта
    {
        public int fontSize = 0;
        public FontStyle fs = FontStyle.Regular;

        public FontSetting()
        {
            InitializeComponent();
            SizeComboBox.SelectedItem = SizeComboBox.Items[0];
            StyleComboBox.SelectedItem = StyleComboBox.Items[0];
        }


        private void OnFontChanged(object sender, EventArgs e)
        {
            ExampleTextLbl.Font = new Font(ExampleTextLbl.Font.FontFamily, int.Parse(SizeComboBox.SelectedItem.ToString()), ExampleTextLbl.Font.Style);
            fontSize = int.Parse(SizeComboBox.SelectedItem.ToString()); 
        }

        private void OnStyleChanged(object sender, EventArgs e)
        {
            switch(StyleComboBox.SelectedItem.ToString())
            {
                case "обычный":
                    ExampleTextLbl.Font = new Font(ExampleTextLbl.Font.FontFamily, int.Parse(SizeComboBox.SelectedItem.ToString()), FontStyle.Regular); break;
                case "курсив":
                    ExampleTextLbl.Font = new Font(ExampleTextLbl.Font.FontFamily, int.Parse(SizeComboBox.SelectedItem.ToString()), FontStyle.Italic); break;
                case "жирный":
                    ExampleTextLbl.Font = new Font(ExampleTextLbl.Font.FontFamily, int.Parse(SizeComboBox.SelectedItem.ToString()), FontStyle.Bold); break;
            }
            fs = ExampleTextLbl.Font.Style;
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
