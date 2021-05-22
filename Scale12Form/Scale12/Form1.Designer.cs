
namespace Scale12
{
    partial class Scale12
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Math = new System.Windows.Forms.Label();
            this.Eng = new System.Windows.Forms.Label();
            this.Japan = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(72, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "C",
            "C#(D♭)",
            "D",
            "D#(E♭)",
            "E",
            "F",
            "F#(G♭)",
            "G",
            "G#(A♭)",
            "A",
            "A#(B♭)",
            "B"});
            this.comboBox2.Location = new System.Drawing.Point(258, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 28);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ハ",
            "嬰ハ(変ニ)",
            "ニ",
            "嬰ニ(変ホ)",
            "ホ",
            "ヘ",
            "嬰ヘ(変ト)",
            "ト",
            "嬰ト(変イ)",
            "イ",
            "嬰イ(変ロ)",
            "ロ"});
            this.comboBox3.Location = new System.Drawing.Point(449, 6);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(110, 28);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Math
            // 
            this.Math.AutoSize = true;
            this.Math.BackColor = System.Drawing.Color.Cyan;
            this.Math.Location = new System.Drawing.Point(12, 9);
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(54, 20);
            this.Math.TabIndex = 3;
            this.Math.Text = "数表記";
            // 
            // Eng
            // 
            this.Eng.AutoSize = true;
            this.Eng.BackColor = System.Drawing.Color.Cyan;
            this.Eng.Location = new System.Drawing.Point(198, 9);
            this.Eng.Name = "Eng";
            this.Eng.Size = new System.Drawing.Size(54, 20);
            this.Eng.TabIndex = 4;
            this.Eng.Tag = "";
            this.Eng.Text = "英表記";
            // 
            // Japan
            // 
            this.Japan.AutoSize = true;
            this.Japan.BackColor = System.Drawing.Color.Cyan;
            this.Japan.Location = new System.Drawing.Point(374, 9);
            this.Japan.Name = "Japan";
            this.Japan.Size = new System.Drawing.Size(69, 20);
            this.Japan.TabIndex = 5;
            this.Japan.Text = "日本表記";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.LightCyan;
            this.lbl1.Location = new System.Drawing.Point(72, 37);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(69, 40);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "英表記\r\n日本表記\r\n";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.LightCyan;
            this.lbl2.Location = new System.Drawing.Point(258, 37);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(69, 40);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "数表記\r\n日本表記";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.LightCyan;
            this.lbl3.Location = new System.Drawing.Point(449, 37);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(54, 40);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "数表記\r\n英表記";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "C",
            "C#(D♭)",
            "D",
            "D#(E♭)",
            "E",
            "F",
            "F#(G♭)",
            "G",
            "G#(A♭)",
            "A",
            "A#(B♭)",
            "B",
            "ハ",
            "嬰ハ(変ニ)",
            "ニ",
            "嬰ニ(変ホ)",
            "ホ",
            "ヘ",
            "嬰ヘ(変ト)",
            "ト",
            "嬰ト(変イ)",
            "イ",
            "嬰イ(変ロ)",
            "ロ"});
            this.comboBox4.Location = new System.Drawing.Point(61, 126);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(151, 28);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.Text = "1";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "C",
            "C#(D♭)",
            "D",
            "D#(E♭)",
            "E",
            "F",
            "F#(G♭)",
            "G",
            "G#(A♭)",
            "A",
            "A#(B♭)",
            "B",
            "ハ",
            "嬰ハ(変ニ)",
            "ニ",
            "嬰ニ(変ホ)",
            "ホ",
            "ヘ",
            "嬰ヘ(変ト)",
            "ト",
            "嬰ト(変イ)",
            "イ",
            "嬰イ(変ロ)",
            "ロ"});
            this.comboBox5.Location = new System.Drawing.Point(244, 126);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(151, 28);
            this.comboBox5.TabIndex = 10;
            this.comboBox5.Text = "1";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Cyan;
            this.lbl4.Location = new System.Drawing.Point(16, 129);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(39, 20);
            this.lbl4.TabIndex = 11;
            this.lbl4.Text = "音程";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(218, 129);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(20, 20);
            this.lbl5.TabIndex = 13;
            this.lbl5.Text = "と";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.LightCyan;
            this.lbl6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl6.Location = new System.Drawing.Point(61, 157);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(54, 60);
            this.lbl6.TabIndex = 14;
            this.lbl6.Text = "半音数\r\n度数\r\n協和性";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(434, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(125, 120);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Scale12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(599, 244);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Japan);
            this.Controls.Add(this.Eng);
            this.Controls.Add(this.Math);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Scale12";
            this.Text = "Scale12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label Math;
        private System.Windows.Forms.Label Eng;
        private System.Windows.Forms.Label Japan;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

