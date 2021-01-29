using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Data;
using RPG_Euphoria.Models;

namespace RPG_Euphoria.Dados
{
    public class ArmadurasDAO
    {
        #region Members
        private static string cs = ConfigurationManager.ConnectionStrings["SQLConnectString"].ConnectionString;
        private SqlConnection con = new SqlConnection(cs);
        private SqlDataReader reader = null;
        private ParametroDAO parametro = new ParametroDAO();
        #endregion

        #region Carrega Grid
        public void carregaGridProtecao(GridView dataGrid)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                String query = parametro.ConsultarParametro("procedureConsultaArmaduraDurabilidade");
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt != null && dt.Rows.Count > 0)
                {
                    renomaValoresDataTable(dt);
                    renomeaColunasDataTable(dt);
                    dataGrid.DataSource = dt;
                    dataGrid.ShowHeader = true;
                    dataGrid.DataBind();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }

        }
        #endregion

        #region AdicionaArmadura
        public int AdicionaArmadura(Armadura armad)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();

                #region Monta a query
                String query = parametro.ConsultarParametro("procedureAdicionarArma") + " @nome ,@tipo ,@custo ,@ca ,@furtv ,@forca ,@peso ,@durabilidade ,@observacao";
                SqlCommand cmd = new SqlCommand(query, con);

                #region Insere os parametros
                SqlParameter nome = new SqlParameter();
                nome.ParameterName = "nome";
                nome.Value = armad.nome;

                SqlParameter tipo = new SqlParameter();
                tipo.ParameterName = "tipo";
                tipo.SqlDbType = SqlDbType.Int;
                tipo.Value = armad.tipo;

                SqlParameter custo = new SqlParameter();
                custo.ParameterName = "custo";
                custo.SqlDbType = SqlDbType.Int;
                custo.Value = armad.custo;

                SqlParameter ca = new SqlParameter();
                ca.ParameterName = "ca";
                ca.Value = armad.ca;

                SqlParameter furtv = new SqlParameter();
                furtv.ParameterName = "furtv";
                furtv.Value = armad.furtv;

                SqlParameter peso = new SqlParameter();
                peso.ParameterName = "peso";
                peso.Value = armad.peso;

                SqlParameter forca = new SqlParameter();
                forca.ParameterName = "forca";
                forca.Value = armad.forca;

                SqlParameter durabilidade = new SqlParameter();
                durabilidade.ParameterName = "durabilidade";
                durabilidade.SqlDbType = SqlDbType.Int;
                durabilidade.Value = armad.durabilidade;

                SqlParameter observacao = new SqlParameter();
                observacao.ParameterName = "observacao";
                observacao.Value = armad.observacao;
                #endregion



                cmd.Parameters.Add(nome);
                #endregion


                reader = cmd.ExecuteReader();
                dt.Load(reader);

                //Validação para retorno de mensagem em tela
                if (dt != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }

        }
        #endregion

        #region ExcluirArmadura
        public int ExcluirArmadura(GridView grid, string nomeArma)
        {
            try
            {
                DataTable dtExcluir = grid.DataSource as DataTable;

                con.Open();

                String query = parametro.ConsultarParametro("procedureExcluirArmadura") + " @ID";
                SqlCommand cmd = new SqlCommand(query, con);

                foreach (DataRow row in dtExcluir.Rows)
                {
                    if (row["Nome da Arma"].ToString() == nomeArma)
                    {
                        int id = int.Parse(row["ID"].ToString());
                        SqlParameter ID = new SqlParameter();
                        ID.ParameterName = "@ID";
                        ID.Value = id;
                        ID.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(ID);
                        reader = cmd.ExecuteReader();
                        break;
                    }
                    else
                    {
                        reader = null;
                    }
                }

                if (reader != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
        #endregion

        #region PesquisarArma
        public GridView PesquisarArma(GridView grid, string nomeArma)
        {
            try
            {
                DataTable dt = grid.DataSource as DataTable;

                con.Open();

                String query = parametro.ConsultarParametro("procedurePesquisarArma") + " @ID";
                SqlCommand cmd = new SqlCommand(query, con);

                foreach (DataRow row in dt.Rows)
                {
                    if (row["Nome da Arma"].ToString() == nomeArma)
                    {
                        int id = int.Parse(row["ID"].ToString());
                        SqlParameter ID = new SqlParameter();
                        ID.ParameterName = "@ID";
                        ID.Value = id;
                        ID.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(ID);
                        reader = cmd.ExecuteReader();
                        break;
                    }
                }


                dt = new DataTable();
                dt.Load(reader);

                if (dt != null && dt.Rows.Count > 0)
                {
                    renomaValoresDataTable(dt);
                    renomeaColunasDataTable(dt);
                    grid.DataSource = dt;
                    grid.ShowHeader = true;
                    grid.DataBind();

                    return grid;
                }
                else
                {
                    return grid;
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
        #endregion

        private void renomaValoresDataTable(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                string value = row["observacao_arma"].ToString();

                if (value == "Armas Pequenas")
                {
                    value = "Arma de Fogo Pequena";
                    row["observacao_arma"] = value;
                }
                else if (value == "Armas Grandes")
                {
                    value = "Arma de Fogo Grande";
                    row["observacao_arma"] = value;
                }
            }
        }

        private void renomeaColunasDataTable(DataTable dt)
        {
            dt.Columns["ID"].ColumnName = "ID";
            dt.Columns["nome_arma"].ColumnName = "Nome da Arma";
            dt.Columns["custo_arma"].ColumnName = "Preço";
            dt.Columns["dano_arma"].ColumnName = "Dado de Dano";
            dt.Columns["tipo_de_dano_arma"].ColumnName = "Tipo de Dano";
            dt.Columns["peso_arma"].ColumnName = "Peso";
            dt.Columns["propriedade_arma"].ColumnName = "Propriedades";
            dt.Columns["nome_municao"].ColumnName = "Nome Completo Municão";
            dt.Columns["custo_municao"].ColumnName = "Preço da Munição";
            dt.Columns["calibre_municao"].ColumnName = "Calibre";
            dt.Columns["quantidade_municao"].ColumnName = "Quantidade por Caixa";
            dt.Columns["observacao_municao"].ColumnName = "Informações Adicionais";
            dt.Columns["observacao_arma"].ColumnName = "Tipo da Arma";
            dt.Columns["durabiliade_arma"].ColumnName = "Estado de Durabilidade da Arma";

        }

    }
}
