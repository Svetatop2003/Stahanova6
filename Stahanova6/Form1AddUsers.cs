using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stahanova6.МодельEF;

namespace Stahanova6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ModelEF Model = new ModelEF();
        void StartLoad()
        {
            dataGridView1.DataSource = Model.UsersHash.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StartLoad();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" ||
                textBoxPsw.Text == "" ||
                textBoxName.Text == "" )
            {
                MessageBox.Show("");
                return;
            }
            UsersHash usersHash = new UsersHash();
            usersHash.Login = textBoxLogin.Text;
            usersHash.Password = SHA256Builder.ConvertToHash(textBoxPsw.Text);
            usersHash.FirstName = textBoxName.Text;
            try
            {
                Model.UsersHash.Add(usersHash);
                Model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                StartLoad();
            }
            textBoxLogin.Text = "";
            textBoxPsw.Text = "";
            textBoxName.Text = "";
            MessageBox.Show("Данные добавлены");
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Form2Authorization form2 = new Form2Authorization();
            form2.ShowDialog();
        }
    }
}
