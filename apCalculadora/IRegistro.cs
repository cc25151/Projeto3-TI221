// Integrantes:
// Gabriel Bellini Camargo - 25131
// Pedro Henrique Sakamoto Mendes - 25151

using System;
using System.IO;

public interface IRegistro<T> where T : IComparable<T>, new()
{
    bool LerRegistro(StreamReader arq);
    void GravarRegistro(StreamWriter arq);
}