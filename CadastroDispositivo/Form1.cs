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
            CarregarFabricantes();
            LimparCampos();
        }

        // MÉTODO PARA CARREGAR OS FABRICANTES NO COMBOBOX
        private void CarregarFabricantes()
        {
            try
            {
                using (MySqlConnection conn = ConexaoBD.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Id, nome FROM fabricante"; // seleciona ID e nome dos fabricantes
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<int, string> fabricantes = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        fabricantes.Add(reader.GetInt32("Id"), reader.GetString("nome"));
                    }

                    cmbFabricante.DataSource = new BindingSource(fabricantes, null);
                    cmbFabricante.DisplayMember = "Value"; // exibe o nome do fabricante
                    cmbFabricante.ValueMember = "Key"; // obtem o ID do fabricante

                    cmbFabricante.SelectedIndex = -1;
                    cmbFabricante.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fabricantes: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            // Limpa os TextBoxes
            txtAliquota.Clear();
            txtDescricao.Clear();
            txtStatus.Clear();
            txtIdDeletar.Clear();
            txtIdAtualizar.Clear();
            txtAliquotaAtualizar.Clear();
            txtDescricaoAtualizar.Clear();
            txtStatusAtualizar.Clear();

            // Reseta o ComboBox para estado inicial
            cmbFabricante.SelectedIndex = -1;
            cmbFabricante.Text = "";
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
                    StatusDispositivo = txtStatus.Text,
                    fabricante_id = (int)cmbFabricante.SelectedValue // Obtém o ID do fabricante selecionado
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
                LimparCampos();
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
                    string query = "SELECT d.Id, d.aliquota, d.descricao, d.status_dispositivo, f.nome AS fabricante " +
                                   "FROM dispositivo d " +
                                   "JOIN fabricante f ON d.fabricante_id = f.Id"; // Faz a junção para exibir o nome do fabricante
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Dispositivo dispositivo = new Dispositivo
                        {
                            Id = reader.GetInt32("Id"),
                            Aliquota = reader.GetDecimal("aliquota"),
                            Descricao = reader.GetString("descricao"),
                            StatusDispositivo = reader.GetString("status_dispositivo"),
                            NomeFabricante = reader.GetString("fabricante") // Obtém o nome do fabricante
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
                LimparCampos();
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
                    StatusDispositivo = txtStatusAtualizar.Text,
                    fabricante_id = (int)cmbFabricante.SelectedValue
                };

                using (MySqlConnection conn = ConexaoBD.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE dispositivo SET aliquota = @aliquota, descricao = @descricao, " +
                                   "status_dispositivo = @status_dispositivo, id_fabricante = @id_fabricante " +
                                   "WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", dispositivo.Id);
                    cmd.Parameters.AddWithValue("@aliquota", dispositivo.Aliquota);
                    cmd.Parameters.AddWithValue("@descricao", dispositivo.Descricao);
                    cmd.Parameters.AddWithValue("@status_dispositivo", dispositivo.StatusDispositivo);
                    cmd.Parameters.AddWithValue("@id_fabricante", dispositivo.fabricante_id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Dispositivo atualizado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void cmbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFabricante_DropDown(object sender, EventArgs e)
        {
            if (cmbFabricante.Items.Count == 0)
            {
                CarregarFabricantes(); // recarrega os fabricantes se necessário
            }
        }
    }
}

