using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SimpleSystem.Classe
{
    public class clsCliente
    {

        public string Codigo { get; set; }
        public string Ativo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Numero { get; set; }
        public string Tipo_Pessoa { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Data_Nascimento { get; set; }
        public string Rg { get; set; }
        public string Obs { get; set; }
        public string Pais { get; set; }
        //Dados do retorno API Via Cep
        [JsonProperty(PropertyName = "cep")]
        public string Cep { get; set; }
        [JsonProperty(PropertyName = "logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty(PropertyName = "complemento")]
        public string Complemento { get; set; }
        [JsonProperty(PropertyName = "bairro")]
        public string Bairro { get; set; }
        [JsonProperty(PropertyName = "localidade")]
        public string Localidade { get; set; }
        [JsonProperty(PropertyName = "uf")]
        public string Uf { get; set; }
        [JsonProperty(PropertyName = "ibge")]
        public string Ibge { get; set; }
        [JsonProperty(PropertyName = "gia")]
        public string Gia { get; set; }
        [JsonProperty(PropertyName = "ddd")]
        public string DDD { get; set; }
        [JsonProperty(PropertyName = "siafi")]
        public string Siafi { get; set; }

        public clsCliente()
        {
        }
        public void Gravar()
        {
           // bool Ok = true;
            try
            {
                string Coneccao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SimpleSystem;Data Source=Bruno";
                SqlConnection cnn;
                cnn = new SqlConnection(Coneccao);
                string insert = "insert into Cliente values ('" + this.Ativo + "','" + this.Nome + "','" + this.Cpf + "','" + this.Numero + "','" + this.Tipo_Pessoa + "'," +
                    "'" + this.Telefone + "','" + this.Email + "','" + this.Data_Nascimento + "','" + this.Rg + "','" + this.Obs + "','"+this.Pais+"','" + this.Cep + "','" + this.Logradouro + "'," +
                    "'" + this.Complemento + "','" + this.Bairro + "', '" + this.Localidade + "','" + this.Uf + "','" + this.Ibge + "','" + this.Gia + "'," +
                    "'" + this.DDD + "','" + this.Siafi + "')";
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.Connection = cnn;
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = insert;
                sqlComm.Connection.Open();
                sqlComm.ExecuteNonQuery();
                sqlComm.Connection.Close();
                cnn.Close();
                MessageBox.Show("Cliente cadastrado com sucesso");

            }
            catch (SqlException e)
            {

                MessageBox.Show("Erro na conexão com o banco de dados" + e.Errors + e.ErrorCode);
            }
            //return Ok;
        }
        public clsCliente Carregar(string id)
        {
            try
            {
                string Coneccao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SimpleSystem;Data Source=Bruno";
                SqlConnection cnn;
                cnn = new SqlConnection(Coneccao);
                string Select = "select * from Cliente where Id_Cliente = '" + id + "'";
                SqlCommand sqlComm = new SqlCommand
                {
                    Connection = cnn,
                    CommandType = CommandType.Text,
                    CommandText = Select
                };
                sqlComm.Connection.Open();
                SqlDataReader rdr = sqlComm.ExecuteReader();
                rdr.Read();
                int id1 = rdr.GetInt32(0);
                this.Codigo = id1.ToString();
                this.Ativo = rdr.GetString(1);
                this.Nome = rdr.GetString(2);
                this.Cpf = rdr.GetString(3);
                this.Numero = rdr.GetString(4);
                this.Cep = rdr.GetString(5);
                this.Logradouro = rdr.GetString(6);
                this.Complemento = rdr.GetString(7);
                this.Bairro = rdr.GetString(8);
                this.Localidade = rdr.GetString(9);
                this.Uf = rdr.GetString(10);
                this.Ibge = rdr.GetString(11);
                this.Gia = rdr.GetString(12);
                this.DDD = rdr.GetString(13);
                this.Siafi = rdr.GetString(14);
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro na conexão com o banco de dados");
            }

            return this;
        }
        public clsCliente CarregarInicio()
        {
            try
            {
                string Coneccao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SimpleSystem;Data Source=Bruno";
                SqlConnection cnn;
                cnn = new SqlConnection(Coneccao);
                string Select = "SELECT * FROM Cliente ORDER BY Id_Cliente desc";
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.Connection = cnn;
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = Select;
                sqlComm.Connection.Open();
                SqlDataReader rdr = sqlComm.ExecuteReader();
                rdr.Read();
                int id1 = rdr.GetInt32(0);
                this.Codigo = id1.ToString();
                this.Ativo = rdr.GetString(1);
                this.Nome = rdr.GetString(2);
                this.Cpf = rdr.GetString(3);
                this.Numero = rdr.GetString(4);
                this.Cep = rdr.GetString(5);
                this.Logradouro = rdr.GetString(6);
                this.Complemento = rdr.GetString(7);
                this.Bairro = rdr.GetString(8);
                this.Localidade = rdr.GetString(9);
                this.Uf = rdr.GetString(10);
                this.Ibge = rdr.GetString(11);
                this.Gia = rdr.GetString(12);
                this.DDD = rdr.GetString(13);
                this.Siafi = rdr.GetString(14);
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro na conexão com o banco de dados");
            }
            return this;
        }
    }
}
