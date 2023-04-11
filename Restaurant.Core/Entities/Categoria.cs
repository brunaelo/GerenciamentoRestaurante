using System;
namespace Restaurant.Core.Entities;

public class Categoria : EntidadeBase
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public List<Produto> Produtos { get; set; }
}

