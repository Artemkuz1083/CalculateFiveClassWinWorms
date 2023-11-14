namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            translateNumFirst = new TextBox();
            translateNumSecond = new TextBox();
            SuspendLayout();
            // 
            // translateNumFirst
            // 
            translateNumFirst.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            translateNumFirst.Location = new Point(0, 0);
            translateNumFirst.Multiline = true;
            translateNumFirst.Name = "translateNumFirst";
            translateNumFirst.ScrollBars = ScrollBars.Vertical;
            translateNumFirst.Size = new Size(1772, 452);
            translateNumFirst.TabIndex = 0;
            translateNumFirst.TextChanged += translateNumFirst_TextChanged;
            // 
            // translateNumSecond
            // 
            translateNumSecond.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            translateNumSecond.Location = new Point(0, 505);
            translateNumSecond.Multiline = true;
            translateNumSecond.Name = "translateNumSecond";
            translateNumSecond.ScrollBars = ScrollBars.Vertical;
            translateNumSecond.Size = new Size(1772, 425);
            translateNumSecond.TabIndex = 1;
            translateNumSecond.TextChanged += translateNumSecond_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1771, 949);
            Controls.Add(translateNumSecond);
            Controls.Add(translateNumFirst);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox translateNumFirst;
        public TextBox translateNumSecond;
    }
}