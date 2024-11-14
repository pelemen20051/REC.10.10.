namespace PR1
{
    partial class RegistrationForm
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.teacherRadioButton = new System.Windows.Forms.RadioButton();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(121, 36);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(335, 31);
            this.usernameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ввидите ФИО";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(121, 83);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(210, 30);
            this.passwordTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль";
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Location = new System.Drawing.Point(121, 119);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(65, 17);
            this.studentRadioButton.TabIndex = 4;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Студент";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // teacherRadioButton
            // 
            this.teacherRadioButton.AutoSize = true;
            this.teacherRadioButton.Location = new System.Drawing.Point(121, 142);
            this.teacherRadioButton.Name = "teacherRadioButton";
            this.teacherRadioButton.Size = new System.Drawing.Size(104, 17);
            this.teacherRadioButton.TabIndex = 5;
            this.teacherRadioButton.TabStop = true;
            this.teacherRadioButton.Text = "Преподаватель";
            this.teacherRadioButton.UseVisualStyleBackColor = true;
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(121, 184);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(121, 21);
            this.subjectComboBox.TabIndex = 6;
            
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(481, 84);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(139, 29);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выберите предмет";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(481, 136);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(139, 28);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Перейти ко входу";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 284);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.teacherRadioButton);
            this.Controls.Add(this.studentRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton teacherRadioButton;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton;
    }
}