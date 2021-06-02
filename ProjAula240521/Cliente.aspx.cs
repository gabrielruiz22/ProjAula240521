using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjAula240521
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!IsPostBack)
            {
                CarregarDadosPagina();
            }*/
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNomeCliente.Text;
            string cpfCliente = txtCpfCliente.Text;
            string cidadeCliente = txtCidadeCliente.Text;
            string enderecoCliente = txtEnderecoCliente.Text;
            string telefoneCliente = txtTelefoneCliente.Text;
            
            TB_CLIENTE c = new TB_CLIENTE()
            {
                nome = nomeCliente,
                cpf = cpfCliente,
                cidade = cidadeCliente,
                endereco = enderecoCliente,
                telefone = telefoneCliente
            };
            
            PrestacaoDeServicosEntities contextCliente = new PrestacaoDeServicosEntities();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextCliente.TB_CLIENTE.Add(c);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            /*else
            {
                int id = Convert.ToInt32(valor);
                TB_CLIENTE cliente = contextCliente.TB_CLIENTE.First(c => c.id == id);
                viagem.descricao = v.descricao;
                viagem.data = v.data;
                lblmsg.Text = "Registro alterado!";
            }*/

            contextCliente.SaveChanges();
        }

        private void Clear()
        {
            txtNomeCliente.Text = "";
            txtCpfCliente.Text = "";
            txtCidadeCliente.Text = "";
            txtEnderecoCliente.Text = "";
            txtTelefoneCliente.Text = "";
            txtNomeCliente.Focus();
        }

       /*private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;

            TB_CLIENTE cliente = new TB_CLIENTE();
            PrestacaoDeServicosEntities contextCliente = new PrestacaoDeServicosEntities();

            if (!String.IsNullOrEmpty(valor))
            {
                idItem = Convert.ToInt32(valor);
                cliente = contextCliente.TB_CLIENTE.First(c => c.id == idItem);

                txtDescricao.Text = viagem.descricao;
                txtdata.Text = viagem.data.ToString();
            }
        }*/
    }
}