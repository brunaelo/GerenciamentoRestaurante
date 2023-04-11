using System;
namespace Restaurant.Core.Entities;

public class Atendimento : EntidadeBase
{
	public Atendimento()
	{
	}

    public Mesa MesaAtendida { get; set; }
    public Garcom GarconResponsavel { get; set; }
    public DateTime HoraPedido { get; set; }
    public List<Produto> ProdutosSolicitados { get; set; }
}

