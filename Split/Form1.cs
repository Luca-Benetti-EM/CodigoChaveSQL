using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Split
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var codigos = Regex.Split(txtColunaA.Text, "\r\n|\r|\n").ToList();

            var descricao = Regex.Split(txtColunaB.Text, "\r\n|\r|\n").ToList();

            var codigoDescricao = codigos.Zip(descricao, (first, second) => new { Codigo = first, Descricao = second }).ToList();

            string sql = string.Empty;

            foreach (var item in codigoDescricao)
            {
                sql += $"--#start\nUPDATE TBCIDADE\nSET CIDACODIGOIBGE ={item.Codigo}\nWHERE CIDADESCRICAO = '{item.Descricao}'\n--#end\n";
            }

            txtColunaC.Text = sql;

            var charsetPadrao = Encoding.Default;
            var bytesPadrao = charsetPadrao.GetBytes(sql);
            var utf8 = Encoding.UTF8;
            var bytesUtf8 = Encoding.Convert(charsetPadrao, utf8, bytesPadrao);
            sql = utf8.GetString(bytesUtf8);

            System.IO.File.WriteAllText(@"C:\Users\Luca\source\repos\PDFToText\insercao.sql", sql, Encoding.UTF8);
        }

        public string GetStringFormatada(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            var acentos = "çÇáéíóúýÁÉÍÓÚÝàèìòùÀÈÌÒÙãõñäëïöüÿÄËÏÖÜÃÕÑâêîôûÂÊÎÔÛºª°ø§";
            var semAcento = "cCaeiouyAEIOUYaeiouAEIOUaonaeiouyAEIOUAONaeiouAEIOU     ";

            for (var i = 0; i < acentos.Length; i++)
            {
                str = str.Replace(acentos[i], semAcento[i]);
            }

            return str.ToUpper();
        }
    }
}
