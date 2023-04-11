using System;
namespace Restaurant.Core.Entities;

public class EntidadeBase
{
	protected EntidadeBase()
	{
	}

	public Guid Id { get; private set; }
}

