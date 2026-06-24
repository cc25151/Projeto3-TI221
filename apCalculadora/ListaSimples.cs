using System;
using System.Collections.Generic;
using System.IO;

namespace apCalculadora
{
    public class ListaSimples<Dado>
        where Dado : IComparable<Dado>,
                     IRegistro<Dado>,
                     new()      // classe Dado implementa construtor sem parâmetros
    {
        protected NoLista<Dado> primeiro, // ponteiro do primeiro nó
                              ultimo,   // ponteiro do último nó
                              atual,    // usado para percorrer a lista sequencialmente
                              anterior;
        protected int quantosNos;         // contador de nós da lista

        public ListaSimples()
        {
            primeiro = ultimo = atual = anterior = null;
            quantosNos = 0;
        }

        public int Tamanho => quantosNos;   // retorna (get) o valor de quantosNos

        public NoLista<Dado> Primeiro
        {
            get => primeiro;
        }

        public NoLista<Dado> Ultimo => ultimo;

        public bool EstaVazia => primeiro == null;

        public NoLista<Dado> Atual { get => atual; }

        // precisaremos desenvolver métodos para:
        // - listar os dados da lista ligada
        // - incluir um novo nó após o último nó
        // - incluir um novo nó antes do primeiro nó
        // - incluir um novo nó entre dois outros nós
        // - buscar um Dado dentro dos nós da lista (pesquisa)
        // - excluir o nó que armazena o Dado desejado
        // - ordenar a lista ligada pelo atributo de comparação da classe Dado

        public void InserirAposFim(Dado novoDado)
        {
            // criamos um novo nó, que armazenará o novoDado
            // no seu atributo info:
            var novoNo = new NoLista<Dado>(novoDado);

            // decidimos em que local "amarrar" o novo nó 
            // que criamos:
            if (EstaVazia)
                primeiro = novoNo;  // é o 1o nó a ser inserido
            else
                ultimo.Prox = novoNo;

            ultimo = novoNo;        // passa a ser o último da lista
            quantosNos++;
        }

        // sobrecarga do método InserirAposFim
        public void InserirAposFim(NoLista<Dado> novoNo)
        {
            // não cria um novo nó, reaproveita o que foi passado por parâmetro

            novoNo.Prox = null;

            // decidimos em que local "amarrar" o novo nó 
            // que criamos:
            if (EstaVazia)
                primeiro = novoNo;  // é o 1o nó a ser inserido
            else
                ultimo.Prox = novoNo;

            ultimo = novoNo;        // passa a ser o último da lista
            quantosNos++;
        }
        //
        // fazer o método InserirAntesDoInicio com parâmetro NoLIsta<Dado>
        //
        public void InserirAntesDoInicio(Dado novoDado)
        {
            // criamos um novo nó, que armazenará o novoDado
            // no seu atributo info:
            var novoNo = new NoLista<Dado>(novoDado);

            // decidimos em que local "amarrar" o novo nó 
            // que criamos:
            if (EstaVazia)
                ultimo = novoNo;
            else
                novoNo.Prox = primeiro;

            primeiro = novoNo;        // passa a ser o último da lista
            quantosNos++;
        }
        public List<Dado> Listar()
        {
            var osDados = new List<Dado>();
            anterior = null;
            atual = primeiro;
            while (atual != null)
            {
                // adiciona a informação desse nó atual na lista de 
                // resultados:
                osDados.Add(atual.Info);

                // avança ponteiro atual para o nó seguinte a ele:
                anterior = atual;
                atual = atual.Prox;
            }
            return osDados;
        }

        // busca um Dado na lista
        public bool Existe(Dado dadoProcurado)
        {
            anterior = null;
            atual = primeiro;

            if (EstaVazia)
                return false;

            // só podemos acessar diretamente o ponteiro para o 
            // primeiro ou para o último, se temos certeza que
            // a lista não está VAZIA
            if (dadoProcurado.CompareTo(primeiro.Info) < 0)
                return false;

            if (dadoProcurado.CompareTo(ultimo.Info) > 0)
            {
                anterior = ultimo;  // indica inclusão após o último
                atual = null;
                return false;
            }

            while (atual != null)
            {
                if (dadoProcurado.CompareTo(atual.Info) == 0)
                    return true;

                if (dadoProcurado.CompareTo(atual.Info) < 0)
                    return false;

                anterior = atual;   // para facilitar inclusão e exclusão
                atual = atual.Prox;
            }

            // percorreu a lista até o fim e não achou
            return false;
        }

        public bool InseriuEmOrdem(Dado dados)
        {
            if (!Existe(dados))     // Existe() ajusta ponteiros anterior e atual 
            {                       // aqui temos certeza de que a chave não existe 
                                    // guarda dados no novo nó 
                if (EstaVazia)                    // se a lista está vazia, então o   
                    InserirAntesDoInicio(dados);  // dado ficará como primeiro da lista 
                else
                    // testa se nova chave < primeira chave 
                    if (anterior == null && atual != null)
                        // (dados.Info.CompareTo(primeiro.Info) < 0)
                        InserirAntesDoInicio(dados); // liga novo nó antes do primeiro 
                    else
                        // testa se nova chave > última chave 
                        if (anterior != null && atual == null)
                            InserirAposFim(dados);
                        else
                            InserirEntreDoisNos(dados);  // insere entre os nós anterior e atual 

                return true;        // foi incluído em ordem
            }

            return false;       // foi encontrado, não insere
        }
        private void InserirEntreDoisNos(Dado dados)
        {
            // Existe () encontrou intervalo de inclusão do novo nó 

            var novo = new NoLista<Dado>(dados);
            anterior.Prox = novo;   // liga anterior ao novo 
            novo.Prox = atual;      // e novo no atual 

            if (anterior == ultimo)  // se incluiu ao final da lista, 
                ultimo = novo;       // atualiza o apontador ultimo 
            quantosNos++;            // incrementa número de nós da lista      }  
        }

        public bool Excluiu(Dado dadoAExcluir)
        {
            if (EstaVazia)
                return false;

            if (!Existe(dadoAExcluir))  // ajusta ponteiros atual e anterior
                return false;

            // foi encontrado, usaremos atual e anterior para decidir 
            // como ajustaremos os nós da lista

            if (atual == primeiro)
            {
                primeiro = primeiro.Prox;
                if (atual == ultimo)
                    ultimo = null;

                atual = primeiro;
            }
            else
                if (atual == ultimo)
                {
                    anterior.Prox = null;
                    ultimo = anterior;
                    atual = ultimo;
                }
                else
                {
                    anterior.Prox = atual.Prox;
                    atual = atual.Prox;
                }

            quantosNos--;
            return true;
        }
        public ListaSimples<Dado> Unir(ListaSimples<Dado> outraLista)
        {
            var novaLista = new ListaSimples<Dado>();
            // percorrer, em paralelo, a lista this e a outraLista
            // intercalando e colocando na novaLista o menor info
            // entre a lista this e a lista outraLista
            // ao final, retornar a novalista:

            this.atual = this.primeiro;
            outraLista.atual = outraLista.primeiro;
            while (this.atual != null && outraLista.atual != null)
            {

                if (this.atual.Info.CompareTo(outraLista.atual.Info) < 0)
                {
                    var noSeguinteAoAtual = this.atual.Prox;
                    novaLista.InserirAposFim(this.atual);
                    this.atual = noSeguinteAoAtual;         // avança na lista this
                }
                else
                    if (outraLista.atual.Info.CompareTo(this.atual.Info) < 0)
                    {
                        var noSeguinteAoAtual = outraLista.atual.Prox;
                        novaLista.InserirAposFim(outraLista.atual);
                        outraLista.atual = noSeguinteAoAtual;   // avança na outra lista
                    }
                    else
                    {
                        // chaves de comparação iguais]
                        var noSeguinteAoAtual = this.atual.Prox;
                        novaLista.InserirAposFim(this.atual);
                        this.atual = noSeguinteAoAtual;             // avança nas duas listas
                        outraLista.atual = outraLista.atual.Prox;
                    }

            }

            while (this.atual != null)    // enquanto sobram nós na lista this
            {
                var noSeguinteAoAtual = this.atual.Prox;
                novaLista.InserirAposFim(this.atual);
                this.atual = noSeguinteAoAtual;
            }

            while (outraLista.atual != null)
            {
                var noSeguinteAoAtual = outraLista.atual.Prox;
                novaLista.InserirAposFim(outraLista.atual);
                outraLista.atual = noSeguinteAoAtual;
            }
            this.primeiro = this.ultimo = null;
            this.quantosNos = 0;
            outraLista.primeiro = outraLista.ultimo = null;
            outraLista.quantosNos = 0;

            return novaLista;
        }


        // exercício 4

        public void Inverter()
        {
            // percorrer a lista this, do primeiro ao fim, e
            // trocando os ponteiros de modo que a lista fique
            // invertida, ou seja, o primeiro nó será o último,
            // o segundo nó será o penúltimo e assim sucessivamente

        }

        public bool LeuDados(string nomeArquivo)
        {
            try
            {
                var arquivo = new StreamReader(nomeArquivo);
                this.primeiro = null;
                this.ultimo = null;
                while (!arquivo.EndOfStream)
                {
                    var novoDado = new Dado();
                    novoDado.LerRegistro(arquivo);
                    InseriuEmOrdem(novoDado);
                }
                arquivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SalvouDados(string nomeArquivo)
        {
            try
            {
                var arquivoDeSaida = new StreamWriter(nomeArquivo);
                atual = primeiro;
                while (atual != null)
                {
                    atual.Info.GravarRegistro(arquivoDeSaida);
                    atual = atual.Prox;
                }
                arquivoDeSaida.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}