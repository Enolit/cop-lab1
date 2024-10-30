namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Подписка на событие изменения выбранного элемента в SelectControl
            selectControl1.SelectionChanged += selectControl1_SelectionChanged;

            // Заполняем ComboBox через метод
            List<string> items = new List<string> { "Item 1", "Item 2", "Item 3" };
            selectControl1.PopulateComboBox(items);

            // Настройка InputControl для проверки email
            inputControl1.Pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Шаблон для проверки email
            inputControl1.SetToolTip("Введите адрес электронной почты в формате: example@domain.com");

            // Подписка на событие изменения значения в InputControl
            inputControl1.ValueChanged += inputControl1_ValueChanged;
            
        }


        // Обработчик события изменения выбранного значения
        private void selectControl1_SelectionChanged(object sender, EventArgs e)
        {
            // Действие при изменении выбранного значения
            MessageBox.Show("Вы выбрали: " + selectControl1.SelectedItem);
        }

        // Обработчик события изменения значения в InputControl
        private void inputControl1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string email = inputControl1.InputValue;
                MessageBox.Show("Введённый email: " + email);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Очищаем список через публичный метод
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
