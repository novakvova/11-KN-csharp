namespace MyCalculator
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
            btnOk = new Button();
            txtMyInput = new TextBox();
            txtFileContent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(641, 40);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(147, 64);
            btnOk.TabIndex = 0;
            btnOk.Text = "Нажми мене";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtMyInput
            // 
            txtMyInput.Location = new Point(32, 57);
            txtMyInput.Name = "txtMyInput";
            txtMyInput.Size = new Size(401, 31);
            txtMyInput.TabIndex = 1;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(32, 141);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(744, 277);
            txtFileContent.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 20);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 3;
            label1.Text = "Шлях до файлу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 103);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 4;
            label2.Text = "Вміст файлу";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFileContent);
            Controls.Add(txtMyInput);
            Controls.Add(btnOk);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private TextBox txtMyInput;
        private TextBox txtFileContent;
        private Label label1;
        private Label label2;
    }
}
