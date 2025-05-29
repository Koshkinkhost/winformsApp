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
            //MessageBox.Show($"{textBox1.Text}|{textBox2.Text}");

            MessageBox.Show($"Имя: {textBox1.Text}\nФамилия: {textBox2.Text}\nОбразование: {textBox3.Text}\nОпыт работы: {textBox4.Text}");

            //MessageBox.Show($"Фамилия: {textBox2.Text}");

            //MessageBox.Show($"Образование: {textBox3.Text}");

            //MessageBox.Show($"Опыт работы: {textBox4.Text}");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ResumeGenerator res = new ResumeGenerator();
            SaveFileDialog s = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*docx",
                Title = "Сохранить резюме"
            };
            if (s.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = s.FileName;
                res.GenerateResume(selectedFile+".docx", textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, textBox3.Text,comboBox1.SelectedItem.ToString()??"классический");

                MessageBox.Show(selectedFile);
            }
            else
            {
                MessageBox.Show("Вы нажали кнопку отмены");

            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
