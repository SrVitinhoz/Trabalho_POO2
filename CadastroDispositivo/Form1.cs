using CadastroDispositivo.Data;
using CadastroDispositivo.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace CadastroDispositivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um objeto Dispositivo com os dados do formulário
                Dispositivo dispositivo = new Dispositivo
                {
                    Aliquota = decimal.Parse(txtAliquota.Text),
                    Descricao = txtDescricao.Text,
                    StatusDispositivo = txtStatus.Text
                };

                using (MySqlConnection conn = ConexaoBD.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO dispositivo (aliquota, descricao, status_dispositivo) VALUES (@aliquota, @descricao, @status_dispositivo)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@aliquota", dispositivo.Aliquota);
                    cmd.Parameters.AddWithValue("@descricao", dispositivo.Descricao);
                    cmd.Parameters.AddWithValue("@status_dispositivo", dispositivo.StatusDispositivo);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Dispositivo cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Dispositivo> dispositivos = new List<Dispositivo>();

                using (MySqlConnection conn = ConexaoBD.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM dispositivo";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Dispositivo dispositivo = new Dispositivo
                        {
                            Id = reader.GetInt32("Id"),
                            Aliquota = reader.GetDecimal("aliquota"),
                            Descricao = reader.GetString("descricao"),
                            StatusDispositivo = reader.GetString("status_dispositivo")
                        };
                        dispositivos.Add(dispositivo);
                    }
                }

                // Exibe os dados no DataGridView
                dataGridViewDispositivos.DataSource = dispositivos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtIdDeletar.Text);

                using (MySqlConnection conn = ConexaoBD.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM dispositivo WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Dispositivo deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um objeto Dispositivo com os dados do formulário
                Dispositivo dispositivo = new Dispositivo
                {
                    Id = int.Parse(txtIdAtualizar.Text),
                    Aliquota = decimal.Parse(txtAliquotaAtualizar.Text),
                    Descricao = txtDescricaoAtualizar.Text,
                    StatusDispositivo = txtStatusAtualizar.Text
                };

                using (MySqlConnection conn = ConexaoBD.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE dispositivo SET aliquota = @aliquota, descricao = @descricao, status_dispositivo = @status_dispositivo WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", dispositivo.Id);
                    cmd.Parameters.AddWithValue("@aliquota", dispositivo.Aliquota);
                    cmd.Parameters.AddWithValue("@descricao", dispositivo.Descricao);
                    cmd.Parameters.AddWithValue("@status_dispositivo", dispositivo.StatusDispositivo);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Dispositivo atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}

