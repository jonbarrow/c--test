using System;

namespace Test
{
	public enum TestEnum : uint
	{
		Pokédex = 0x00,
		Pokémon = 0x01,
		Bag     = 0x02,
	}

	class TestMain
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Pokémon");
		}
	}
}
