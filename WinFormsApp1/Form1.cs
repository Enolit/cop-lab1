namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // �������� �� ������� ��������� ���������� �������� � SelectControl
            selectControl1.SelectionChanged += selectControl1_SelectionChanged;

            // ��������� ComboBox ����� �����
            List<string> items = new List<string> { "Item 1", "Item 2", "Item 3" };
            selectControl1.PopulateComboBox(items);

            // ��������� InputControl ��� �������� email
            inputControl1.Pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // ������ ��� �������� email
            inputControl1.SetToolTip("������� ����� ����������� ����� � �������: example@domain.com");

            // �������� �� ������� ��������� �������� � InputControl
            inputControl1.ValueChanged += inputControl1_ValueChanged;
            
        }


        // ���������� ������� ��������� ���������� ��������
        private void selectControl1_SelectionChanged(object sender, EventArgs e)
        {
            // �������� ��� ��������� ���������� ��������
            MessageBox.Show("�� �������: " + selectControl1.SelectedItem);
        }

        // ���������� ������� ��������� �������� � InputControl
        private void inputControl1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string email = inputControl1.InputValue;
                MessageBox.Show("�������� email: " + email);
            }
            catch (Exception ex)
            {
                MessageBox.Show("������: " + ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // ������� ������ ����� ��������� �����
            selectControl1.ClearItems();
        }

        private void buttonSetEmail_Click(object sender, EventArgs e)
        {
            inputControl1.InputValue = "example@email.com";
        }

        private void buttonSetWrong_Click(object sender, EventArgs e)
        {
            inputControl1.InputValue = "someWrongText";
        }
    }
}
