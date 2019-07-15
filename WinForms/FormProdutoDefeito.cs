using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ObjTransfer;
using Negocios;

namespace WinForms
{
    public partial class FormProdutoDefeito : Form
    {
        Form1 form1 = new Form1();
        ServicoNegocio negocioServ = new ServicoNegocio(Form1.Empresa.empconexao);
        //public string DefeitoInfo { get; set; }

        Thread thread;
        ClienteInfo infoCliente;
        AparelhoColecao colecaoAparelho;
        IphoneCelularInfo infoCelular;
        AparelhoInfo infoAparelho;
        public string[] desc = new string[4];

        public FormProdutoDefeito(ClienteInfo cliente)
        {
            Inicializar();
            infoCliente = cliente;

            thread = new Thread(ConsultarAparelhoCliente);
            form1.ExecutarThread(thread, progressBar1, labelBarra);
            
        }

        public FormProdutoDefeito(IphoneCelularInfo phone)
        {
            Inicializar();
            infoCelular = phone;

            thread = new Thread(ConsultarAparelho);
            form1.ExecutarThread(thread, progressBar1, labelBarra);

            if (infoCelular != null)
            {
                textBoxCodProd.Text = string.Format("{0:0000}", infoAparelho.apaid);
                textBoxProdDescricao.Text = infoAparelho.apadescricao;
            }

        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonSalvar;
            textBoxCodProd.Select();

        }

        private void ConsultarAparelho()
        {
            infoAparelho = negocioServ.ConsultarAparelhoId(infoCelular.celid);
            Form1.encerrarThread = true;
        }

        private void ConsultarAparelhoCliente()
        {
            colecaoAparelho = negocioServ.ConsultarAparelhoClienteId(infoCliente.cliid);
            textBoxDefeito.Select();
            Form1.encerrarThread = true;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBoxDefeito.Text.Trim()) || string.IsNullOrEmpty(textBoxCodProd.Text)))
            {
                desc[0] = textBoxProdDescricao.Text;
                desc[1] = textBoxDefeito.Text;
                desc[2] = textBoxCodProd.Text;

                this.DialogResult = DialogResult.Yes;
            }
            else
                FormMessage.ShowMessegeWarning("Informar o eletrodoméstico e o defeito do aparelho!");
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarTipoServId(string id)
        {
            if (int.TryParse(id, out int cod))
            {
                //TipoServInfo tipoServInfo = servicoNegocio.ConsultarTipoServId(cod);

                //if (tipoServInfo != null)
                //{
                //    textBoxCodTipo.Text = string.Format("{0:000}", tipoServInfo.TipId);
                //    labelTipoDescricao.Text = tipoServInfo.TipDescricao;
                //}
                //else
                //    ConsultarTipoServId("1");
            }
            else
            {
                FormMessage.ShowMessegeWarning("Insira um valor numérico!");
                ConsultarTipoServId("1");
            }
        }

        private void buttonBuscarEletro_Click(object sender, EventArgs e)
        {
            AbrirConsultaEletro();
        }

        private void AbrirConsultaEletro()
        {
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            //if (colecaoEletro != null)
            //{
            //    foreach (ProdEletroInfo eletro in colecaoEletro)
            //    {
            //        Form_Consultar form_Consultar = new Form_Consultar
            //        {
            //            Cod = string.Format("{0:000}", eletro.idCadEle),
            //            Descricao = eletro.descricao
            //        };

            //        form_ConsultarColecao.Add(form_Consultar);
            //    }

            //    FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Lista de produtos...");
            //    formConsultar_Cod_Descricao.ShowDialog(this);

            //    if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            //    {
            //        textBoxCodProd.Text = formConsultar_Cod_Descricao.Selecionado.Cod;
            //        textBoxProdDescricao.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
            //        textBoxDefeito.Select();
            //    }

            //    formConsultar_Cod_Descricao.Dispose();
            //}
            //else
            //    AbrirCadEletro();
        }


        private void FormProdutoDefeito_Load(object sender, EventArgs e)
        {
            //if (colecaoEletro == null)
            //    AbrirCadEletro();
            //else
            //{
            //    if (colecaoEletro.Count > 1)
            //        AbrirConsultaEletro();
            //    else
            //    {
            //        textBoxCodProd.Text = string.Format("{0:000}", colecaoEletro[0].idCadEle);
            //        textBoxProdDescricao.Text = colecaoEletro[0].descricao;
            //        textBoxDefeito.Select();
            //    }
            //}
        }
    }
}
