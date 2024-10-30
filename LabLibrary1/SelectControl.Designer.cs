namespace LabLibrary1
{
    partial class SelectControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            arrayBox = new ComboBox();
            SuspendLayout();
            // 
            // arrayBox
            // 
            arrayBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            arrayBox.FormattingEnabled = true;
            arrayBox.Location = new Point(3, 11);
            arrayBox.Margin = new Padding(3, 2, 3, 2);
            arrayBox.Name = "arrayBox";
            arrayBox.Size = new Size(219, 23);
            arrayBox.TabIndex = 0;
            arrayBox.SelectedIndexChanged += arrayBox_SelectedIndexChanged;
            // 
            // SelectControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(arrayBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SelectControl";
            Size = new Size(237, 73);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox arrayBox;
    }
}
