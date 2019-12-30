using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetoCadastro.Bll;
using ProjetoCadastro.Model;

namespace ProjetoCadastro
{
    public partial class Cadastro : Form
    {

        public Cadastro()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Listar();
        }

        private void LimparCampos()
        {
            txt_bairro.Clear();
            txt_cep.Clear();
            txt_endereco.Clear();
            txt_cidade.Clear();
            txt_cpf.Clear();
            txt_nome.Clear();
            txt_id.Clear();
            txt_email.Clear();
            txt_telefone.Clear();
            txt_nascimento.Clear();
            txt_estado.SelectedIndex = -0;
            txt_numero.Clear();
            
        }
        //método para salvar dados
        private void Salvar(ClasseDados cliente)
        {
            txt_nome.BackColor = Color.AliceBlue;
            txt_cpf.BackColor = Color.AliceBlue;
            txt_nascimento.BackColor = Color.AliceBlue;


            //--Verificando dados obrigatórios--
            //--Regras para salvar nome--
            //Não pode ser vazia, espaços em branco são desconsiderados
            //não pode ter mais do que 49 caracteres, espaços em branco são considerados
            //Precisa ter mais do que 10 caracteres contando com espaços em branco

            int cont = 0; // contagem para ver se existe erro antes de salvar e exibir apenas uma mensagebox

            if (txt_nome.Text.Trim() == string.Empty || txt_nome.Text.Length < 10)
            {
                txt_nome.BackColor = Color.DimGray;
                cont ++;
            }
            // cpf apenas considerei que esteja com todos os campos preenchidos
            //VALIDAÇÃO DE CPF PRECISA SER CONSTRUIDO
            if (!txt_cpf.MaskCompleted)
            {
                txt_cpf.BackColor = Color.DimGray;
                cont ++;
            }

            if (txt_nascimento.MaskCompleted) //verifica se foi preenchido o campo data de nascimento por completo
            {
                var aux = txt_nascimento.Text;
                Convert.ToDateTime(aux).ToString("yyyy/MM/dd");
                DateTime date = DateTime.Parse(aux);
                //---Regras para data da nascimento---
                //Tem que ser maior de 16 anos
                //tem que ter menos de 100 anos
                //precisa ter nascido antes de fazer o cadastro

                if (date >= DateTime.Now || (DateTime.Now.Year - date.Year) > 100 || (DateTime.Now.Year - date.Year) < 16)
                {
                    txt_nascimento.BackColor = Color.DimGray;
                    cont++;
                }
            }
            else
            {
                txt_nascimento.BackColor = Color.DimGray;
                cont++;
            }



            if (cont!=0)    // CASO TENHA ERRO NOS DADOS, APARECE A MENSAGEM ERRO E NÃO É POSSIVEL SALVAR OS DADOS
                MessageBox.Show("Existem campos obrigatórios!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else//SALVAR DADOS CASO TUDO OK
            {
                ClientesBll clienteBll = new ClientesBll();
                cliente.Cpf = txt_cpf.Text;
                cliente.Nome = txt_nome.Text;
                cliente.Nascimento = DateTime.Parse(txt_nascimento.Text);
                cliente.Cep = txt_cep.Text;
                cliente.Endereco = txt_endereco.Text;
                cliente.Numero = txt_numero.Text;
                cliente.Cidade = txt_cidade.Text;
                cliente.Bairro = txt_bairro.Text;
                cliente.Estado = txt_estado.Text;
                cliente.Telefone = txt_telefone.Text;
                cliente.Email = txt_email.Text;

                clienteBll.Salvar(cliente);

                MessageBox.Show("Cadastro realizado com sucesso!");
                LimparCampos();
                Listar();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Gravar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                ClasseDados cliente = new ClasseDados();
                Salvar(cliente);
            }
            else
            {
                MessageBox.Show("Ja existe um cadastro com esse ID!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Menu voltarMenu = new Menu();
            this.Hide();
            voltarMenu.ShowDialog();
        }


        private void Listar()
        {
            ClientesBll clientes = new ClientesBll();

            dg_dados.DataSource = clientes.Listar();
        }

        //Passa os dados do datagridview para os campos
        private void Dg_dados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_dados.CurrentRow.Cells[0].Value.ToString();
            txt_cpf.Text = dg_dados.CurrentRow.Cells[1].Value.ToString();
            txt_nome.Text = dg_dados.CurrentRow.Cells[2].Value.ToString();
            txt_nascimento.Text = dg_dados.CurrentRow.Cells[3].Value.ToString();
            txt_cidade.Text = dg_dados.CurrentRow.Cells[7].Value.ToString();
            txt_estado.Text = dg_dados.CurrentRow.Cells[9].Value.ToString();
            txt_endereco.Text = dg_dados.CurrentRow.Cells[5].Value.ToString();
            txt_numero.Text = dg_dados.CurrentRow.Cells[6].Value.ToString();
            txt_bairro.Text = dg_dados.CurrentRow.Cells[8].Value.ToString();
            txt_cep.Text = dg_dados.CurrentRow.Cells[4].Value.ToString();
            txt_telefone.Text = dg_dados.CurrentRow.Cells[10].Value.ToString();
            txt_email.Text = dg_dados.CurrentRow.Cells[11].Value.ToString();
        }

        //Método para editar os dados
        private void Editar(ClasseDados cliente) 
        {

            txt_nome.BackColor = Color.AliceBlue;
            txt_cpf.BackColor = Color.AliceBlue;
            txt_nascimento.BackColor = Color.AliceBlue;


            //--Verificando dados obrigatórios--
            //--Regras para salvar nome--
            //Não pode ser vazia, espaços em branco são desconsiderados
            //Precisa ter mais do que 10 caracteres contando com espaços em branco

            int cont = 0;

            if (txt_nome.Text.Trim() == string.Empty || txt_nome.Text.Length < 10)
            {
                txt_nome.BackColor = Color.DimGray;
                cont ++;
            }
            // cpf apenas considerei que esteja com todos os campos preenchidos
            //VALIDAÇÃO DE CPF PRECISA SER CONSTRUIDO
            if (!txt_cpf.MaskCompleted)
            {
                txt_cpf.BackColor = Color.DimGray;
                cont ++;
            }

            if (txt_nascimento.MaskCompleted) //verifica se foi preenchido o campo data de nascimento por completo
            {
                var aux = txt_nascimento.Text;
                Convert.ToDateTime(aux).ToString("yyyy/MM/dd");
                DateTime date = DateTime.Parse(aux);
                //---Regras para data da nascimento---
                //Tem que ser maior de 16 anos
                //tem que ter menos de 100 anos
                //precisa ter nascido antes de fazer o cadastro

                if (date >= DateTime.Now || (DateTime.Now.Year - date.Year) > 100 || (DateTime.Now.Year - date.Year) < 16)
                {
                    txt_nascimento.BackColor = Color.DimGray;
                    cont++;
                }
            }
            else
            {
                txt_nascimento.BackColor = Color.DimGray;
                cont++;
            }
           


            if (cont != 0) // CASO TENHA ERRO NOS DADOS, APARECE A MENSAGEM ERRO E NÃO É POSSIVEL SALVAR OS DADOS
                MessageBox.Show("Existem campos obrigatórios!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else//SALVAR DADOS CASO TUDO OK
            {
                ClientesBll clienteBll = new ClientesBll();

                cliente.Id = int.Parse(txt_id.Text);
                cliente.Cpf = txt_cpf.Text;
                cliente.Nome = txt_nome.Text;
                cliente.Nascimento = DateTime.Parse(txt_nascimento.Text);
                cliente.Cep = txt_cep.Text;
                cliente.Endereco = txt_endereco.Text;
                cliente.Numero = txt_numero.Text;
                cliente.Cidade = txt_cidade.Text;
                cliente.Bairro = txt_bairro.Text;
                cliente.Estado = txt_estado.Text;
                cliente.Telefone = txt_telefone.Text;
                cliente.Email = txt_email.Text;

                clienteBll.Editar(cliente);

                MessageBox.Show("Cadastro alterado com sucesso!");
                LimparCampos();
                Listar();
            }
        }

        private void Excluir(ClasseDados cliente)
        {
            ClientesBll clientesBll = new ClientesBll();
            cliente.Id = int.Parse(txt_id.Text);

            clientesBll.Excluir(cliente);

            MessageBox.Show("Cliente Excluido com sucesso!");
            LimparCampos();
            Listar();
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length != 0)
            {
                ClasseDados cliente = new ClasseDados();
                Editar(cliente);
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhum cadastro!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if(txt_id.Text.Length != 0)
            {
                ClasseDados cliente = new ClasseDados();
                Excluir(cliente);
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhum cadastro!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //EXIBIR INFORMAÇÕES AO PASSAR O MOUSE POR CIMA DO BOTÃO EXCLUIR 
        private void Button_excluir_MouseMove(object sender, MouseEventArgs e)
        {
            label_excluir.Text = "Para excluir o cadastro de um cliente,\n é necessário dar um duplo clique nos\ndados do cliente e logo em seguida\napertar o botão Excluir.";

        }

        private void Button_excluir_MouseLeave(object sender, EventArgs e)
        {
            label_excluir.Text = "";
        }

        //EXIBIR INFORMAÇÕES AO PASSAR O MOUSE POR CIMA DO BOTÃO EDITAR 
        private void Button2_MouseMove(object sender, MouseEventArgs e)
        {
            label_editar.Text = "Para editar o cadastro de um cliente,\né necessário dar um duplo clique nos\ndados do cliente, Fazer as alterações\ne depois apertar o botão Editar.";

        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            label_editar.Text = "";
        }

        //MÉTODO PARA CONSULTAR CEP
        private void Button_ConsultarCEP_Click(object sender, EventArgs e) 
        {
            if (!string.IsNullOrEmpty(txt_cep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txt_cep.Text.Trim());
                        txt_cidade.Text = endereco.cidade;
                        txt_estado.Text = endereco.uf;
                        txt_endereco.Text = endereco.end;
                        txt_bairro.Text = endereco.bairro;
                    }
                    catch(Exception erro)
                    {
                        MessageBox.Show(erro.Message,"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
