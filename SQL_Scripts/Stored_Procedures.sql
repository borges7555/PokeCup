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
	@jogador = 'Borges',
	@tier = 'OU',
	@pokemon1 = 1,
	@pokemon2 = 2,
	@pokemon3 = 3,
	@pokemon4 = 4,
	@pokemon5 = 5,
	@pokemon6 = 6;

CREATE PROCEDURE CreateTorneio
	@nome VARCHAR(32),
	@tier Tiers,
	@data DATE,
	@localizacao VARCHAR(32),
	@nmax INT
AS BEGIN INSERT INTO PokeCup_Torneio(
	Nome,
	Tier,
	Data,
	Localizacao,
	Num_Max_Jogadores
)
VALUES(
	@nome,
	@tier,
	@data,
	@localizacao,
	@nmax
)
END

EXEC CreateTorneio
	@nome = 'Torneio Teste 2',
	@tier = 'OU',
	@data = '2024-05-25',
	@localizacao = 'Porto',
	@nmax = 4;

CREATE PROCEDURE AddJogadorToTorneio
	@torneioid INT,
	@jogador VARCHAR(32)
AS BEGIN INSERT INTO PokeCup_TorneioJogador(
	Torneio_ID,
	Jogador_Nickname
)
VALUES(
	@torneioid,
	@jogador
)
END

EXEC AddJogadorToTorneio
	@torneioid = 1,
	@jogador = 'Borges';

CREATE PROCEDURE CreatePartida
	@num INT,
	@torneioid INT,
	@jogador1 VARCHAR(32),
	@jogador2 VARCHAR(32)
AS BEGIN INSERT INTO PokeCup_Partida(
	Numero,
	Torneio_ID,
	Jogador_Nickname_1,
	Jogador_Nickname_2
)
VALUES(
	@num,
	@torneioid,
	@jogador1,
	@jogador2
)
END	

EXEC CreatePartida
	@num = 1,
	@torneioid = 1,
	@jogador1 = 'Borges',
	@jogador2 = 'Joaquim';

CREATE PROCEDURE CreateRonda
	@num INT,
	@num_poke_vivos1 INT,
	@num_poke_vivos2 INT,
	@partidanumero INT,
	@torneioid INT,
	@jogador_vencedor VARCHAR(32)
AS BEGIN INSERT INTO PokeCup_Ronda(
	Numero,
	Num_Pokemons_Vivos_J1,
	Num_Pokemons_Vivos_J2,
	Partida_Numero,
	Torneio_ID,
	Jogador_Nickname_Vencedor
)
VALUES(
	@num,
	@num_poke_vivos1,
	@num_poke_vivos2,
	@partidanumero,
	@torneioid,
	@jogador_vencedor
)
END

EXEC CreateRonda
	@num = 1,
	@num_poke_vivos1 = 1,
	@num_poke_vivos2 = 0,
	@partidanumero = 1,
	@torneioid = 1,
	@jogador_vencedor = 'Borges'; 
EXEC CreateRonda
	@num = 2,
	@num_poke_vivos1 = 0,
	@num_poke_vivos2 = 2,
	@partidanumero = 1,
	@torneioid = 1,
	@jogador_vencedor = 'Joaquim'; 
EXEC CreateRonda
	@num = 3,
	@num_poke_vivos1 = 1,
	@num_poke_vivos2 = 0,
	@partidanumero = 1,
	@torneioid = 1,
	@jogador_vencedor = 'Borges'; 

CREATE PROCEDURE CreateResultadoFinal
	@partidanumero INT,
	@torneioid INT,
	@jogadorvencedor VARCHAR(32),
	@rondas_ganhas1 INT,
	@rondas_ganhas2 INT
AS BEGIN INSERT INTO PokeCup_ResultadoFinal(
	Partida_Numero,
	Torneio_ID,
	Jogador_Nickname_Vencedor,
	Num_Rondas_Ganhas_J1,
	Num_Rondas_Ganhas_J2
)
VALUES(
	@partidanumero,
	@torneioid,
	@jogadorvencedor,
	@rondas_ganhas1,
	@rondas_ganhas2
)
END

EXEC CreateResultadoFinal
	@partidanumero = 1,
	@torneioid = 1,
	@jogadorvencedor = 'Borges',
	@rondas_ganhas1 = 2,
	@rondas_ganhas2 = 1;