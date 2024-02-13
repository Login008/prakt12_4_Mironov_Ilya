using System.ComponentModel.DataAnnotations;

namespace prakt11_3._0
{
    public partial class Form1 : Form
    {
        Room room = new Room();
        public Form1()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    room.SetLength(Convert.ToDouble(textBox1.Text));
                    room.SetWidth(Convert.ToDouble(textBox2.Text));
                    room.SetHeight(Convert.ToDouble(textBox3.Text));
                    room.SetNwindow(Convert.ToInt32(textBox4.Text));
                    room.SetHeightWindow(Convert.ToDouble(textBox5.Text));
                    room.SetWidthWindow(Convert.ToDouble(textBox6.Text));
                    double remont;
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            remont = room.Remont(10);
                            if (remont == -1)
                                MessageBox.Show("������ ������� �������");
                            else
                                MessageBox.Show($"����������� �������: {remont}");
                            break;
                        case 1:
                            remont = room.Remont(15);
                            if (remont == -1)
                                MessageBox.Show("������ ������� �������");
                            else
                                MessageBox.Show($"����������� �������: {remont}");
                            break;
                        default:
                            MessageBox.Show("��������� ���� � ������ ������");
                            break;
                    }
                }
                else
                    MessageBox.Show("��������� ������ ����");
            }
            catch
            {
                MessageBox.Show("�������� ������ ������");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    room.SetLength(Convert.ToDouble(textBox1.Text));
                    room.SetWidth(Convert.ToDouble(textBox2.Text));
                    double Sroom = room.SetSroom();
                    if (Sroom > 0)
                        MessageBox.Show($"������� ������� = {Sroom}");
                    else
                        MessageBox.Show("������� ������� �� ����� ���� ������ ��� ����� ����");
                }
                else
                    MessageBox.Show("������� ����� � ������ �������");
            }
            catch
            {
                MessageBox.Show("�������� ������ ������");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    room.SetLength(Convert.ToDouble(textBox1.Text));
                    room.SetWidth(Convert.ToDouble(textBox2.Text));
                    room.SetHeight(Convert.ToDouble(textBox3.Text));
                    double Vroom = room.SetVroom();
                    if (Vroom > 0)
                        MessageBox.Show($"����� ������� = {Vroom}");
                    else
                        MessageBox.Show("����� ������� �� ����� ���� ������ ��� ����� ����");
                }
                else
                    MessageBox.Show("������� �����, ������ ������� � ������ ��������");
            }
            catch
            {
                MessageBox.Show("�������� ������ ������");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    room.SetLength(Convert.ToDouble(textBox1.Text));
                    room.SetWidth(Convert.ToDouble(textBox2.Text));
                    room.SetHeight(Convert.ToDouble(textBox3.Text));
                    room.SetNwindow(Convert.ToInt32(textBox4.Text));
                    room.SetHeightWindow(Convert.ToDouble(textBox5.Text));
                    room.SetWidthWindow(Convert.ToDouble(textBox6.Text));
                    string message = room.Information();
                    if (message != "")
                        MessageBox.Show(message);
                    else
                        MessageBox.Show("������ ������� �������");
                }
                else
                    MessageBox.Show("��������� ��� ����");
            }
            catch
            {
                MessageBox.Show("�������� ������ ������");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    room.SetNwindow(Convert.ToInt32(textBox4.Text));
                    room.SetHeightWindow(Convert.ToDouble(textBox5.Text));
                    room.SetWidthWindow(Convert.ToDouble(textBox6.Text));
                    double S = room.SetOSWindow();
                    if (S == -1)
                        MessageBox.Show("������ ������� �������");
                    else
                        MessageBox.Show($"����� ������� ���� = {S}");
                }
                else
                    MessageBox.Show("��������� ��� ��������� ����");
            }
            catch
            {
                MessageBox.Show("�������� ������ ������");
            }
        }
    }
}