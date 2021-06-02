using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjAula240521
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            PrestacaoDeServicosEntities context = new PrestacaoDeServicosEntities();
            List<TB_SERVICO> lstServico= context.TB_SERVICO.ToList<TB_SERVICO>();

            GVServico.DataSource = lstServico;
            GVServico.DataBind();
        }

        protected void GVServico_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            PrestacaoDeServicosEntities contextServico = new PrestacaoDeServicosEntities();
            TB_SERVICO servico = new TB_SERVICO();

            servico = contextServico.TB_SERVICO.First(c => c.ID == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("Viagem.aspx?idItem=" + idItem);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextServico.TB_SERVICO.Remove(servico);
                contextServico.SaveChanges();
                string msg = "Servico excluida com sucesso!";
                string titulo = "Informacao";
                CarregarLista();
                DisplayAlert(titulo, msg, this);
            }
        }

        public void DisplayAlert(string titulo, string mensagem, System.Web.UI.Page page)
        {
            h1.InnerText = titulo;
            lblMsgPopup.InnerText = mensagem;
            ClientScript.RegisterStartupScript(typeof(Page), Guid.NewGuid().ToString(), "MostrarPopupMensagem();", true);
        }

        protected void GVServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}