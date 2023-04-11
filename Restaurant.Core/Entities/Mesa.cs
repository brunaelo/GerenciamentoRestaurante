using System;
namespace Restaurant.Core.Entities;

public class Mesa : EntidadeBase
{
	public int Numero { get; set; }
	public bool Status { get; set; }
	public DateTime? HoraAbertura { get; set; }
    public List<Atendimento> Atendimentos { get; set; }
    public List<Garcom> GarconsAtendentes { get; set; }
}

