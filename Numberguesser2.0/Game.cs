using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numberguesser2._0
{
    public partial class Game : Form
    {

        public Game(string NamePlayer)
        {
            InitializeComponent();
            //Determina o nome do jogador na tela e deixa o jogo em modo inicial
            lblNome.Text = NamePlayer;
            Reset();

        }
        //Random é criado junto a variavel que armazena o numero aleatorio
        Random random = new Random();
        int correctNumber;

        //Função reset é criada (Serve para deixar o jogo em modo inicial)
        public void Reset()
        {
            //Jogo é resetado, um novo numero aleatorio é escolhido
            lbl12.Visible = false;
            lblMensagem.Text = "Tente adivinhar o numero entre 1 e 10";
            correctNumber = random.Next(1, 10);
            errors = 0;
            //A opção de apertar nos botoes de 3 a 10 é habilitado
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
        }
        //Variáveis, que armazena o numero escolhido pelo usuario e a quantidade de erros
        int guess;
        int errors;

        //Função que da funcionamento ao jogo
        public void Playing()
        {
            //Verifica se o numero escolhido é o correto
            if (guess == correctNumber)
            {
                //Mensagem de parabenização e de jogar novamente aparecem
                lblMensagem.Text = "Parabens! Você acertou o numero secreto";
                lbl12.Visible = true;
                //valor da variavel é alterado para seleção de um novo jogo
                guess = 11;
                //A opção de apertar nos botoes de 3 a 10 é desabilitado
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
            }
            //Caso o numero for o errado
            else
            {
                errors = errors + 1;
                //Verifica se é o primeiro erro
                if(errors <= 1)
                {
                    lblMensagem.Text = "Errou, tente novamente";
                }
                //Caso exista mais de um erro, um contador ira iniciar
                else
                {
                    lblMensagem.Text = "Errou de novo, numero de erros: " + errors;
                }
                
                
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Caso o jogo tenha terminado, ao apertar 1, o jogo ira resetar
            if (guess == 11)
            {
                guess = 0;
                Reset();
            }
            //Caso o jogo esteja rolando, sera varificado o numero pressionado
            else
            {
                guess = 1;
                Playing();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Caso o jogo tenha terminado, ao apertar 2, o jogo retornara ao menu de seleção de nome
            if (guess == 11)
            {
                this.Close();
            }
            ////Caso o jogo esteja rolando, sera varificado o numero pressionado
            guess = 2;
            Playing();
        }
        //Verifica o botao apertado, e envia o valor a função Playing (valido ate o fim do codigo)
        private void btn3_Click(object sender, EventArgs e)
        {
            guess = 3;
            Playing();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            guess = 4;
            Playing();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            guess = 5;
            Playing();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            guess = 6;
            Playing();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            guess = 7;
            Playing();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            guess = 8;
            Playing();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            guess = 9;
            Playing();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            guess = 10;
            Playing();
        }
    }
}
