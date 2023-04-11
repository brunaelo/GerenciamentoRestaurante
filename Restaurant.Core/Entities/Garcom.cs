using System;
namespace Restaurant.Core.Entities;

public class Garcom : EntidadeBase
{

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public int NumeroIdentificacao { get; set; }
    public string NumeroTelefone { get; set; }
    public List<Atendimento> Atendimentos { get; set; }
}

