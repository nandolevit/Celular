using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class IphoneDefeitoInfo
    {
        public int iphdefid { get; set; }
        public int iphdefidaparelho { get; set; }
        public string iphdefdefeito { get; set; }
        public string iphdefobs { get; set; }
        public string iphdeftouchdisplay { get; set; }
        public string iphdefcamfrontal { get; set; }
        public string iphdefsensorprox { get; set; }
        public string iphdefhome { get; set; }
        public string iphdefautofrontal { get; set; }
        public string iphdefconector { get; set; }
        public string iphdeffone { get; set; }
        public string iphdefautointerno { get; set; }
        public string iphdefmicrofone { get; set; }
        public string iphdefparafuso { get; set; }
        public string iphdefcarcaca { get; set; }
        public string iphdefcamtraseira { get; set; }
        public string iphdefmicrofonetraseiro { get; set; }
        public string iphdefflash { get; set; }

        public override string ToString()
        {
            string descricao = string.Empty;

            descricao += string.IsNullOrEmpty(iphdeftouchdisplay) ? "" : "**Touch/Display: " + iphdeftouchdisplay + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefcamfrontal) ? "" : "**Câmera frontal: " + iphdefcamfrontal + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefsensorprox) ? "" : "**Sensor de proximidade: " + iphdefsensorprox + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefhome) ? "" : "**Botão home/Touch ID: " + iphdefhome + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefautofrontal) ? "" : "**Auto-falante frontal: " + iphdefautofrontal + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefconector) ? "" : "**Conector Lightning: " + iphdefconector + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdeffone) ? "" : "**Miniconector de fone de ouvido: " + iphdeffone + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefautointerno) ? "" : "**Auto-falante interno: " + iphdefautointerno + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefmicrofone) ? "" : "**Microfone: " + iphdefmicrofone + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefparafuso) ? "" : "**Parafuso da carcaça: " + iphdefparafuso + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefcarcaca) ? "" : "**Estado da carcaça: " + iphdefcarcaca + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefcamtraseira) ? "" : "**Câmera traseira: " + iphdefcamtraseira + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefmicrofonetraseiro) ? "" : "**Microfone traseiro: " + iphdefmicrofonetraseiro + Environment.NewLine;
            descricao += string.IsNullOrEmpty(iphdefflash) ? "" : "**Flash: " + iphdefflash;

            return descricao;
        }
    }
}
