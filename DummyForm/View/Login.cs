using DummyForm.Controller;
using DummyForm.View;

namespace DummyForm
{
    public partial class Login : Form
    {
        UserController userController;
        public Login()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameInput.Text;
            string password = passwordInput.Text;

            if (userController.loginValidation(userName, password))
            {
                this.Hide();
                ProductsList products = new ProductsList();
                products.Show();
                MessageBox.Show("Texto ingresado: " + userName + password);
            }
            else
            {
                MessageBox.Show("Lo siento, el usuario o contraseña es incorrecto.");
            }
        }
    }
}
