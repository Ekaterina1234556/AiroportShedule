using AiroportShedule.Data;
using AiroportShedule.Models;
using System;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly AirportDbContext _dbContext;

        public RegisterForm()
        {
            InitializeComponent();
            _dbContext = new AirportDbContext();
            UpdateSessionTimer();
        }

        private void UpdateSessionTimer()
        {
            var now = DateTime.Now;
            var endOfWorkDay = now.Date.AddHours(18);
            int hours = now > endOfWorkDay ? 0 : (int)(endOfWorkDay - now).TotalHours;
            lblSessionTimer.Text = hours > 0 ? $"У вас осталось {hours} ч." : "Сессия истекла";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Вход...";

            try
            {
                var user = _dbContext.AuthenticateUser(txtUsername.Text, txtPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Неверный логин или пароль.\nПожалуйста, проверьте данные и попробуйте снова.",
                        "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AppManager.Instance.SetCurrentUser(user);
                MessageBox.Show($"Добро пожаловать, {user.FullName}!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Войти";
            }
        }

        private void btnGuestAccess_Click(object sender, EventArgs e)
        {
            AppManager.Instance.SetCurrentUser(new User
            {
                Id = 0,
                Login = "guest",
                FullName = "Гость",
                Role = Role.Guest
            });
            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _dbContext.Dispose();
            base.OnFormClosing(e);
        }
    }
}