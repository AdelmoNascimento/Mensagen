using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mensagem de programadores com preguiça ou falta de conhecimento
            //MessageBox.Show("Texto Qualquer!");
            /*
             * Exibe uma mensagem com texto, legenda, botões e
             * icones especificados. Caption: O texto
             * a ser exibido na barra de titulo a Caixa de Mensagem.
             */
            //Primeira forma de fazer
            //DialogResult OnclickUser = new DialogResult();
            //OnclickUser = MessageBox.Show("Preste Atenção esta Mensagem!", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //if(OnclickUser == DialogResult.OK)
            //{
            //    MessageBox.Show("Você Pressionou o botão OK!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}

            //Segunda forma de fazer com poucas linhas de código
            if (MessageBox.Show("Preste Atenção esta Mensagem!", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                MessageBox.Show("Você Pressionou o botão OK!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                     
        }
    }
}
