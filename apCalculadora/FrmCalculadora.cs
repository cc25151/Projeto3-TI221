namespace apCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private double[] valorDe = new double[26];
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private string PrepararExpressao(string expressao) // retorna a expressão infixa com as letras que representam os operandos
        {
            string infixaComLetras = "";
            int indiceLetra = 0;
            int i = 0;
            while (i < expressao.Length) // percorre toda a expressão
            {
                char caracter = expressao[i];

                if (!EhOperador(caracter)) // é um operando
                {
                    string numero = "";
                    while (i < expressao.Length && !EhOperador(expressao[i])) // usado para números decimais (que possuem ponto)
                    {
                        numero += expressao[i];
                        i++;
                    }
                    char letra = (char)('A' + indiceLetra);
                    valorDe[indiceLetra] = double.Parse(numero); // inclui o número no vetor indexado por letras
                    indiceLetra++;
                    infixaComLetras += letra;
                }
                else
                {
                    infixaComLetras += caracter;
                    i++;
                }
            }
            return infixaComLetras;
        }

        string ConverterInfixaParaPosfixa(string cadeiaLida)
        {
            string resultado = "";
            PilhaLista<char> umaPilha = new PilhaLista<char>(); // Instancia a Pilha

            for (int indice = 0; indice < cadeiaLida.Length; indice++)
            {
                char simboloLido = cadeiaLida[indice];

                if (!EhOperador(simboloLido)) // not In ['(',')','+','-','*','/','']
                    resultado += simboloLido; // adiciona Operando no resultado
                else // símbolo é operador
                {
                    bool parar = false;

                    while (!parar && !umaPilha.EstaVazia && TemPrecedencia(umaPilha.OTopo(), simboloLido))
                    {
                        char operadorComMaiorPrecedencia = umaPilha.Desempilhar();

                        if (operadorComMaiorPrecedencia != '(')
                            resultado += operadorComMaiorPrecedencia;
                        else
                            parar = true;
                    }

                    if (simboloLido != ')')
                        umaPilha.Empilhar(simboloLido);
                    else // desempilha quando o topo da pilha for '('
                        umaPilha.Desempilhar();
                }
            }

            // Descarrega a pilha para a saída
            while (!umaPilha.EstaVazia)
            {
                char operador = umaPilha.Desempilhar();
                if (operador != '(')
                    resultado += operador;
            }

            return resultado;
        }

        public bool EhOperador(char simbolo)
        {
            return simbolo == '(' || simbolo == ')' ||
                   simbolo == '+' || simbolo == '-' ||
                   simbolo == '*' || simbolo == '/' ||
                   simbolo == '^';
        }

        public bool TemPrecedencia(char operador1, char operador2)
        {
            switch (operador1)
            {
                case '(': return false;
                case '^': return operador2 != '(' && operador2 != '^';
                case '*': return operador2 != '(' && operador2 != '^';
                case '/': return operador2 != '(' && operador2 != '^';
                case '+': return operador2 != '(' && operador2 != '^' && operador2 != '*' && operador2 != '/';
                case '-': return operador2 != '(' && operador2 != '^' && operador2 != '*' && operador2 != '/';
                case ')': return false;
                default: return false;
            }
        }
        public double ValorDaExpressaoPosfixa(string cadeiaPosfixa)
        {
            var umaPilha = new PilhaLista<double>();
            for (int atual = 0; atual < cadeiaPosfixa.Length; atual++)
            {
                char simbolo = cadeiaPosfixa[atual];
                if (!EhOperador(simbolo)) // é um operando
                    umaPilha.Empilhar(valorDe[simbolo - 'A']);
                else
                {
                    double operando2 = umaPilha.Desempilhar();
                    double operando1 = umaPilha.Desempilhar();
                    double valorParcial = ValorDaSubExpressao(operando1, simbolo, operando2);
                    umaPilha.Empilhar(valorParcial);
                }
            }
            return umaPilha.Desempilhar(); // resultado final
        }

        public double ValorDaSubExpressao(double operando1, char operador, double operando2)
        {
            switch (operador)
            {
                case '+': return operando1 + operando2;
                case '-': return operando1 - operando2;
                case '*': return operando1 * operando2;
                case '/': return operando1 / operando2;
                case '^': return Math.Pow(operando1, operando2);
                default: throw new Exception("Operador inválido");
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            string valor = botao.Text;
            txtVisor.Text += valor;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Length > 0)
                txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1); // se não estiver vazio, apaga o último caractere do visor
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            var infixaComLetras = PrepararExpressao(txtVisor.Text);
            var posfixa = ConverterInfixaParaPosfixa(infixaComLetras);
            lbSequencias.Text = "Infixa: " + infixaComLetras + " | Pósfixa: " + posfixa;
            txtResultado.Text = ValorDaExpressaoPosfixa(posfixa).ToString();
        }
    }
}