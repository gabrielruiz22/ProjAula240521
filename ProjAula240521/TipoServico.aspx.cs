using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjAula240521
{
    public partial class TipoServico : System.Web.UI.Page
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
            string nomeTipoServico = txtNomeTpServico.Text;
            decimal valorTipoServico = Decimal.Parse(txtValorTpServico.Text);
            string descricaoTipoServico = txtDescricaoTpServico.Text;

            TB_TIPO_SERVICO tp = new TB_TIPO_SERVICO()
            {
                nome = nomeTipoServico,
                valor = valorTipoServico,
                descricao = descricaoTipoServico
            };

            PrestacaoDeServicosEntities contextTipoServico = new PrestacaoDeServicosEntities();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextTipoServico.TB_TIPO_SERVICO.Add(tp);
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

            contextTipoServico.SaveChanges();
        }

        private void Clear()
        {
            txtNomeTpServico.Text = "";
            txtValorTpServico.Text  = "";
            txtDescricaoTpServico.Text = "";
            txtNomeTpServico.Focus();
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
