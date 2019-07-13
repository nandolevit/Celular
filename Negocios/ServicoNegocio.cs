using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjTransfer;
using AccessDB;
using System.Data;

namespace Negocios
{
    public class ServicoNegocio
    {
        private static string EmpConexao { get; set; }

        public ServicoNegocio(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public IphoneModeloCorColecao ConsultarIphoneModeloCorFoto()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarIphoneModeloCorFoto");

                if (dataTable != null)
                {
                    IphoneModeloCorColecao colecao = new IphoneModeloCorColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        IphoneModeloCorInfo cor = new IphoneModeloCorInfo
                        {
                            modcorfoto = DBNull.Value.Equals(row["modcorfoto"]) ? null : (byte[])row["modcorfoto"],
                            modcorid = Convert.ToInt32(row["modcorid"]),
                            modcoridcor = Convert.ToInt32(row["modcoridcor"]),
                            modcoridiphone = Convert.ToInt32(row["modcoridiphone"]),
                            iphcordescricao = Convert.ToString(row["iphcordescricao"])
                        };

                        colecao.Add(cor);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;

        }
        public int UpdateFotoIphoneModelo(IphoneModeloCorInfo cor)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@phone", cor.modcoridiphone);
                accessDbMySql.AddParametrosMySql("@foto", cor.modcorfoto);

                return accessDbMySql.ExecutarScalarMySql("spUpdateFotoIphoneModelo");
            }
            else
                return 0;
        }

        public int InsertIphoneModeloCor(IphoneModeloCorInfo cor)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@phone", cor.modcoridiphone);
                accessDbMySql.AddParametrosMySql("@cor", cor.modcoridcor);
                accessDbMySql.AddParametrosMySql("@foto", cor.modcorfoto);

                return accessDbMySql.ExecutarScalarMySql("spInsertIphoneModeloCor");
            }
            else
                return 0;
        }

        public CodDescricaoColecao ConsultarIphoneCorColecao()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarIphoneCor");

                if (dataTable != null)
                {
                    CodDescricaoColecao colecao = new CodDescricaoColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        CodDescricaoInfo cod = new CodDescricaoInfo
                        {
                            cod = Convert.ToInt32(row["iphcorid"]),
                             descricao = Convert.ToString(row["iphcordescricao"])
                        };

                        colecao.Add(cod);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;

        }

        public IphoneModeloColecao ConsultarIphoneColecao()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarIphoneColecao");

                if (dataTable != null)
                    return PreencherIphone(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public IphoneModeloInfo ConsultarIphoneId(string id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@cod", id);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarIphoneId");

                if (dataTable != null)
                    return PreencherIphone(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public IphoneModeloColecao PreencherIphone(DataTable dataTable)
        {
            IphoneModeloColecao colecao = new IphoneModeloColecao();
            foreach (DataRow iphone in dataTable.Rows)
            {
                IphoneModeloInfo phone = new IphoneModeloInfo
                {
                    iphmodbotoescontroles = Convert.ToString(iphone["iphmodbotoescontroles"]).Split(';'),
                    iphmodcamerafrontal = Convert.ToString(iphone["iphmodcamerafrontal"]).Split(';'),
                    iphmodcameratraseira = Convert.ToString(iphone["iphmodcameratraseira"]).Split(';'),
                    iphmodcapacidade = Convert.ToString(iphone["iphmodcapacidade"]).Split(';'),
                    iphmodconteudocaixa = Convert.ToString(iphone["iphmodconteudocaixa"]).Split(';'),
                    iphmodcor = Convert.ToString(iphone["iphmodcor"]).Split(';'),
                    iphmoddetalhes = Convert.ToString(iphone["iphmoddetalhes"]),
                    iphmodenergiabateria = Convert.ToString(iphone["iphmodenergiabateria"]).Split(';'),
                    iphmodgravacao = Convert.ToString(iphone["iphmodgravacao"]).Split(';'),
                    iphmodid = Convert.ToInt32(iphone["iphmodid"]),
                    iphmodlancamento = Convert.ToInt32(iphone["iphmodlancamento"]),
                    iphmodnum = Convert.ToString(iphone["iphmodnum"]).Split(';'),
                    iphmodpesodimensoes = Convert.ToString(iphone["iphmodpesodimensoes"]).Split(';'),
                    iphmodresistente = Convert.ToString(iphone["iphmodresistente"]).Split(';'),
                    iphmodsensores = Convert.ToString(iphone["iphmodsensores"]).Split(';'),
                    iphmodtela = Convert.ToString(iphone["iphmodtela"]).Split(';'),
                    iphmodtvvideo = Convert.ToString(iphone["iphmodtvvideo"]).Split(';'),
                    iphmoddescricao = Convert.ToString(iphone["iphmoddescricao"]),
                    iphmodfoto = DBNull.Value.Equals(iphone["iphmodfoto"]) ? null : (byte[])iphone["iphmodfoto"]
                };
                colecao.Add(phone);
            }

            return colecao;
        }
    }
}
