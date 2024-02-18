using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Notepad
{
    public partial class MainForm : Form
    {
        public string fileName; //отвечает за название файла
        public bool isFileChanged;

        public int fontSize = 0;
        public FontStyle fs = FontStyle.Regular;

        public FontSetting fontSet;
        public MainForm()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            fileName = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }

        /// <summary>
        /// м-д для создания нового файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CreateNewDoc(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            textBox.Text = "";
            fileName = "";
            isFileChanged= false; 
            UpdateTextWithTitle();
        }
        /// <summary>
        /// м-д для открытия существующего файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenFile(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            SaveUnsavedFile();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    textBox.Text = sr.ReadToEnd();
                    sr.Close(); //чтобы не мешал
                    fileName = openFileDialog1.FileName;
                    isFileChanged = false;
                }
                catch
                {
                    MessageBox.Show("Не удалось открыть файл");
                }
            }
            UpdateTextWithTitle();
        }
        /// <summary>
        /// м-д для сохранения файла
        /// </summary>
        /// <param name="_fileName"></param>
        public void SaveFile(string _fileName)
        {
            if (_fileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                   _fileName = saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_fileName + ".txt");
                sw.Write(textBox.Text);
                sw.Close();
                fileName = _fileName;
                isFileChanged = false;
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить файл");
            }
            UpdateTextWithTitle();
        }
        /// <summary>
        /// м-д, который лежит в Click кнопки сохранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Save(object sender, EventArgs e)
        {
            SaveFile(fileName);
        }
        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                isFileChanged = true;
            }
        }
        public void UpdateTextWithTitle()
        {
            if (fileName != "")
                this.Text = fileName + " - Блокнот";
            else
                this.Text = "Блокнот";
        }
        public void SaveUnsavedFile()
        {
            if(isFileChanged)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в файле?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(fileName);
                }
            }
        }
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsavedFile();
        }
        /// <summary>
        /// м-д, чтобы закрыть блоконот
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// методы для печати
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pDoc = new PrintDocument();
            pDoc.PrintPage += PrintPagE;
            PrintDialog pDia = new PrintDialog();
            pDia.Document = pDoc;
            if (pDia.ShowDialog() == DialogResult.OK)
            {
                pDia.Document.Print();
            }
        }
        public void PrintPagE(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox.Text, textBox.Font, Brushes.Black, 0, 0);
        }
        /// <summary>
        /// м-д для справки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Блокнот <Windows Forms>\n©Корпорация Некорпорация, 2024. Все права защищены.", "О программе");
        }

        //---------------------------------------------------------------------------------
        //методы для правки
        public void CopyText()
        {
            if(textBox.Text.Length > 0)
            {
                textBox.Copy();
            }
        }
        public void CutText()
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Cut();
            }
        }
        public void PastText()
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Paste();
            }
        }

        private void OnCutClick(object sender, EventArgs e)
        {
            CutText();
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            CopyText();
        }

        private void OnPasteClick(object sender, EventArgs e)
        {
            PastText();
        }
        //------------------------------------------------------------------------------
        //для работы со шрифтом
        private void OnFontClick(object sender, EventArgs e)
        {
            fontSet = new FontSetting();
            fontSet.Show();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            if (fontSet != null)
            {
                fontSize = fontSet.fontSize;
                fs = fontSet.fs;
                textBox.Font = new Font(textBox.Font.FontFamily, fontSize, fs);
                fontSet.Close();
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            textBox.ForeColor = colorDialog1.Color;
        }

        
    }
}
