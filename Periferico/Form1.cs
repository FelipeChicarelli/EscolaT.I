using MySql.Data.MySqlClient;

namespace Periferico
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
                if (!txtNome.Text.Equals("") && !txtCor.Text.Equals("") && !txtData.Text.Equals(""))
                {
                    cadastradoPerifericos cadPerifericos = new cadastradoPerifericos();
                    cadPerifericos.Nome = txtNome.Text;
                    cadPerifericos.Cor = txtCor.Text;
                    cadPerifericos.DataFabricacao = int.Parse(txtData.Text);

                    if (cadPerifericos.cadastrarPerifericos())
                    {
                        MessageBox.Show($"O Periferico {cadPerifericos.Nome} foi cadastrado com sucesso");
                        txtNome.Clear();
                        txtCor.Clear();
                        txtData.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Nao foi possivel cadastrar periferico!");
                    }
                }
                else
                {
                    MessageBox.Show("Por favo preencher todos os campo corretamente!");
                    txtNome.Clear();
                    txtCor.Clear();
                    txtData.Clear();
                    txtNome.Focus();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o periferico: " + ex.Message);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals(""))
                {
                    cadastradoPerifericos cadPerifericos = new cadastradoPerifericos();
                    cadPerifericos.Nome = txtNome.Text;

                    MySqlDataReader reader = cadPerifericos.localizarPerifericos();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblId.Text = reader["id"].ToString();
                            txtCor.Text = reader["cor"].ToString();
                            txtData.Text = reader["dataFabricacao"].ToString();


                        }
                        else
                        {
                            MessageBox.Show("Periferico não encotrado");
                            txtNome.Clear();
                            txtCor.Clear();
                            txtData.Clear();
                            txtNome.Focus();
                            lblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Periferico não encotrado");
                        txtNome.Clear();
                        txtCor.Clear();
                        txtData.Clear();
                        txtNome.Focus();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Por favor prencher o campo Nome para realiazr a pesquisa!");
                    txtNome.Clear();
                    txtCor.Clear();
                    txtData.Clear();
                    txtNome.Focus();
                    lblId.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar periferico: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCor.Clear();
            txtData.Clear();
            lblId.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtCor.Text.Equals("") && !txtData.Text.Equals(""))
                {
                    cadastradoPerifericos cadPerifericos = new cadastradoPerifericos();
                    cadPerifericos.Id = int.Parse(lblId.Text);
                    cadPerifericos.Cor = txtCor.Text;
                    cadPerifericos.DataFabricacao = int.Parse(txtData.Text);

                    if (cadPerifericos.atualizarPeriferico())
                    {
                        MessageBox.Show("Os dados do periferico foi atualizada com sucesso!");
                        txtNome.Clear();
                        txtCor.Clear();
                        txtData.Clear();
                        lblId.Text = "";
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Nao foi possivel atualizar a informacoes do periferico");
                        txtNome.Clear();
                        txtCor.Clear();
                        txtData.Clear();
                        lblId.Text = "";
                        txtNome.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor localizar o periferico que deseja atualizar as informacoes");
                    txtNome.Clear();
                    txtCor.Clear();
                    txtData.Clear();
                    lblId.Text = "";
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do periferico: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtCor.Text.Equals("") && !txtData.Text.Equals(""))
                {
                    cadastradoPerifericos cadPerifericos = new cadastradoPerifericos();
                    cadPerifericos.Id = int.Parse(lblId.Text);
                    if (cadPerifericos.deletarPeriferico())
                    {
                        MessageBox.Show("O periferico foi excluido com sucesso!");
                        txtNome.Clear();
                        txtCor.Clear();
                        txtData.Clear();
                        lblId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Nao foi possivel exlucir periferico");
                        txtNome.Clear();
                        txtCor.Clear();
                        txtData.Clear();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Por favor pesquisar qual periferico deseja excluir");
                    txtNome.Clear();
                    txtCor.Clear();
                    txtData.Clear();
                    lblId.Text = "";
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir periferico: " + ex.Message);              
            }
        }
    }
}
