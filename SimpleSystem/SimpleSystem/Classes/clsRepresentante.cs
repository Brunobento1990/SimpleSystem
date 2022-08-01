using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSystem.Classes
{
    public class clsRepresentante
    {
        public string Codigo { get; set; }
        public string Ativo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Numero { get; set; }
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
        private string Conexao { get; set; } = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SimpleSystem;Data Source=Bruno";

        public clsRepresentante() { }
        public void Gravar()
        {

            try
            {
                using (var cnn = new SqlConnection(this.Conexao))
                {

                    string sql = @"insert into Representante (Ativo,Nome,Cpf,Numero,Telefone,Email,Data_Nascimento,Rg,Obs,Pais,Cep,Logradouro,Complemento,Bairro,Localidade,Uf) values (@ativo, @nome, @cpf,@numero,@telefone,@email,@data_Nascimento,@rg,@obs,@pais,@cep,@logradouro,@complemento,@bairro,@localidade,@uf)";
                    SqlCommand sqlComm = new SqlCommand(sql, cnn);
                    sqlComm.Parameters.AddWithValue("@ativo", this.Ativo);
                    sqlComm.Parameters.AddWithValue("@nome", this.Nome);
                    sqlComm.Parameters.AddWithValue("@cpf", this.Cpf);
                    sqlComm.Parameters.AddWithValue("@numero", this.Numero);
                    sqlComm.Parameters.AddWithValue("@telefone", this.Telefone);
                    sqlComm.Parameters.AddWithValue("@email", this.Email);
                    sqlComm.Parameters.AddWithValue("@data_Nascimento", this.Data_Nascimento);
                    sqlComm.Parameters.AddWithValue("@rg", this.Rg);
                    sqlComm.Parameters.AddWithValue("@obs", this.Obs);
                    sqlComm.Parameters.AddWithValue("@pais", this.Pais);
                    sqlComm.Parameters.AddWithValue("@cep", this.Cep);
                    sqlComm.Parameters.AddWithValue("@logradouro", this.Logradouro);
                    sqlComm.Parameters.AddWithValue("@complemento", this.Complemento);
                    sqlComm.Parameters.AddWithValue("@bairro", this.Bairro);
                    sqlComm.Parameters.AddWithValue("@localidade", this.Localidade);
                    sqlComm.Parameters.AddWithValue("@uf", this.Uf);
                    sqlComm.Connection.Open();
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("Representante cadastrado com sucesso","Simple System");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro na conexão com o banco de dados" + e.Errors + e.ErrorCode);
            }

        }
        public void Excluir(int id,clsRepresentante representante)
        {
            if (representante != null)
            {
                try
                {
                    using (var cnn = new SqlConnection(this.Conexao))
                    {
                        string sql = @"update Representante set Ativo = 2 where Id_Representante = @id";
                        SqlCommand sqlComm = new SqlCommand(sql, cnn);
                        sqlComm.Parameters.AddWithValue("@id", id);
                        sqlComm.Connection.Open();
                        sqlComm.ExecuteNonQuery();
                        MessageBox.Show("Representante desativado!", "Simple System");
                    }
                }
                catch (SqlException e)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados" + e.Errors + e.ErrorCode);
                }
            }
        }
        public clsRepresentante AcharRepresentantePorId(int id)
        {

            try
            {
                //string Coneccao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Bruno;Data Source=ITELABD03\SQLEXPRESS01";
                using (var cnn = new SqlConnection(this.Conexao))
                {

                    string sql = "select * from Representante where Id_Representante = @id";
                    SqlCommand sqlComm = new SqlCommand(sql, cnn);
                    sqlComm.Parameters.AddWithValue("@id", id);
                    sqlComm.Connection.Open();
                    sqlComm.ExecuteNonQuery();
                    SqlDataReader rdr = sqlComm.ExecuteReader();
                    rdr.Read();
                    int id1 = rdr.GetInt32(0);
                    this.Codigo = id1.ToString();
                    this.Ativo = rdr.GetString(1);
                    this.Nome = rdr.GetString(2);
                    this.Cpf = rdr.GetString(3);
                    this.Numero = rdr.GetString(4);
                    this.Telefone = rdr.GetString(5);
                    this.Email = rdr.GetString(6);
                    this.Data_Nascimento = rdr.GetString(7);
                    this.Rg = rdr.GetString(8);
                    this.Obs = rdr.GetString(9);
                    this.Pais = rdr.GetString(10);
                    this.Cep = rdr.GetString(11);
                    this.Logradouro = rdr.GetString(12);
                    this.Complemento = rdr.GetString(13);
                    this.Bairro = rdr.GetString(14);
                    this.Localidade = rdr.GetString(15);
                    this.Uf = rdr.GetString(16);

                }
                return this;
            }
            catch (Exception e)
            {
                MessageBox.Show("Cadastro não encontrado!" + "Simple System");
                return null;
            }
        }
        public void Alterar(int id)
        {
            try
            {
                using (var cnn = new SqlConnection(this.Conexao))
                {
                    string sql = @"update Representante set Nome = @nome,Cpf = @cpf,Numero = @numero,Telefone = @telefone,Email = @email,Data_Nascimento = @data_Nascimento,Rg = @rg,Obs = @obs,Pais = @pais,Cep = @cep,Logradouro = @logradouro,
                    Complemento = @complemento,Bairro = @bairro,Localidade = @localidade,Uf = @uf where Id_representante = @id";
                    SqlCommand sqlComm = new SqlCommand(sql, cnn);
                    sqlComm.Parameters.AddWithValue("@id", id);
                    sqlComm.Parameters.AddWithValue("@nome", this.Nome);
                    sqlComm.Parameters.AddWithValue("@cpf", this.Cpf);
                    sqlComm.Parameters.AddWithValue("@numero", this.Numero);
                    sqlComm.Parameters.AddWithValue("@telefone", this.Telefone);
                    sqlComm.Parameters.AddWithValue("@email", this.Email);
                    sqlComm.Parameters.AddWithValue("@data_Nascimento", this.Data_Nascimento);
                    sqlComm.Parameters.AddWithValue("@rg", this.Rg);
                    sqlComm.Parameters.AddWithValue("@obs", this.Obs);
                    sqlComm.Parameters.AddWithValue("@pais", this.Pais);
                    sqlComm.Parameters.AddWithValue("@cep", this.Cep);
                    sqlComm.Parameters.AddWithValue("@logradouro", this.Logradouro);
                    sqlComm.Parameters.AddWithValue("@complemento", this.Complemento);
                    sqlComm.Parameters.AddWithValue("@bairro", this.Bairro);
                    sqlComm.Parameters.AddWithValue("@localidade", this.Localidade);
                    sqlComm.Parameters.AddWithValue("@uf", this.Uf);
                    sqlComm.Connection.Open();
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("Representante atualizado com sucesso!" , "Simple System");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro na conexão com o banco de dados" + e.Errors + e.ErrorCode);
            }
        }
    }
}