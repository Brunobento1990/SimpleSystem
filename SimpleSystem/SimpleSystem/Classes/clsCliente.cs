using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SimpleSystem.Classe
{
    public class clsCliente
    {

        public string Codigo { get; set; }
        public bool Ativo { get; set; }
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
        public int Id_Reprasentante { get; set; }
        private string Conexao { get; set; } = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SimpleSystem;Data Source=Bruno";

        public clsCliente()
        {
        }
        public void Gravar()
        {
            try
            {
                using (var cnn = new SqlConnection(this.Conexao))
                {

                    string sql = @"insert into Cliente (Ativo,Nome,Cpf,Numero,Tipo_Pessoa,Telefone,Email,Data_Nascimento,Rg,Obs,Pais,Cep,Logradouro,Complemento,Bairro,Localidade,Uf,Id_Representante) values (@ativo,@nome,@cpf,@numero,@tipo_Pessoa,@telefone,@email,@data_Nascimento,@rg,@obs,@pais,@cep,@logradouro,@complemento,@bairro,@localidade,@uf,@id_Reprasentante)";
                    SqlCommand sqlComm = new SqlCommand(sql, cnn);
                    sqlComm.Parameters.AddWithValue("@ativo", this.Ativo);
                    sqlComm.Parameters.AddWithValue("@nome", this.Nome);
                    sqlComm.Parameters.AddWithValue("@cpf", this.Cpf);
                    sqlComm.Parameters.AddWithValue("@numero", this.Numero);
                    sqlComm.Parameters.AddWithValue("@tipo_Pessoa", this.Tipo_Pessoa);
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
                    sqlComm.Parameters.AddWithValue("@id_Reprasentante", this.Id_Reprasentante);
                    sqlComm.Connection.Open();
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("Cliente cadastrado com sucesso", "Simple System");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro na conexão com o banco de dados" + e.Errors + e.ErrorCode);
            }
        }
        public clsCliente AcharClientePorID(int id)
        {
            try
            {
                using (var cnn = new SqlConnection(this.Conexao))
                {

                    string sql = "select * from Cliente where Id_Cliente = @id";
                    SqlCommand sqlComm = new SqlCommand(sql, cnn);
                    sqlComm.Parameters.AddWithValue("@id", id);
                    sqlComm.Connection.Open();
                    sqlComm.ExecuteNonQuery();
                    SqlDataReader rdr = sqlComm.ExecuteReader();
                    rdr.Read();
                    int id1 = rdr.GetInt32(0);
                    this.Codigo = id1.ToString();
                    this.Ativo = rdr.GetBoolean(1);
                    this.Nome = rdr.GetString(2);
                    this.Cpf = rdr.GetString(3);
                    this.Numero = rdr.GetString(4);
                    this.Tipo_Pessoa = rdr.GetString(5);
                    this.Telefone = rdr.GetString(6);
                    this.Email = rdr.GetString(7);
                    this.Data_Nascimento = rdr.GetString(8);
                    this.Rg = rdr.GetString(9);
                    this.Obs = rdr.GetString(10);
                    this.Pais = rdr.GetString(11);
                    this.Cep = rdr.GetString(12);
                    this.Logradouro = rdr.GetString(13);
                    this.Complemento = rdr.GetString(14);
                    this.Bairro = rdr.GetString(15);
                    this.Localidade = rdr.GetString(16);
                    this.Uf = rdr.GetString(17);
                    this.Id_Reprasentante = rdr.GetInt32(22);

                }
                return this;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Cadastro não encontrado!" , "Simple System" + e.Message + e.Errors);
                return null;
            }
        }
        public void Alterar(int id)
        {
            try
            {
                using (var cnn = new SqlConnection(this.Conexao))
                {
                    string sql = @"update Cliente set Nome = @nome,Cpf = @cpf,Numero = @numero,Tipo_Pessoa = @tipo_Pessoa,Telefone = @telefone,Email = @email,Data_Nascimento = @data_Nascimento,Rg = @rg,Obs = @obs,Pais = @pais,Cep = @cep,Logradouro = @logradouro,
                    Complemento = @complemento,Bairro = @bairro,Localidade = @localidade,Uf = @uf,Id_Representante = @id_Representante where Id_Cliente = @id";
                    SqlCommand sqlComm = new SqlCommand(sql, cnn);
                    sqlComm.Parameters.AddWithValue("@id", id);
                    sqlComm.Parameters.AddWithValue("@nome", this.Nome);
                    sqlComm.Parameters.AddWithValue("@cpf", this.Cpf);
                    sqlComm.Parameters.AddWithValue("@numero", this.Numero);
                    sqlComm.Parameters.AddWithValue("@tipo_Pessoa", this.Tipo_Pessoa);
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
                    sqlComm.Parameters.AddWithValue("@id_Representante", this.Id_Reprasentante);
                    sqlComm.Connection.Open();
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("Representante atualizado com sucesso!", "Simple System");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro na conexão com o banco de dados" + e.Errors + e.ErrorCode);
            }
        }
        public void Excluir(int id, clsCliente cliente)
        {
            if (cliente != null)
            {
                try
                {
                    using (var cnn = new SqlConnection(this.Conexao))
                    {
                        string sql = @"update Cliente set Ativo = @ativo where Id_Cliente = @id";
                        SqlCommand sqlComm = new SqlCommand(sql, cnn);
                        sqlComm.Parameters.AddWithValue("@id", id);
                        sqlComm.Parameters.AddWithValue("@ativo", this.Ativo);
                        sqlComm.Connection.Open();
                        sqlComm.ExecuteNonQuery();
                        MessageBox.Show("Cliente desativado!", "Simple System");
                    }
                }
                catch (SqlException e)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados" + e.Errors + e.ErrorCode);
                }
            }
        }
    }
}
