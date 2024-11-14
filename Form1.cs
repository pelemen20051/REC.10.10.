using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PR1
{
    public partial class Form1 : Form
    {
        bool vis = true;
        private List<RegistrationForm.User> users;

        public Form1(List<RegistrationForm.User> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vis)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                vis = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string name = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            RegistrationForm.User user = users.FirstOrDefault(u => u.ФИО == name && u.Password == password);

            if (user != null)
            {
                MessageBox.Show($"Добро пожаловать, {user.ФИО}! Ваша роль: {user.Role}");
                MessageBox.Show($"Ваш предмет: {user.Предмет}");

                // Открытие формы в зависимости от роли
                if (user.Role == "Учитель")
                {
                    Form2 teacherForm = new Form2(); // Создание формы для учителей
                    teacherForm.Show(); // Показ формы для учителей
                }
                else if (user.Role == "Ученик")
                {
                    Form3 studentForm = new Form3(); // Создание формы для учеников
                    studentForm.Show(); // Показ формы для учеников
                }
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
