using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormIphoneModelo : Form
    {
        IphoneModeloColecao colecaoIphone;
        IphoneModeloInfo infoIphone;
        ServicoNegocio negocioServ = new ServicoNegocio(Form1.Empresa.empconexao);
        IphoneModeloCorColecao colecaoCor;
        IphoneModeloCorColecao colecaoCorSelecionada;
        CodDescricaoColecao colecaoCores;
        int cod = 0;
       
        public FormIphoneModelo()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();

            comboBoxModelo.ValueMember = "iphmodid";
            comboBoxModelo.DisplayMember = "iphmoddescricao";
        }

        private void FormIphoneModelo_Load(object sender, EventArgs e)
        {
            colecaoCores = negocioServ.ConsultarIphoneCorColecao();
            colecaoIphone = Form1.IphoneColecao;
            colecaoCor = Form1.IphoneCorColecao;
            comboBoxModelo.DataSource = colecaoIphone;
            comboBoxModelo.SelectedIndex = -1;
            cod = 1;

        }

        private void ComboBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            colecaoCorSelecionada = new IphoneModeloCorColecao();

            if (cod > 0)
            {
                int dex = Convert.ToInt32(comboBoxModelo.SelectedValue);

                foreach (IphoneModeloInfo phone in colecaoIphone)
                {
                    if (dex == phone.iphmodid)
                    {
                        infoIphone = phone;
                        break;
                    }
                }

                foreach (IphoneModeloCorInfo cor in colecaoCor)
                {
                    if (cor.modcoridiphone == infoIphone.iphmodid)
                        colecaoCorSelecionada.Add(cor);
                }



                labelTitle.Text = infoIphone.iphmoddescricao;
                textBoxDetalhes.Text = infoIphone.iphmoddetalhes;
                textBoxAno.Text = infoIphone.iphmodlancamento.ToString();
                textBoxDimensoes.Text = strConver(infoIphone.iphmodpesodimensoes);
                textBoxTela.Text = strConver(infoIphone.iphmodtela);
                textBoxCameraT.Text = strConver(infoIphone.iphmodcameratraseira);
                textBoxCamF.Text = strConver(infoIphone.iphmodcamerafrontal);
                textBoxTv.Text = strConver(infoIphone.iphmodtvvideo);
                textBoxControle.Text = strConver(infoIphone.iphmodbotoescontroles);
                textBoxEnergia.Text = strConver(infoIphone.iphmodenergiabateria);
                textBoxSensores.Text = strConver(infoIphone.iphmodsensores);
                textBoxCaixa.Text = strConver(infoIphone.iphmodconteudocaixa);
                textBoxGravacao.Text = strConver(infoIphone.iphmodgravacao);

                comboBoxNumMod.Text = string.Empty;
                comboBoxCapacidade.Text = string.Empty;
                comboBoxCor.Text = string.Empty;

                comboBoxNumMod.Items.Clear();
                comboBoxCapacidade.Items.Clear();
                comboBoxCor.Items.Clear();

                comboBoxNumMod.Items.AddRange(infoIphone.iphmodnum);
                comboBoxCapacidade.Items.AddRange(infoIphone.iphmodcapacidade);
                comboBoxCor.Items.AddRange(infoIphone.iphmodcor);

                panelPrincipal.Enabled = true;
                ConvertImagem(infoIphone.iphmodfoto);
            }
        }

        private void ConvertImagem(byte[] foto)
        {
            if (foto != null)
            {
                MemoryStream memoryStream = new MemoryStream(foto);
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
            else
                pictureBox1.Image = null;
        }

        private string strConver(string[] texto)
        {
            string novotxt = string.Empty;

            foreach (string txt in texto)
                novotxt += " - " + txt + Environment.NewLine;

            return novotxt;
        }

        private void ComboBoxCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (IphoneModeloCorInfo cor in colecaoCorSelecionada)
            {
                if (comboBoxCor.Text == cor.iphcordescricao)
                {
                    ConvertImagem(cor.modcorfoto);
                    break;
                }
            }
        }
    }
}
