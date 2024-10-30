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
            selectControl1 = new LabLibrary1.SelectControl();
            buttonClear = new Button();
            inputControl1 = new LabLibrary1.InputControl();
            buttonSetEmail = new Button();
            buttonSetWrong = new Button();
            SuspendLayout();
            // 
            // selectControl1
            // 
            selectControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectControl1.Location = new Point(24, 40);
            selectControl1.Margin = new Padding(3, 2, 3, 2);
            selectControl1.Name = "selectControl1";
            selectControl1.SelectedItem = "";
            selectControl1.Size = new Size(499, 48);
            selectControl1.TabIndex = 0;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Top;
            buttonClear.Location = new Point(198, 93);
            buttonClear.Margin = new Padding(3, 2, 3, 2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(143, 45);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // inputControl1
            // 
            inputControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputControl1.Location = new Point(24, 156);
            inputControl1.Margin = new Padding(3, 2, 3, 2);
            inputControl1.Name = "inputControl1";
            inputControl1.Pattern = "";
            inputControl1.Size = new Size(499, 45);
            inputControl1.TabIndex = 2;
            // 
            // buttonSetEmail
            // 
            buttonSetEmail.Anchor = AnchorStyles.Top;
            buttonSetEmail.Location = new Point(64, 206);
            buttonSetEmail.Margin = new Padding(3, 2, 3, 2);
            buttonSetEmail.Name = "buttonSetEmail";
            buttonSetEmail.Size = new Size(196, 44);
            buttonSetEmail.TabIndex = 3;
            buttonSetEmail.Text = "Установить правильное значение";
            buttonSetEmail.UseVisualStyleBackColor = true;
            buttonSetEmail.Click += buttonSetEmail_Click;
            // 
            // buttonSetWrong
            // 
            buttonSetWrong.Anchor = AnchorStyles.Top;
            buttonSetWrong.Location = new Point(287, 206);
            buttonSetWrong.Margin = new Padding(3, 2, 3, 2);
            buttonSetWrong.Name = "buttonSetWrong";
            buttonSetWrong.Size = new Size(197, 44);
            buttonSetWrong.TabIndex = 4;
            buttonSetWrong.Text = "Установить неправильное значение";
            buttonSetWrong.UseVisualStyleBackColor = true;
            buttonSetWrong.Click += buttonSetWrong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 284);
            Controls.Add(buttonSetWrong);
            Controls.Add(buttonSetEmail);
            Controls.Add(inputControl1);
            Controls.Add(buttonClear);
            Controls.Add(selectControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private LabLibrary1.SelectControl selectControl1;
        private Button buttonClear;
        private LabLibrary1.InputControl inputControl1;
        private Button buttonSetEmail;
        private Button buttonSetWrong;
    }
}
