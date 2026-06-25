// Integrantes:
// Gabriel Bellini Camargo - 25131
// Pedro Henrique Sakamoto Mendes - 25151

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
                    if (indiceLetra >= valorDe.Length) // exceção caso o usuário digite uma expressão com mais de 26 operandos
                        throw new Exception("Expressão com operandos demais!");
                    char letra = (char)('A' + indiceLetra);
                    valorDe[indiceLetra] = double.Parse(numero, System.Globalization.CultureInfo.InvariantCulture); // inclui o número no vetor indexado por letras
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

                    while (!parar && !umaPilha.EstaVazia && TemPrecedencia(umaPilha.OTopo(), simboloLido)) // enquanto o topo da pilha tiver maior precedência que o símbolo lido, desempilha
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
                    {
                        if (umaPilha.EstaVazia) // exceção caso o usuário digite uma expressão desbalanceada
                            throw new Exception("Parênteses desbalanceados!");
                        umaPilha.Desempilhar();
                    }
                }
            }

            while (!umaPilha.EstaVazia) // descarrega a pilha para a saída
            {
                char operador = umaPilha.Desempilhar();
                if (operador == '(')
                    throw new Exception("Parênteses desbalanceados");
                resultado += operador;
            }

            return resultado;
        }

        public bool EhOperador(char simbolo) // checa se o símbolo é um operador ou parêntese
        {
            return simbolo == '(' || simbolo == ')' ||
                   simbolo == '+' || simbolo == '-' ||
                   simbolo == '*' || simbolo == '/' ||
                   simbolo == '^';
        }

        public bool TemPrecedencia(char operador1, char operador2) // retorna a precedência do operador1 em relação ao operador2
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
        public double ValorDaExpressaoPosfixa(string cadeiaPosfixa) // calcula o valor de uma expressão para exibí-la no txtResultado
        {
            var umaPilha = new PilhaLista<double>();
            for (int atual = 0; atual < cadeiaPosfixa.Length; atual++)
            {
                char simbolo = cadeiaPosfixa[atual];
                if (!EhOperador(simbolo)) // é um operando
                    umaPilha.Empilhar(valorDe[simbolo - 'A']);
                else // se for símbolo operador, desempilha dois operandos e empilha o resultado da operação
                {
                    if (umaPilha.EstaVazia) throw new Exception("Expressão inválida!");
                    double operando2 = umaPilha.Desempilhar();
                    if (umaPilha.EstaVazia) throw new Exception("Expressão inválida!");
                    double operando1 = umaPilha.Desempilhar();
                    double valorParcial = ValorDaSubExpressao(operando1, simbolo, operando2);
                    umaPilha.Empilhar(valorParcial);
                }
            }
            return umaPilha.Desempilhar(); // resultado final
        }

        public double ValorDaSubExpressao(double operando1, char operador, double operando2) // realiza operações básicas para calcular uma expressão maior
        {
            switch (operador)
            {
                case '+': return operando1 + operando2;
                case '-': return operando1 - operando2;
                case '*': return operando1 * operando2;
                case '/':
                    if (operando2 == 0) throw new Exception("Divisão por zero!"); // exceção caso o usuário tente dividir por zero
                    return operando1 / operando2;
                case '^': return Math.Pow(operando1, operando2);
                default: throw new Exception("Operador inválido");
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e) // exibe o valor do botão clicado no txtVisor
        {
            Button botao = (Button)sender;
            string valor = botao.Text;
            txtVisor.Text += valor;
        }

        private void btnLimpar_Click(object sender, EventArgs e) // limpa as exibições do txtVisor, txtResultado e lbSequencias
        {
            txtVisor.Text = "";
            txtResultado.Text = "";
            lbSequencias.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtVisor.Text)) return; // se estiver vazio, não faz nada
                // calcula as expressões infixa e pósfixa 
                var infixaComLetras = PrepararExpressao(txtVisor.Text);
                var posfixa = ConverterInfixaParaPosfixa(infixaComLetras);
                // calcula o resultado da expressão pósfixa e exibe as expressões e resultado
                txtResultado.Text = ValorDaExpressaoPosfixa(posfixa).ToString(System.Globalization.CultureInfo.InvariantCulture);
                lbSequencias.Text = "Infixa: " + infixaComLetras + " | Pósfixa: " + posfixa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}