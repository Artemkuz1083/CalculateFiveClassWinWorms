namespace WinFormsApp1
{
    partial class StartForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            firstNumField = new TextBox();
            secondNumField = new TextBox();
            button1 = new Button();
            label3 = new Label();
            systemNumField = new TextBox();
            label4 = new Label();
            operationField = new TextBox();
            errorProviderFirstNum = new ErrorProvider(components);
            errorProviderSecondNum = new ErrorProvider(components);
            errorProviderOperation = new ErrorProvider(components);
            errorProviderSystemNum = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSecondNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderOperation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSystemNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(135, 72);
            label1.Name = "label1";
            label1.Size = new Size(309, 60);
            label1.TabIndex = 0;
            label1.Text = "Первое число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(135, 211);
            label2.Name = "label2";
            label2.Size = new Size(301, 60);
            label2.TabIndex = 1;
            label2.Text = "Второе число";
            // 
            // firstNumField
            // 
            firstNumField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            firstNumField.ForeColor = SystemColors.WindowText;
            firstNumField.Location = new Point(186, 144);
            firstNumField.Name = "firstNumField";
            firstNumField.Size = new Size(200, 55);
            firstNumField.TabIndex = 3;
            firstNumField.TextAlign = HorizontalAlignment.Center;
            firstNumField.TextChanged += firstNumField_TextChanged;
            // 
            // secondNumField
            // 
            secondNumField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            secondNumField.ForeColor = SystemColors.WindowText;
            secondNumField.Location = new Point(186, 293);
            secondNumField.Name = "secondNumField";
            secondNumField.Size = new Size(200, 55);
            secondNumField.TabIndex = 4;
            secondNumField.TextAlign = HorizontalAlignment.Center;
            secondNumField.TextChanged += secondNumField_TextChanged;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(89, 684);
            button1.Name = "button1";
            button1.Size = new Size(381, 98);
            button1.TabIndex = 5;
            button1.Text = "Let's Go!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(77, 497);
            label3.Name = "label3";
            label3.Size = new Size(414, 60);
            label3.TabIndex = 6;
            label3.Text = "Система счисления";
            // 
            // systemNumField
            // 
            systemNumField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            systemNumField.Location = new Point(186, 574);
            systemNumField.Name = "systemNumField";
            systemNumField.Size = new Size(200, 55);
            systemNumField.TabIndex = 7;
            systemNumField.TextAlign = HorizontalAlignment.Center;
            systemNumField.TextChanged += systemNumField_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(170, 351);
            label4.Name = "label4";
            label4.Size = new Size(228, 60);
            label4.TabIndex = 8;
            label4.Text = "Операция";
            // 
            // operationField
            // 
            operationField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            operationField.Location = new Point(186, 439);
            operationField.Name = "operationField";
            operationField.Size = new Size(200, 55);
            operationField.TabIndex = 9;
            operationField.TextAlign = HorizontalAlignment.Center;
            operationField.TextChanged += operationField_TextChanged;
            // 
            // errorProviderFirstNum
            // 
            errorProviderFirstNum.ContainerControl = this;
            // 
            // errorProviderSecondNum
            // 
            errorProviderSecondNum.ContainerControl = this;
            // 
            // errorProviderOperation
            // 
            errorProviderOperation.ContainerControl = this;
            // 
            // errorProviderSystemNum
            // 
            errorProviderSystemNum.ContainerControl = this;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Control;
            ClientSize = new Size(557, 831);
            Controls.Add(operationField);
            Controls.Add(label4);
            Controls.Add(systemNumField);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(secondNumField);
            Controls.Add(firstNumField);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator five class";
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSecondNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderOperation).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSystemNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox firstNumField;
        private TextBox secondNumField;
        private Button button1;
        private Label label3;
        private TextBox systemNumField;
        private Label label4;
        private TextBox operationField;
        private ErrorProvider errorProviderFirstNum;
        private ErrorProvider errorProviderSecondNum;
        private ErrorProvider errorProviderOperation;
        private ErrorProvider errorProviderSystemNum;
    }
}