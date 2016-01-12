using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class frmJogoDaVelha : Form
    {
        public frmJogoDaVelha()
        {
            InitializeComponent();
            LimparBotoes();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lblLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }

        int[,] matriz = new int[3, 3];

        Boolean comeca = false;
        Boolean p1Joga = false;
        Boolean p2Joga = false;
        Boolean terminou = false;

        private void LimparBotoes()
        {
            if(comeca == false)
            {
                btn00.Enabled = false;
                btn01.Enabled = false;
                btn02.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn20.Enabled = false;
                btn21.Enabled = false;
                btn22.Enabled = false;
            }
            if(comeca == true)
            {
                btn00.Enabled = true;
                btn00.Text = "";
                btn01.Enabled = true;
                btn01.Text = "";
                btn02.Enabled = true;
                btn02.Text = "";
                btn10.Enabled = true;
                btn10.Text = "";
                btn11.Enabled = true;
                btn11.Text = "";
                btn12.Enabled = true;
                btn12.Text = "";
                btn20.Enabled = true;
                btn20.Text = "";
                btn21.Enabled = true;
                btn21.Text = "";
                btn22.Enabled = true;
                btn22.Text = "";
            }
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            comeca = true;
            LimparBotoes();
            LimparMatriz(matriz);
            if (rdX.Checked)
            {
                txbQuemJoga.Text = "Vez do jogador X";
                p1Joga = true;
                btnIniciar.Enabled = false;
            }
            if(rdY.Checked)
            {
                txbQuemJoga.Text = "Vez do jogador O";
                p2Joga = true;
                btnIniciar.Enabled = false;
            }
            rdX.Enabled = false;
            rdY.Enabled = false;
        }

        private int VezDeQuem()
        {
            //quem estiver ativado vai receber o número
            if(p1Joga == true)
            {
                return 1;
            }
            if(p2Joga == true)
            {
                return -1;
            }
            return 0;
        }

        private string LetraDeQuem()
        {
            //quem estiver ativado recebe sua letra
            if(p1Joga == true)
            {
                return "X";
            }
            if(p2Joga == true)
            {
                return "O";
            }
            return "";
        }

        private void MudaJogador(int numJogador)
        {
            //inverte quem estiver jogando para o outro
            if(numJogador == 1)
            {
                p1Joga = false;
                p2Joga = true;
            }
            if(numJogador == -1)
            {
                p2Joga = false;
                p1Joga = true;
            }
            

        }

        private void btn00_Click(object sender, EventArgs e)
        {
            //verifica quem joga (1 P1 || -1 P2)
            int jogadorDaVez = VezDeQuem();
            btn00.Text = LetraDeQuem();
            matriz[0,0] = jogadorDaVez;
            MudaJogador(jogadorDaVez);
            txbQuemJoga.Text = "Vez do jogador " + LetraDeQuem();
            btn00.Enabled = false;
            QuemGanhou();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            int jogadorDaVez = VezDeQuem();
            btn01.Text = LetraDeQuem();
            matriz[0, 1] = jogadorDaVez;
            MudaJogador(jogadorDaVez);
            txbQuemJoga.Text = "Vez do jogador " + LetraDeQuem();
            btn01.Enabled = false;
            QuemGanhou();
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            int jogadorDaVez = VezDeQuem();
            btn02.Text = LetraDeQuem();
            matriz[0, 2] = jogadorDaVez;
            MudaJogador(jogadorDaVez);
            txbQuemJoga.Text = "Vez do jogador " + LetraDeQuem();
            btn02.Enabled = false;
            QuemGanhou();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            int jogadorDaVez = VezDeQuem();
            btn10.Text = LetraDeQuem();
            matriz[1, 0] = jogadorDaVez;
            MudaJogador(jogadorDaVez);
            txbQuemJoga.Text = "Vez do jogador " + LetraDeQuem();
            btn10.Enabled = false;
            QuemGanhou();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            int jogadorDaVez = VezDeQuem();
            btn11.Text = LetraDeQuem();
            matriz[1, 1] = jogadorDaVez;
            MudaJogador(jogadorDaVez);
            txbQuemJoga.Text = "Vez do jogador " + LetraDeQuem();
            btn11.Enabled = false;
            QuemGanhou();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            int jogadorDaVez = VezDeQuem();
            btn12.Text = LetraDeQuem();
            matriz[1, 2] = jogadorDaVez;
            MudaJogador(jogadorDaVez);
            txbQuemJoga.Text = "Vez do jogador " + LetraDeQuem();
            btn12.Enabled = false;
            QuemGanhou();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            int jogadorDaVez = VezDeQuem();
            btn20.Text = LetraDeQuem();
            matriz[2, 0] = jogadorDaVez;
            MudaJogador(jogadorDaVez);
            txbQuemJoga.Text = "Vez do jogador " + LetraDeQuem();
            btn20.Enabled = false;
            QuemGanhou();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            int jogadorDaVez = VezDeQuem();
            btn21.Text = LetraDeQuem();
            matriz[2, 1] = jogadorDaVez;
            MudaJogador(jogadorDaVez);
            txbQuemJoga.Text = "Vez do jogador " + LetraDeQuem();
            btn21.Enabled = false;
            QuemGanhou();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            int jogadorDaVez = VezDeQuem();
            btn22.Text = LetraDeQuem();
            matriz[2, 2] = jogadorDaVez;
            MudaJogador(jogadorDaVez);
            txbQuemJoga.Text = "Vez do jogador " + LetraDeQuem();
            btn22.Enabled = false;
            QuemGanhou();
        }

        private void QuemGanhou()
        {
            if(Verificador.Geral(matriz) == 1)
            {
                terminou = true;
                Acabou();
                MessageBox.Show("Vencedor X");
            }
            else if(Verificador.Geral(matriz) == -1)
            {
                terminou = true;
                Acabou();
                MessageBox.Show("Vencedor O");
            }

            else
            {
                terminou = false;
                Acabou();
            }
        }

        private void Acabou()
        {
            if(terminou == true)
            {
                txbQuemJoga.Text = "Jogo Encerrado";
                btnIniciar.Enabled = true;
                btn00.Enabled = false;
                btn01.Enabled = false;
                btn02.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn20.Enabled = false;
                btn21.Enabled = false;
                btn22.Enabled = false;
                rdX.Enabled = true;
                rdY.Enabled = true;
            }
        }

        private void LimparMatriz(int[,] mat)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    mat[i, j] = 0;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://golfetto.16mb.com");
        }
    }
}
