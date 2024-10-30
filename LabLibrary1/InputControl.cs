using System.Text.RegularExpressions;

namespace LabLibrary1
{
    public partial class InputControl : UserControl
    {
        private string _pattern;
        private ToolTip _toolTip;
        private event EventHandler _valueChanged;

        public InputControl()
        {
            InitializeComponent();
            _toolTip = new ToolTip();
        }

        // Публичное свойство для установки шаблона
        public string Pattern
        {
            get { return _pattern; }
            set { _pattern = value; }
        }

        // Публичное свойство для получения/установки введённого значения
        public string InputValue
        {
            get
            {
                if (string.IsNullOrEmpty(_pattern))
                {
                    throw new InvalidOperationException("Шаблон не задан.");
                }

                if (!Regex.IsMatch(textBoxInput.Text, _pattern))
                {
                    throw new FormatException("Введённое значение не соответствует шаблону.");
                }

                return textBoxInput.Text;
            }
            set
            {
                if (string.IsNullOrEmpty(_pattern) || Regex.IsMatch(value, _pattern))
                {
                    textBoxInput.Text = value;
                }
                else
                {
                    textBoxInput.Clear();
                }
            }
        }

        // Метод для установки подсказки с примером правильного ввода
        public void SetToolTip(string example)
        {
            _toolTip.SetToolTip(textBoxInput, example);
        }

        // Событие при смене значения
        public event EventHandler ValueChanged
        {
            add { _valueChanged += value; }
            remove { _valueChanged -= value; }
        }

        private void textBoxInput_Leave(object sender, EventArgs e)
        {
            _valueChanged?.Invoke(this, e); // Вызываем событие при изменении
        }
    }
}
