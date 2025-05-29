namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Классический");
            comboBox1.Items.Add("Современный");
            comboBox1.Items.Add("Минимальный");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResumeGenerator res = new ResumeGenerator();
            string message = $"Имя: {textBox1.Text}\n" +
                             $"Фамилия: {textBox2.Text}\n" +
                             $"Образование: {textBox3.Text}\n" +
                             $"Опыт работы: {textBox4.Text}";
            MessageBox.Show(message);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Обработка изменений в textBox1 (пока не требуется)
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Обработка изменений в textBox2 (пока не требуется)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Обработка клика по label2 (пока не требуется)
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Обработка клика по label3 (пока не требуется)
        }

        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ResumeGenerator res = new ResumeGenerator();
            using (SaveFileDialog s = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Сохранить резюме"
            })
            {
                if (s.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = s.FileName;
                    string style = comboBox1.SelectedItem?.ToString() ?? "классический";
                    res.GenerateResume($"{selectedFile}.docx", textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, textBox3.Text, style);

                    MessageBox.Show($"Резюме успешно сохранено: {selectedFile}");
                }
                else
                {
                    MessageBox.Show("Вы нажали кнопку отмены");
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Обработка клика по элементу меню
        }
    }
}
