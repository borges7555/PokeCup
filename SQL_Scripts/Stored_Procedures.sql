CREATE PROCEDURE CreateJogador
	@nickname VARCHAR(32),
	@w_l FLOAT
AS BEGIN INSERT INTO PokeCup_Jogador(
	Nickname,
	W_L
)
VALUES(
	@nickname,
	@w_l
)
END

--EXEC CreateJogador
	--@nickname = 'Joaquim',
	--@w_l = 0;

CREATE PROCEDURE CreatePokemonEscolhido
	@nome VARCHAR(32),
	@ataque1 VARCHAR(32),
	@ataque2 VARCHAR(32),
	@ataque3 VARCHAR(32),
	@ataque4 VARCHAR(32),
	@item VARCHAR(32),
	@jogador VARCHAR(32)
AS BEGIN INSERT INTO PokeCup_PokemonEscolhido(
	Pokemons_Nome,
	Ataque_Nome1,
	Ataque_Nome2,
	Ataque_Nome3,
	Ataque_Nome4,
	Item_Nome,
	Jogador_Nickname
)
VALUES(
	@nome,
	@ataque1,
	@ataque2,
	@ataque3,
	@ataque4,
	@item,
	@jogador
)
END

EXEC CreatePokemonEscolhido
	@nome = 'Serperior',
	@ataque1 = 'Leaf Storm',
	@ataque2 = 'Energy Ball',
	@ataque3 = 'Dragon Pulse',
	@ataque4 = 'Protect',
	@item = 'Wise Glasses',
	@jogador = 'Borges';