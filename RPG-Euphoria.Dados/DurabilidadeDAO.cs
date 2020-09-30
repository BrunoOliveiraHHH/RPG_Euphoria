using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using RPG_Euphoria;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace RPG_Euphoria.Dados
{
    public class DurabilidadeDAO
    {
        private static string cs = ConfigurationManager.ConnectionStrings["SQLConnectString"].ConnectionString;
        private SqlConnection con = new SqlConnection(cs);
        private ParametroDAO parametro = new ParametroDAO();
        
        public void ListarDurabilidades(DropDownList comboBox)
        {
            con.Open();
            DataSet ds = new DataSet();

            String query = parametro.ConsultarParametro("procedureListarDurabilidade");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            comboBox.DataTextField = "descricao";
            comboBox.DataValueField = "id_durabilidade";
            comboBox.DataSource = ds.Tables[0];
            comboBox.DataBind();
            comboBox.Items.Insert(0, new ListItem("Selecione","0"));
            con.Close();
        }

        public void GridDurabilidade(GridView dataGrid) 
        {
            con.Open();
            DataSet ds = new DataSet();
            String query = parametro.ConsultarParametro("procedureListarDurabilidade");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            dt.Columns.Remove("id_durabilidade");
            dt.Columns["descricao"].ColumnName = "Descrição";

            dataGrid.DataSource = dt;
            dataGrid.ShowHeader = true;
            dataGrid.DataBind();
            con.Close();
        
        }
    }
}
