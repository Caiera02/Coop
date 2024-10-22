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

namespace Aula16
{
    public partial class Form1 : Form
    { string connectinString = @"Data Source=DESKTOP-5HIR0H9;
                                    Initial Catalog= Usuarios;
                                    Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Mensagem(string msg)
        {
            listBox1.Items.Add(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL Server
            //  SqlConnection
            //     ConnectionString
            //     Open()
            //     Close()

            //  SqlCommand
            //      Connection
            //      CommandText
            //      ExecuteReader()
            //      ExecuteNonQuery()
            //      ExecuteScalar()

            //  SqlDataReader
            //      Read()

            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-5HIR0H9;
                                    Initial Catalog=Cad_Equipamento;
                                    Integrated Security=True;
                                    Encrypt=False";
            cn.Open();
            Mensagem("Conexão Aberta");

            cn.Close();
            Mensagem("Conexão Fechada");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDb;Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT Nome FROM Cliente";

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader["Nome"].ToString();
                listBox1.Items.Add(nome);
            }
            reader.Close();
            cn.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDb;Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Cliente(Id,Nome,Email,Telefone) Values(@Id,@Nome,@Email,@Telefone)";
            cmd.Parameters.AddWithValue("@Id", 25);
            cmd.Parameters.AddWithValue("@Nome", "Joaquim Exemplo da Silva");
            cmd.Parameters.AddWithValue("@Telefone", "55++ (11) 5855-55555");
            cmd.Parameters.AddWithValue("@Email", "joaquim@teste.com.br");
            cn.Open();
            Mensagem("Conexão Aberta");

            int total=cmd.ExecuteNonQuery();
            Mensagem("Registro incluido");

            cn.Close();
            Mensagem("Conexão Fechada");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDb;Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE Cliente SET Nome=@Nome Where Id=@Id";
            cmd.Parameters.AddWithValue("@Id", 25);
            cmd.Parameters.AddWithValue("@Nome", "Joaquim Alterado da Silva");
            cn.Open();
            int total = cmd.ExecuteNonQuery();
            cn.Close();
            Mensagem("Registro alterado com sucesso");
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDb;Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE Cliente WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", 25);
            cn.Open();
            int total = cmd.ExecuteNonQuery();
            cn.Close();
            Mensagem("Registro excluído com sucesso");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = " SELECT * FROM USUARIOS ";
            SqlConnection con = new SqlConnection(connectinString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
                
            reader = cmd.ExecuteReader();
             while (reader.Read())
            {
                string nome = reader["Nome"].ToString();
                listBox1.Items.Add(nome);
            }
            reader.Close();
            //cn.Close();

        }
    }
}
