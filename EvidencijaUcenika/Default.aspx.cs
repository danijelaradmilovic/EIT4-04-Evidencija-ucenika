using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvidencijaUcenika
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ucenici SviUcenici = new Ucenici();
            if (!IsPostBack)
            {
                ddlRazred.Items.Add("");
                for (var i = 0; i < SviUcenici.razredi.Count; i++)
                {
                    ddlRazred.Items.Add(SviUcenici.razredi.ElementAt(i));
                }

            }
        }

        protected void btnPretraga_Click(object sender, EventArgs e)
        {
            Ucenici SviUcenici = new Ucenici();

            Parametri parametri = new Parametri();
            parametri.Ime = txtIme.Text;
            parametri.Prezime = txtPrezime.Text;
            parametri.Razred = ddlRazred.SelectedItem.Text;

            GridView1.DataSource = SviUcenici.Pretraga(parametri);
            GridView1.DataBind();
        }
    }
}
