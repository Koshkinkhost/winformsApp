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
            comboBox1.Items.Add("������������");
            comboBox1.Items.Add("�����������");
            comboBox1.Items.Add("�����������");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResumeGenerator res = new ResumeGenerator();
            string message = $"���: {textBox1.Text}\n" +
                             $"�������: {textBox2.Text}\n" +
                             $"�����������: {textBox3.Text}\n" +
                             $"���� ������: {textBox4.Text}";
            MessageBox.Show(message);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // ��������� ��������� � textBox1 (���� �� ���������)
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // ��������� ��������� � textBox2 (���� �� ���������)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // ��������� ����� �� label2 (���� �� ���������)
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // ��������� ����� �� label3 (���� �� ���������)
        }

        private void ���������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ResumeGenerator res = new ResumeGenerator();
            using (SaveFileDialog s = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "��������� ������"
            })
            {
                if (s.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = s.FileName;
                    string style = comboBox1.SelectedItem?.ToString() ?? "������������";
                    res.GenerateResume($"{selectedFile}.docx", textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, textBox3.Text, style);

                    MessageBox.Show($"������ ������� ���������: {selectedFile}");
                }
                else
                {
                    MessageBox.Show("�� ������ ������ ������");
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // ��������� ����� �� �������� ����
        }
    }
}
