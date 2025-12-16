using System.Globalization;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace CrudComBancoDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CarregarSugestoes();

        }
        private void CarregarSugestoes()
        {
            AutoCompleteStringCollection nomes = new AutoCompleteStringCollection();

            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            string query = "SELECT nome FROM funcionarios"; // ajuste conforme sua tabela

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nomes.Add(reader["Nome"].ToString());
                }
            }

            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = nomes;
        }


        private void ControlePanel(Panel mostrarPainel)
        {
            panelCadastroFuncionario.Visible = false;
            panelImpressoras.Visible = false;
            panelEscolas.Visible = false;
            panelManutenção.Visible = false;
            mostrarPainel.Visible = true;

        }
        // Conexão padrão
        string connectionString = "server=localhost;user=root;database=cadastro;password=2903477Pe#;port=3306;";

        // Cadastrar Funcionário
        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO funcionarios (nome, telefone, email, ativo) VALUES (@nome, @telefone, @email, @ativo)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", textNome.Text);
                    cmd.Parameters.AddWithValue("@telefone", textTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", textEmail.Text);
                    cmd.Parameters.AddWithValue("@ativo", comboBoxAtivo.Text == "Sim" ? 1 : 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
            }
        }

        // Atualizar Funcionário
        private void button1_Click(object sender, EventArgs e)
        {
            // Monta mensagem de confirmação
            string msg = $"Deseja realmente atualizar este funcionário?\n\n" +
                         $"ID: {textId.Text}\n" +
                         $"Nome: {textNome.Text}\n" +
                         $"Telefone: {textTelefone.Text}\n" +
                         $"Email: {textEmail.Text}\n" +
                         $"Ativo: {comboBoxAtivo.Text}";

            var result = MessageBox.Show(msg, "Confirmar atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE funcionarios SET nome=@nome, telefone=@telefone, email=@email, ativo=@ativo WHERE idfuncionario=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", textId.Text);
                    cmd.Parameters.AddWithValue("@nome", textNome.Text);
                    cmd.Parameters.AddWithValue("@telefone", textTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", textEmail.Text);
                    cmd.Parameters.AddWithValue("@ativo", comboBoxAtivo.Text == "Sim" ? 1 : 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionário atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
            }
        }

        // Consultar Funcionário (por Id)
        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM funcionarios WHERE idfuncionario=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", textId.Text);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            textNome.Text = dr["nome"].ToString();
                            textTelefone.Text = dr["telefone"].ToString();
                            textEmail.Text = dr["email"].ToString();
                            comboBoxAtivo.Text = Convert.ToBoolean(dr["ativo"]) ? "Sim" : "Não";
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar: " + ex.Message);
                }
            }
        }

        // Exibir Todos Funcionários
        private void textExibir_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM funcionarios";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridFuncionarios.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir: " + ex.Message);
                }
            }
        }

        // Deletar Funcionário
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Monta mensagem de confirmação
            string msg = $"Deseja realmente deletar este funcionário?\n\n" +
                         $"ID: {textId.Text}\n" +
                         $"Nome: {textNome.Text}\n" +
                         $"Telefone: {textTelefone.Text}\n" +
                         $"Email: {textEmail.Text}\n" +
                         $"Ativo: {comboBoxAtivo.Text}";

            var result = MessageBox.Show(msg, "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM funcionarios WHERE idfuncionario=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", textId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionário deletado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar: " + ex.Message);
                }
            }
        }




        private void CadastrarAparelhos_Click(object sender, EventArgs e)
        {
            CarregarEscolasNoComboBox();
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                int idEscola = Convert.ToInt32(comboBoxEscola.SelectedValue);

                // Verificar se o ID da escola existe
                string verificaQuery = "SELECT COUNT(*) FROM escolas WHERE id = @idescola";
                MySqlCommand verificaComando = new MySqlCommand(verificaQuery, connection);
                verificaComando.Parameters.AddWithValue("@idescola", idEscola);

                int count = Convert.ToInt32(verificaComando.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("ID da escola inválido.");
                    return;
                }
                // Se existir, faz o INSERT
                string insertQuery = "INSERT INTO dispositivos (aparelho,estado,idescola) VALUES (@aparelho, @estado,@idescola)";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@aparelho", ModeloAparelho.Text);
                insertCommand.Parameters.AddWithValue("@estado", comboBoxAparelho.Text);
                insertCommand.Parameters.AddWithValue("@idescola", idEscola);
                insertCommand.ExecuteNonQuery();
                long idGerado = insertCommand.LastInsertedId;

                MessageBox.Show($"Aparelho cadastrado com sucesso:\nID:{idGerado}\nAparelho:{ModeloAparelho.Text}\nStatus:{comboBoxAparelho.Text}\nID da escola:{idEscola}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void AtualizarAparelho_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand comand = connection.CreateCommand();
                comand.CommandText = "UPDATE dispositivos SET aparelho = @nome, estado= @estado, idescola=@idescola WHERE id = @id "; 
                comand.Parameters.AddWithValue("@nome", ModeloAparelho.Text);
                comand.Parameters.AddWithValue("@estado", comboBoxAparelho.Text);
                comand.Parameters.AddWithValue("@idescola", comboBoxEscola.Text);
                comand.Parameters.AddWithValue("@id", textIdAparelho.Text);
                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void DeleteAparelhos_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // Passo 1: Buscar os dados do funcionário
                MySqlCommand selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM dispositivos WHERE id = @id";
                selectCmd.Parameters.AddWithValue("@id", textIdAparelho.Text);

                MySqlDataReader reader = selectCmd.ExecuteReader();

                if (reader.Read())
                {
                    // Construindo uma mensagem com os dados
                    string aparelho = reader["aparelho"].ToString();
                    string estado = reader["estado"].ToString();
                    // Adicione outros campos conforme necessário

                    reader.Close(); // fecha antes de usar outro comando

                    DialogResult confirm = MessageBox.Show(
                        $"Você tem certeza que deseja deletar este funcionário?\n\n" +
                        $"ID: {textIdAparelho.Text}\nAparelho: {aparelho}\nEstado: {estado}",
                        "Confirmar exclusão",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        MySqlCommand deleteCmd = connection.CreateCommand();
                        deleteCmd.CommandText = "DELETE FROM funcionarios WHERE id = @id";
                        deleteCmd.Parameters.AddWithValue("@id", textId.Text);
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Aparelho deletado com sucesso!");
                    }
                }
                else
                {
                    MessageBox.Show("Aparelho não encontrado.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro: " + error.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void atualizarAparelho_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand comand = connection.CreateCommand();
                comand.CommandText = "UPDATE dispositivos SET aparelho = @nome, estado= @estado, idescola=@idescola WHERE id = @id ";
                comand.Parameters.AddWithValue("@nome", ModeloAparelho.Text);
                comand.Parameters.AddWithValue("@estado", comboBoxAparelho.Text);
                comand.Parameters.AddWithValue("@idescola", comboBoxEscola.Text);
                comand.Parameters.AddWithValue("@id", textIdAparelho.Text);
                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ConsultarAparelhos_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand comand = connection.CreateCommand();
                comand.CommandText = "SELECT * FROM dispositivos WHERE id =@id";
                comand.Parameters.AddWithValue("@id", textIdAparelho.Text);
                MySqlDataReader dr;
                dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    ModeloAparelho.Text = Convert.ToString(dr["aparelho"]);
                    comboBoxAparelho.Text = Convert.ToString(dr["estado"]);
                    comboBoxEscola.Text = Convert.ToString(dr["idescola"]);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally { connection.Close(); }
        }

        private void ExibirAparelhos_Click(object sender, EventArgs e)
        
         {
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT  dispositivos.id, dispositivos.aparelho, dispositivos.estado,dispositivos.idescola, escolas.nome FROM dispositivos INNER JOIN escolas ON dispositivos.idescola = escolas.id", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridAparelho.DataSource = dt;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally { connection.Close(); }
        }







        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        /*private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/

  

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Funcionarios_Click(object sender, EventArgs e)
        {
            ControlePanel(panelCadastroFuncionario);
        }

        private void Impressoras_Click(object sender, EventArgs e)
        {
            ControlePanel(panelImpressoras);
            
            CarregarEscolasNoComboBox();
        }

        private void Escolas_Click(object sender, EventArgs e)
        {
            ControlePanel(panelEscolas);
        }

        private void Manutenções_Click(object sender, EventArgs e)
        {
            ControlePanel(panelManutenção);
            CarregarSugestoes();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panelEscolas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panelImpressoras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textIdAparelho_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModeloAparelho_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAparelho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Cadastrar Escola
        private void CadastrarEscola_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO escolas 
                        (nome_escola, endereco, nome_gestor, telefone_gestor, nome_secretario, telefone_secretario) 
                        VALUES (@nome, @endereco, @nome_gestor, @telefone_gestor, @nome_secretario, @telefone_secretario)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", txtnomeEscola.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEnderecoEscola.Text);
                    cmd.Parameters.AddWithValue("@nome_gestor", txtNomeGestor.Text);
                    cmd.Parameters.AddWithValue("@telefone_gestor", txtTelefoneGestor.Text);
                    cmd.Parameters.AddWithValue("@nome_secretario", txtNomeSecretario.Text);
                    cmd.Parameters.AddWithValue("@telefone_secretario", txtNomeSecretario.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Escola cadastrada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
            }
        }

        // Atualizar Escola
        private void AtualizarEscola_Click(object sender, EventArgs e)
        {
            string msg = $"Deseja realmente atualizar esta escola?\n\n" +
                         $"ID: {txtidescola.Text}\n" +
                         $"Nome: {txtnomeEscola.Text}\n" +
                         $"Endereço: {txtEnderecoEscola.Text}\n" +
                         $"Gestor: {txtNomeGestor.Text} - {txtTelefoneGestor.Text}\n" +
                         $"Secretário: {txtNomeSecretario.Text} - {txtTelefoneSecretario.Text}";

            var result = MessageBox.Show(msg, "Confirmar atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE escolas SET 
                        nome_escola=@nome, endereco=@endereco, nome_gestor=@nome_gestor, telefone_gestor=@telefone_gestor, 
                        nome_secretario=@nome_secretario, telefone_secretario=@telefone_secretario 
                        WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtidescola.Text);
                    cmd.Parameters.AddWithValue("@nome", txtnomeEscola.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEnderecoEscola.Text);
                    cmd.Parameters.AddWithValue("@nome_gestor", txtNomeGestor.Text);
                    cmd.Parameters.AddWithValue("@telefone_gestor", txtTelefoneGestor.Text);
                    cmd.Parameters.AddWithValue("@nome_secretario", txtNomeSecretario.Text);
                    cmd.Parameters.AddWithValue("@telefone_secretario", txtTelefoneSecretario.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Escola atualizada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
            }
        }

        // Deletar Escola
        private void DeleteEscolas_Click(object sender, EventArgs e)
        {
            string msg = $"Deseja realmente deletar esta escola?\n\n" +
                         $"ID: {txtidescola.Text}\n" +
                         $"Nome: {txtnomeEscola.Text}\n" +
                         $"Endereço: {txtEnderecoEscola.Text}\n" +
                         $"Gestor: {txtNomeGestor.Text} - {txtTelefoneGestor.Text}\n" +
                         $"Secretário: {txtNomeSecretario.Text} - {txtTelefoneSecretario.Text}";

            var result = MessageBox.Show(msg, "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM escolas WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtidescola.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Escola deletada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar: " + ex.Message);
                }
            }
        }

        // Consultar Escola por Id
        private void ConsultarEscolas_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM escolas WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtidescola.Text);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtnomeEscola.Text = dr["nome_escola"].ToString();
                            txtEnderecoEscola.Text = dr["endereco"].ToString();
                            txtNomeGestor.Text = dr["nome_gestor"].ToString();
                            txtTelefoneGestor.Text = dr["telefone_gestor"].ToString();
                            txtNomeSecretario.Text = dr["nome_secretario"].ToString();
                            txtTelefoneSecretario.Text = dr["telefone_secretario"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Escola não encontrada.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar: " + ex.Message);
                }
            }
        }

        // Exibir Todas as Escolas
        private void ExibirEscolas_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM escolas";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridEscolas.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir: " + ex.Message);
                }
            }
        }

        private void exibirImpressoraEscola_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT dispositivos.idescola,dispositivos.id, dispositivos.aparelho, dispositivos.estado, escolas.nome_escola FROM dispositivos INNER JOIN escolas ON dispositivos.idescola = escolas.id where escolas.id=@id;", connection);
                da.SelectCommand.Parameters.AddWithValue("@id", txtidescola.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridEscolas.DataSource = dt;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally { connection.Close(); }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

    

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) // Cadastrar Manutenção
        {
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO manutencao (funcionario_id, aparelho_id, data_manutencao, descricao) VALUES (@id_funcionario, @id_aparelho, @data_manutencao, @descricao)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@id_funcionario", textBox2.Text);
                    cmd.Parameters.AddWithValue("@id_aparelho", textBox1.Text);
                    cmd.Parameters.AddWithValue("@data_manutencao", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@descricao", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manutenção cadastrada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //Atualizar Manutenção
        {


            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT manutencao.id,funcionarios.nome,dispositivos.aparelho,manutencao.data_manutencao,manutencao.descricao FROM manutencao INNER JOIN funcionarios ON manutencao.funcionario_id = funcionarios.id INNER JOIN dispositivos ON manutencao.dispositivos_id = dispositivos.id", connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir: " + ex.Message);
                }
            }
        }
    

        private void AtualizarManutenção_Click(object sender, EventArgs e)//Atualizar Manutenção
        {
       
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            
                try
                {
                    connection.Open();
                    DateTime nascimento;
                    if (!DateTime.TryParseExact(maskedTextBox1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out nascimento))
                    {
                        MessageBox.Show("Data de nascimento inválida. Use o formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string dataFormatada = nascimento.ToString("yyyy-MM-dd");

                    string updateQuery = "UPDATE manutencao SET funcionario_id = @id_funcionario, dispositivos_id = @id_aparelho, data_manutencao = @data_manutencao, descricao = @descricao WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@id", textBox2.Text);
                    cmd.Parameters.AddWithValue("@id_funcionario", textBox1.Text);
                    cmd.Parameters.AddWithValue("@id_aparelho", textBox3.Text);
                    cmd.Parameters.AddWithValue("@data_manutencao",dataFormatada);
                    cmd.Parameters.AddWithValue("@descricao", richTextBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manutenção atualizada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
            
        }
        
        private void button2_Click(object sender, EventArgs e) //Consutlar Manutenção
        {
            
 
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM manutencao INNER JOIN funcionarios ON manutencao.funcionario_id = funcionarios.id INNER JOIN dispositivos ON manutencao.dispositivos_id = dispositivos.id  WHERE manutencao.id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", textBox2.Text);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            textBox1.Text = dr["funcionario_id"].ToString()+": " + dr["nome"];
                            textBox3.Text = dr["dispositivos_id"].ToString() + ": " + dr["aparelho"];
                            maskedTextBox1.Text = Convert.ToDateTime(dr["data_manutencao"]).ToString("dd/MM/yyyy");
                            richTextBox1.Text = dr["descricao"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Manutenção não encontrada.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar: " + ex.Message);
                }
            }
        }

    

        private void button3_Click(object sender, EventArgs e) //Deletar Manutenção
        {
       
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM manutencoes WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                    cmd.Parameters.AddWithValue("@id", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manutenção deletada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar: " + ex.Message);
                }
            }
        
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=dtmp;password=2903477Pe#;port=3306;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                DateTime nascimento;
                if (!DateTime.TryParseExact(maskedTextBox1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out nascimento))
                {
                    MessageBox.Show("Data de nascimento inválida. Use o formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string dataFormatada = nascimento.ToString("yyyy-MM-dd");

                // Se não existir, faz o INSERT
                string insertQuery = "INSERT INTO manutencao (dispositivos_id,funcionario_id,data_manutencao,descricao) VALUES (@id_aparelho,@id_funcionario,@data_manutencao,@descricao)";
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                cmd.Parameters.AddWithValue("@id_funcionario", textBox1.Text);
                cmd.Parameters.AddWithValue("@id_aparelho", textBox3.Text);
                cmd.Parameters.AddWithValue("@data_manutencao", dataFormatada);
                cmd.Parameters.AddWithValue("@descricao", richTextBox1.Text);
                cmd.ExecuteNonQuery();
                long idGerado = cmd.LastInsertedId;
                MessageBox.Show($"Aparelho cadastrado com sucesso:\nID:{idGerado}\nID Funcionario:{textBox1.Text}\nId Data Manutenção:{maskedTextBox1.Text}\n Descrição:{richTextBox1.Text}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=cadastro;password=2903477Pe#;port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string Query = "SELECT manutencao.id,funcionarios.nome,dispositivos.aparelho,manutencao.data_manutencao,manutencao.descricao FROM manutencao INNER JOIN funcionarios ON manutencao.funcionario_id = funcionarios.id INNER JOIN dispositivos ON manutencao.dispositivos_id = dispositivos.id where funcionario_id=@idFuncionario";
                    MySqlCommand cmd = new MySqlCommand(Query, connection);
                    cmd.Parameters.AddWithValue("@idFuncionario", textBox1.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir: " + ex.Message);
                }
            }
        }

        private void textTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
        private void CarregarEscolasNoComboBox()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nome_escola FROM escolas";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxEscola.DataSource = dt;
                    comboBoxEscola.DisplayMember = "nome_escola"; // O que aparece para o usuário
                    comboBoxEscola.ValueMember = "id";            // O valor real (ID)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar escolas: " + ex.Message);
                }
            }
        }
    }
}
               /*MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM users";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show(reader["name"] + " - " + reader["email"]);
                }*/