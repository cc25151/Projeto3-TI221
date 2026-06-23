using System;
using System.Collections.Generic;

public class PilhaVetor<T> : IStack<T>
{
    const int MAXIMO = 500;
    private int tamanhoFisico;
    private T[] p;
    private int topo;
    public PilhaVetor() : this(MAXIMO) { }

    public PilhaVetor(int quantasPosicoes)
    {
        tamanhoFisico = quantasPosicoes;
        p = new T[quantasPosicoes];
        topo = -1;
    }

    public int Tamanho => topo+1;

    public bool EstaVazia => topo < 0;

    public List<T> Conteudo()
    {
        List<T> resultado = new List<T>();
        for (int indice = topo; indice >= 0; indice--)
            resultado.Add(p[indice]);
        return resultado;
    }

    public T Desempilhar()
    {
        if (EstaVazia)
            throw new Exception("Pilha esvaziou (underflow)");
        T dadoDoTopo = p[topo];
        p[topo--] = default(T);
        return dadoDoTopo;
    }

    public void Empilhar(T item)
    {
        if (Tamanho == tamanhoFisico)
            throw new Exception("Pilha encheu (overflow)!");

        p[++topo] = item;
    }

    public T OTopo()
    {
        if (EstaVazia)
            throw new Exception("Pilha esvaziou (underflow)");
        return p[topo];
    }
}
