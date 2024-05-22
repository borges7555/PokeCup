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

-- EXEC CreatePokemonEscolhido
-- 	@nome = 'Serperior',
-- 	@ataque1 = 'Leaf Storm',
-- 	@ataque2 = 'Energy Ball',
-- 	@ataque3 = 'Dragon Pulse',
-- 	@ataque4 = 'Protect',
-- 	@item = 'Wise Glasses',
-- 	@jogador = 'Borges';

-- create equipa de pokemons
CREATE PROCEDURE CreateEquipaPokemons
	@jogador VARCHAR(32),
	@tier Tiers,
	@pokemon1 INT,
	@pokemon2 INT,
	@pokemon3 INT,
	@pokemon4 INT,
	@pokemon5 INT,
	@pokemon6 INT
AS BEGIN INSERT INTO PokeCup_EquipaPokemons(
	Jogador_Nickname,
	Tier,
	Pokemons_escolhidos_ID1,
	Pokemons_escolhidos_ID2,
	Pokemons_escolhidos_ID3,
	Pokemons_escolhidos_ID4,
	Pokemons_escolhidos_ID5,
	Pokemons_escolhidos_ID6
)
VALUES(
	@jogador,
	@tier,
	@pokemon1,
	@pokemon2,
	@pokemon3,
	@pokemon4,
	@pokemon5,
	@pokemon6
)
END

EXEC CreateEquipaPokemons
	@jogador = 'testenick',
	@tier = 'OU',
	@pokemon1 = 1,
	@pokemon2 = 2,
	@pokemon3 = 3,
	@pokemon4 = 4,
	@pokemon5 = 5,
	@pokemon6 = 6;

