using System.Diagnostics;

namespace LabLibrary1
{
    public partial class SelectControl : UserControl
    {
        private event EventHandler _selectionChanged;
        public SelectControl()
        {
            InitializeComponent();
        }

        // Метод для заполнения ComboBox списком строк
        public void PopulateComboBox(List<string> items)
        {
            arrayBox.Items.Clear(); // Очистка перед добавлением
            arrayBox.ResetText();
            arrayBox.Items.AddRange(items.ToArray()); // Добавление элементов
        }

        // Метод для очистки ComboBox
        public void ClearItems()
        {
            arrayBox.Items.Clear();
            arrayBox.ResetText();
        }

        // Публичное свойство для получения и установки выбранного значения
        public string SelectedItem
        {
            get
            {
                return arrayBox.SelectedItem?.ToString() ?? string.Empty;
            }
            set
            {
                arrayBox.SelectedItem = value;
            }
        }

        // Событие при смене выбранного значения
        public event EventHandler SelectionChanged
        {
            add { _selectionChanged += value; }
            remove { _selectionChanged -= value; }
        }

        private void arrayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectionChanged?.Invoke(this, e); // Вызываем событие при изменении
        }

    }
}
