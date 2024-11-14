using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR1;


namespace PR1
{
    public partial class RegistrationForm : Form
    {
        private List<User> users = new List<User>(); // Список для хранения зарегистрированных пользователей

        public RegistrationForm()
        {
            InitializeComponent();
            subjectComboBox.Items.AddRange(new string[] { "Математика", "Физика", "Информатика" });
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string ФИО = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string role = studentRadioButton.Checked ? "Ученик" : "Учитель";
            string Предмет = subjectComboBox.Text;

            if (string.IsNullOrEmpty(ФИО) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(Предмет))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            users.Add(new User(ФИО, password, role, Предмет));
            MessageBox.Show("Регистрация прошла успешно!");
            ClearFields();
        }

        private void ClearFields()
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            studentRadioButton.Checked = true;
            subjectComboBox.SelectedIndex = -1;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1(users); // Передаем список users в конструктор Form1
            loginForm.Show();
        }

        public class User
        {
            public string ФИО { get; }
            public string Password { get; }
            public string Role { get; }
            public string Предмет { get; }

            public User(string name, string password, string role, string subject)
            {
                ФИО = name;
                Password = password;
                Role = role;
                Предмет = subject;
            }
        }


    }
}