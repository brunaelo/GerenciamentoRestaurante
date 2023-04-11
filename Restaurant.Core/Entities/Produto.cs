using System;
namespace Restaurant.Core.Entities;

public class Produto : EntidadeBase
{
	public Produto()
	{
	}

    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public Categoria Categoria { get; set; }
}

