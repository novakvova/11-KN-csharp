namespace MyOpenWin
{
    partial class ProfileForm
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
            label1 = new Label();
            label2 = new Label();
            txtFilePath = new TextBox();
            btnSelectImage = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(21, 78);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 0;
            label1.Text = "Шлях до фото";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(217, 20);
            label2.Name = "label2";
            label2.Size = new Size(374, 48);
            label2.TabIndex = 1;
            label2.Text = "Профіль користувача";
            // 
            // txtFilePath
            // 
            txtFilePath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtFilePath.Location = new Point(21, 125);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(657, 39);
            txtFilePath.TabIndex = 2;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectImage.Location = new Point(702, 112);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(75, 52);
            btnSelectImage.TabIndex = 3;
            btnSelectImage.Text = "...";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelectImage);
            Controls.Add(txtFilePath);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProfileForm";
            Text = "Налаштування профілю";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFilePath;
        private Button btnSelectImage;
    }
}
