using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAIXAELETRÔNICO_Paloma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void qtdMenor (int valor) // procedimento qtdMenor 
        {
            float nota500 = 0, nota100 = 0, nota40 = 0, nota25 = 0, nota10 = 0, nota5 = 0, nota4 = 0, nota3 = 0; //declaração das variaveis

                while (valor >= 500 && valor != 501 && valor != 502) // enquanto o valor for >= 500 e dif. dos terminados em 1 e 2
                {
                    valor = valor - 500; // valor =- 500 // o valor vai receber ele mesmo menos 500
                    nota500++; // e então a nota vai receber +1
                    lbl500.Text = Convert.ToString(nota500); // e o valor vai ser jogado na label
                }  // EX se o valor for 1000 ele vai voltar e repetir pois o valor restante é >= 500  
                while (valor >= 100 && valor != 101 && valor != 102)
                {
                    valor = valor - 100;
                    nota100++;
                    lbl100.Text = Convert.ToString(nota100);
                }
                while (valor >= 40 && valor != 41 && valor != 42)
                {
                    valor = valor - 40;
                    nota40++;
                    lbl40.Text = Convert.ToString(nota40);
                }
                while (valor >= 25 && valor != 26 && valor != 27)
                {
                    valor = valor - 25;
                    nota25++;
                    lbl25.Text = Convert.ToString(nota25);
                }
                while (valor >= 10 && valor != 11 && valor != 12)
                {
                    valor = valor - 10;
                    nota10++;
                    lbl10.Text = Convert.ToString(nota10);
                }
                while (valor >= 5 && valor != 6 && valor != 7)
                {
                    valor = valor - 5;
                    nota5++;
                    lbl5.Text = Convert.ToString(nota5);
                }
                while (valor >= 4 && valor != 6)
                {
                    valor = valor - 4;
                    nota4++;
                    lbl4.Text = Convert.ToString(nota4);
                }
                while (valor >= 3)
                {
                    valor = valor - 3;
                    nota3++;
                    lbl3.Text = Convert.ToString(nota3);
                } 
        }

        private void rBMenorQuantidade_CheckedChanged(object sender, EventArgs e) // procedimento do radio button
        {
            if (txtValor.Text != "") //se campo estiver preenchido
            {
                if (rBMenorQuantidade.Checked == true) //se o radiobutton estiver checado
                {
                    limparNotas(); //limpa as labels 'notas'

                    if (float.Parse(txtValor.Text) < 3) //se o valor for menor que 3
                    {
                        MessageBox.Show("Saque Insuficiente. Insira um valor maior que 2!");
                    }
                    else //se não
                    {
                        qtdMenor(Convert.ToInt32(txtValor.Text)); //ai sim chama a variavel
                    }
                }
            }
            else //se estiver em branco
            {
                MessageBox.Show("Campo em Branco! Preencha-o.");
            }     
        }

        void qtdMaior(int valor) // procedimento qtdMaior
        {
           int total = 0, nota3 = 0, nota4 = 0, nota5 = 0, nota10 = 0, nota25 = 0, nota40 = 0, nota100 = 0, nota500 = 0; // declaração das variaveis
           while (total < valor) // enquanto o total (que é inicializado com 0) for menor q o valor do usuário
            {
                if (total < valor) // se total for menor que o valor do usuário
                {
                    total = total + 3; // então total recebe ele mesmo + 3
                    nota3++; // a nota de 3 recebe 1
                }
                if (total > valor) // se o total (q agr vale 3) for maior que o valor do usuario
                {
                    total = total - 3; // então total recebe ele mesmo - 3
                    nota3--; // e uma nota de 3 é retirada, pois o total não pode ser maior que o valor
                }

                if (total < valor)
                {
                    total = total + 4;
                    nota4++;
                }
                if (total > valor)
                {
                    total = total - 4;
                    nota4--;
                }

                if (total < valor)
                {
                    total = total + 5;
                    nota5++;
                }
                if (total > valor)
                {
                    total = total - 5;
                    nota5--;
                }

                if (total < valor)
                {
                    total = total + 10;
                    nota10++;
                }
                if (total > valor)
                {
                    total = total - 10;
                    nota10--;
                }

                if (total < valor)
                {
                    total = total + 25;
                    nota25++;
                }
                if (total > valor)
                {
                    total = total - 25;
                    nota25--;
                }

                if (total < valor)
                {
                    total = total + 40;
                    nota40++;
                }
                if (total > valor)
                {
                    total = total - 40;
                    nota40--;
                }

                if (total < valor)
                {
                    total = total + 100;
                    nota100++;
                }
                if (total > valor)
                {
                    total = total - 100;
                    nota100--;
                }

                if (total < valor)
                {
                    total = total + 500;
                    nota500++;
                }
                if (total > valor)
                {
                    total = total - 500;
                    nota500--;
                }

                if (total - valor == -1) // se total (EX = 100) - valor (EX = 101) for igual a -1)
                {
                    total = total - 3;  // então total recebe ele mesmo - 3 
                    total = total + 4; // e total recebe ele + 4
                    nota3--; // tira a nota de 3
                    nota4++; // coloca a nota de 4
                } // isso pra tratar o resto 1, 2, -1, -2
                if (total - valor == -2)
                {
                    total = total - 3;
                    total = total + 5;
                    nota5++;
                    nota3--;
                }
                if (total - valor == 2)
                {
                    total = total - 5;
                    total = total + 3;
                    nota5--;
                    nota3++;
                }
                if (total - valor == 1)
                {
                    total = total - 4;
                    total = total + 3;
                    nota4--;
                    nota3++;
                } 
            } //se o número já ocupou todas as notas então o while se repete até o número inteiro
            lbl500.Text = Convert.ToString(nota500);
            lbl100.Text = Convert.ToString(nota100);
            lbl40.Text = Convert.ToString(nota40);
            lbl25.Text = Convert.ToString(nota25);
            lbl10.Text = Convert.ToString(nota10);
            lbl5.Text = Convert.ToString(nota5);
            lbl4.Text = Convert.ToString(nota4);
            lbl3.Text = Convert.ToString(nota3); // os valores são jogados nas labels
        }

        private void rBMaiorVariedade_CheckedChanged(object sender, EventArgs e) // procedimento do radio button
        {
            if (rBMaiorVariedade.Checked == true) // se o botão estiver checado
            {
                limparNotas(); // ele limpa as notas 
                if (txtValor.Text != "") // se a text estiver preenchida
                {
                    if (float.Parse(txtValor.Text) < 3) // se o valor do usuário for menor q 3
                    {
                        MessageBox.Show("Saque Insuficiente. Insira um valor maior que 2!");
                    }
                    else // se não
                    {
                        qtdMaior(Convert.ToInt32(txtValor.Text)); // chama o procedimento
                    }
                }
                else // se não estiver preenchido
                {
                    MessageBox.Show("Campo em Branco! Preencha-o.");
                }   
            }
        }
        void limparNotas() // procedimento que limpa as labels após elas exibirem a qtd de notas
        {
            lbl500.Text = "Notas de 500";
            lbl100.Text = "Notas de 100";
            lbl40.Text = "Notas de 40";
            lbl25.Text = "Notas de 25";
            lbl10.Text = "Notas de 10";
            lbl5.Text = "Notas de 5";
            lbl4.Text = "Notas de 4";
            lbl3.Text = "Notas de 3";
        }
        void Limpar() // procedimento que limpa 
        {
            rBMenorQuantidade.Checked = false;
            rBMaiorVariedade.Checked = false; // os dois radio button
            limparNotas(); // as labels
            txtValor.Text = ""; // a textbox
            txtValor.Focus(); // e coloca o foco na text
        }
        private void btnLimpar_Click(object sender, EventArgs e) // procedimento do botão limpar
        {
            Limpar(); // chama o procedimento limpar
        }
    }
}
