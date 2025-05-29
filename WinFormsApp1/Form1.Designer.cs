namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            menuStrip1 = new MenuStrip();
            save_menu_strip = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(176, 61);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 46);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SimSun-ExtB", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(310, 61);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(454, 50);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("SimSun-ExtB", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(310, 131);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(454, 50);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(118, 131);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 46);
            label2.TabIndex = 4;
            label2.Text = "Фамилия";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("SimSun-ExtB", 19.875F);
            textBox3.Location = new Point(310, 206);
            textBox3.Margin = new Padding(2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(454, 50);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("SimSun-ExtB", 19.875F);
            textBox4.Location = new Point(310, 279);
            textBox4.Margin = new Padding(2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(454, 113);
            textBox4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.875F);
            label3.Location = new Point(71, 206);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(231, 46);
            label3.TabIndex = 7;
            label3.Text = "Образование";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.875F);
            label4.Location = new Point(73, 279);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(228, 46);
            label4.TabIndex = 8;
            label4.Text = "Опыт работы";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.875F);
            label5.Location = new Point(118, 421);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 46);
            label5.TabIndex = 10;
            label5.Text = "Навыки";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("SimSun-ExtB", 19.875F);
            textBox5.Location = new Point(310, 405);
            textBox5.Margin = new Padding(2);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(454, 129);
            textBox5.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkCyan;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { save_menu_strip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1089, 26);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // save_menu_strip
            // 
            save_menu_strip.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem });
            save_menu_strip.Name = "save_menu_strip";
            save_menu_strip.Size = new Size(59, 24);
            save_menu_strip.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(166, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(830, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 28);
            comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1089, 554);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Генератор резюме";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem save_menu_strip;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ComboBox comboBox1;
    }
}
