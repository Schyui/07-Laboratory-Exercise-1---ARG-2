using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication1
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string uName = uNameTxtBx.Text;
            string password = passwordTxtBx.Text;
            Cashier cashier = new Cashier("Harvey Mellomida", "CS Department", "CS101", "meow");

            

            if (cashier.validateLogin(uName, password))
            {
                MessageBox.Show($"Welcome {cashier.getFullName()} of {cashier.getDepartment()}");
                frmPurchaseDiscountedItem frmPurchaseDiscountedItem = new frmPurchaseDiscountedItem();
                frmPurchaseDiscountedItem.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account does not exist");
                uNameTxtBx.Clear();
                passwordTxtBx.Clear();

            }
        }
    }
}
namespace UserAccountNamespace
{
    abstract class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }
        public abstract bool validateLogin(string uName, string password);
        public string getFullName()
        {
            return this.full_name;
        }
    }
    class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password) : base(name, uName, password)
        {
            this.department = department;
        }
        public override bool validateLogin(string uName, string password)
        {
            return this.user_name.Equals(uName) && this.user_password.Equals(password);
        }
        public string getDepartment()
        {
            return this.department;
        }
    }
}