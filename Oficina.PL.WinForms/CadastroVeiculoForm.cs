using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oficina.Modelos;
using Oficina.BLL;

namespace Oficina.PL.WinForms
{
    public partial class CadastroVeiculoForm : Form
    {
        #region ... Construtor(es) ...
        public CadastroVeiculoForm()
        {
            InitializeComponent();
        }
        #endregion

        #region ... Limpar Controles da Tela ...
        private void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                #region ..Sugestão
                if (ctl is TextBox || (ctl is Label && (string) ctl.Tag == "***"))
                {
                    ctl.Text = "";
                    //(ctl as TextBox).Clear();
                }
                else if(ctl is ListBox)
                {
                    (ctl as ListBox).SelectedIndex = -1;
                }
                #endregion
            }
        }

        private void cadastroVeiculoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Escape == e.KeyChar)
            {
                this.LimparTela();
            }
        }
        #endregion

        private void cadastroVeiculoForm_Load(object sender, EventArgs e)
        {
            try
            {
                #region Data Binding na ListBox
                clientesListBox.ValueMember = "Codigo";
                clientesListBox.DisplayMember = "Nome";
                // Repassa a solicitação (ListarClientes()) para a BLL!!!
                var clientesBll = new ClienteBLL();
                clientesListBox.DataSource = clientesBll.ListarClientes();
                //clientesListBox.SelectedIndex = -1; // Desmarca os elem. da lista! 
                #endregion

                #region Data Binding no DataGridView
                var veiculosBll = new VeiculoBLL();
                veiculosDataGridView.DataSource = veiculosBll.ListarVeiculos();
                #endregion

                this.LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message,
                        caption: "Alerta de Exceção",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error
                );
            }
        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var placa = pesquisarTextBox.Text;
                var bll = new VeiculoBLL();
                var veiculo = bll.Pesquisar(placa);

                if (veiculo != null)
                {
                    placaTextBox.Text = veiculo.Placa;
                    modeloTextBox.Text = veiculo.Modelo;
                    corTextBox.Text = veiculo.Cor;
                    anoTextBox.Text = veiculo.Ano.ToString();

                    clientesListBox.SelectedValue = veiculo.CodigoCliente;
                }
                else
                {
                    MessageBox.Show(text: "Placa não localizada!",
                                                    caption: "Aviso",
                                                    buttons: MessageBoxButtons.OK,
                                                    icon: MessageBoxIcon.Warning);
                }

                pesquisarTextBox.Focus();
                pesquisarTextBox.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message,
                        caption: "Alerta de Exceção",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error
                );
            }
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientesListBox.SelectedIndex == -1)
                {
                    throw new Exception("Selecione um cliente/proprietário!");
                }

                var veiculo = new VeiculoDTO
                {
                    Placa = placaTextBox.Text,
                    Modelo = modeloTextBox.Text,
                    Cor = corTextBox.Text,
                    Ano = Convert.ToInt16(anoTextBox.Text),
                    CodigoCliente = (int)clientesListBox.SelectedValue
                };

                var bll = new VeiculoBLL();
                bll.Inserir(veiculo);

                MessageBox.Show("Veiculo cadastrado com sucesso!");
                pesquisarTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message,
                        caption: "Alerta de Exceção",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error
                );
            }
        }

        private void atualizarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientesListBox.SelectedIndex == -1)
                {
                    throw new Exception("Selecione um cliente/proprietário!");
                }

                var veiculo = new VeiculoDTO
                {
                    Placa = placaTextBox.Text,
                    Modelo = modeloTextBox.Text,
                    Cor = corTextBox.Text,
                    Ano = Convert.ToInt16(anoTextBox.Text),
                    CodigoCliente =
                            Convert.ToInt32(clientesListBox.SelectedValue)
                };

                var bll = new VeiculoBLL();
                bll.Atualizar(veiculo);

                MessageBox.Show("Veiculo alterado com sucesso!");
                pesquisarTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message,
                        caption: "Alerta de Exceção",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error
                );
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                var res = MessageBox.Show("Deseja realmente excluir este veículo?",
                                                                "Alerta",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question,
                                                                MessageBoxDefaultButton.Button2);

                if (res == DialogResult.No)
                {
                    return;
                }

                var placa = placaTextBox.Text;
                var bll = new VeiculoBLL();
                bll.Excluir(placa);

                this.LimparTela();
                MessageBox.Show("Veiculo excluído com sucesso!");
                pesquisarTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message,
                        caption: "Alerta de Exceção",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error
                );
            }

        }

        private void veiculosDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            pesquisarTextBox.Text =
                veiculosDataGridView[0, e.RowIndex].Value.ToString();

            pesquisarButton.PerformClick();
        }
    }
}
