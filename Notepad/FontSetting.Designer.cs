namespace Notepad
{
    partial class FontSetting
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
            this.ExampleLbl = new System.Windows.Forms.Label();
            this.ExampleTextLbl = new System.Windows.Forms.Label();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.StyleComboBox = new System.Windows.Forms.ComboBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.SizeLbl = new System.Windows.Forms.Label();
            this.StyleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExampleLbl
            // 
            this.ExampleLbl.AutoSize = true;
            this.ExampleLbl.Location = new System.Drawing.Point(152, 122);
            this.ExampleLbl.Name = "ExampleLbl";
            this.ExampleLbl.Size = new System.Drawing.Size(65, 16);
            this.ExampleLbl.TabIndex = 0;
            this.ExampleLbl.Text = "Образец";
            // 
            // ExampleTextLbl
            // 
            this.ExampleTextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExampleTextLbl.Location = new System.Drawing.Point(149, 138);
            this.ExampleTextLbl.Name = "ExampleTextLbl";
            this.ExampleTextLbl.Size = new System.Drawing.Size(217, 74);
            this.ExampleTextLbl.TabIndex = 1;
            this.ExampleTextLbl.Text = "AaBbYyZz";
            this.ExampleTextLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "36",
            "48",
            "72"});
            this.SizeComboBox.Location = new System.Drawing.Point(12, 33);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(121, 24);
            this.SizeComboBox.TabIndex = 4;
            this.SizeComboBox.SelectedValueChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // StyleComboBox
            // 
            this.StyleComboBox.FormattingEnabled = true;
            this.StyleComboBox.Items.AddRange(new object[] {
            "обычный",
            "курсив",
            "жирный"});
            this.StyleComboBox.Location = new System.Drawing.Point(155, 33);
            this.StyleComboBox.Name = "StyleComboBox";
            this.StyleComboBox.Size = new System.Drawing.Size(121, 24);
            this.StyleComboBox.TabIndex = 5;
            this.StyleComboBox.SelectedValueChanged += new System.EventHandler(this.OnStyleChanged);
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(291, 34);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(75, 23);
            this.OKbtn.TabIndex = 6;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // SizeLbl
            // 
            this.SizeLbl.AutoSize = true;
            this.SizeLbl.Location = new System.Drawing.Point(12, 13);
            this.SizeLbl.Name = "SizeLbl";
            this.SizeLbl.Size = new System.Drawing.Size(57, 16);
            this.SizeLbl.TabIndex = 8;
            this.SizeLbl.Text = "Размер";
            // 
            // StyleLbl
            // 
            this.StyleLbl.AutoSize = true;
            this.StyleLbl.Location = new System.Drawing.Point(152, 13);
            this.StyleLbl.Name = "StyleLbl";
            this.StyleLbl.Size = new System.Drawing.Size(88, 16);
            this.StyleLbl.TabIndex = 10;
            this.StyleLbl.Text = "Начертание";
            // 
            // FontSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 257);
            this.Controls.Add(this.StyleLbl);
            this.Controls.Add(this.SizeLbl);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.StyleComboBox);
            this.Controls.Add(this.SizeComboBox);
            this.Controls.Add(this.ExampleTextLbl);
            this.Controls.Add(this.ExampleLbl);
            this.Name = "FontSetting";
            this.Text = "Шрифт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExampleLbl;
        private System.Windows.Forms.Label ExampleTextLbl;
        private System.Windows.Forms.ComboBox SizeComboBox;
        private System.Windows.Forms.ComboBox StyleComboBox;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Label SizeLbl;
        private System.Windows.Forms.Label StyleLbl;
    }
}