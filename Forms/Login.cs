using MySql.Data.MySqlClient;
using ProjetoUninove.Model.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace TesteTecnico2023
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
            var strconexao = "server=127.0.0.1; uid=root; database=sample; password";
            var conexao = new MySqlConnection(strconexao);
            conexao.Open();

            conexao.Close();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            }

        private void btnAcesso1_Click(object sender, EventArgs e)
        {
            

            }
        }
}

