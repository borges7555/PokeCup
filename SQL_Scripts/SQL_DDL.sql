--CREATE TYPE Typing FROM VARCHAR(10);
--CREATE TYPE Category FROM VARCHAR(10);
--CREATE TYPE Tiers FROM VARCHAR(10);

CREATE TABLE [PokeCup_Item](
	Nome VARCHAR(32) NOT NULL,
	Descricao VARCHAR(128) NOT NULL,

	PRIMARY KEY (Nome)
);

CREATE TABLE [PokeCup_Ataque](
	Nome VARCHAR(32) NOT NULL,
	Tipo Typing NOT NULL,
	Poder INT,
	Accuracy INT,
	Categoria Category NOT NULL,

	CONSTRAINT CHK_Tipo CHECK (Tipo IN ('Normal','Fire','Water','Electric','Grass','Ice','Fighting','Poison','Ground','Flying','Psychic','Bug','Rock','Ghost','Dragon','Dark','Steel')),
	CONSTRAINT CHK_Categoria CHECK (Categoria IN ('Physical', 'Special', 'Status')),

	PRIMARY KEY (Nome)
);

CREATE TABLE [PokeCup_Pokemons](
	ID INT NOT NULL,
	Nome VARCHAR(32) NOT NULL,
	Imagem VARCHAR(256) NOT NULL,
	Tipo1 Typing NOT NULL,
	Tipo2 Typing,
	Tier Tiers NOT NULL,

	CONSTRAINT CHK_Tipo1 CHECK (Tipo1 IN ('Normal','Fire','Water','Electric','Grass','Ice','Fighting','Poison','Ground','Flying','Psychic','Bug','Rock','Ghost','Dragon','Dark','Steel')),
	CONSTRAINT CHK_Tipo2 CHECK (Tipo2 IN ('Normal','Fire','Water','Electric','Grass','Ice','Fighting','Poison','Ground','Flying','Psychic','Bug','Rock','Ghost','Dragon','Dark','Steel')),
	CONSTRAINT CHK_Tier CHECK (Tier IN ('Uber', 'OU', 'UU', 'PU', 'NU', 'RU')),
	
	PRIMARY KEY (Nome)
);

CREATE TABLE [PokeCup_Jogador](
	Nickname VARCHAR(32) NOT NULL,
	W_L FLOAT NOT NULL,

	PRIMARY KEY (Nickname),
);

CREATE TABLE [PokeCup_PokemonEscolhido](
	ID INT IDENTITY(1,1), --incrementa o ID cada vez que há uma entrada nova automaticamente
	Pokemons_Nome VARCHAR(32) NOT NULL,
	Ataque_Nome1 VARCHAR(32) NOT NULL,
	Ataque_Nome2 VARCHAR(32) NOT NULL,
	Ataque_Nome3 VARCHAR(32) NOT NULL,
	Ataque_Nome4 VARCHAR(32) NOT NULL,
	Item_Nome VARCHAR(32),
	Jogador_Nickname VARCHAR(32) NOT NULL,

	PRIMARY KEY (ID),
	FOREIGN KEY (Pokemons_Nome) REFERENCES PokeCup_Pokemons(Nome),
	FOREIGN KEY (Ataque_Nome1) REFERENCES PokeCup_Ataque(Nome),
	FOREIGN KEY (Ataque_Nome2) REFERENCES PokeCup_Ataque(Nome),
	FOREIGN KEY (Ataque_Nome3) REFERENCES PokeCup_Ataque(Nome),
	FOREIGN KEY (Ataque_Nome4) REFERENCES PokeCup_Ataque(Nome),
	FOREIGN KEY (Item_Nome) REFERENCES PokeCup_Item(Nome),
	FOREIGN KEY (Jogador_Nickname) REFERENCES PokeCup_Jogador(Nickname),
);

CREATE TABLE [PokeCup_EquipaPokemons](
	ID INT IDENTITY(1,1),
	Jogador_Nickname VARCHAR(32) NOT NULL,
	Tier Tiers NOT NULL,
	Pokemons_escolhidos_ID1 INT NOT NULL,
	Pokemons_escolhidos_ID2 INT NOT NULL,
	Pokemons_escolhidos_ID3 INT NOT NULL,
	Pokemons_escolhidos_ID4 INT NOT NULL,
	Pokemons_escolhidos_ID5 INT NOT NULL,
	Pokemons_escolhidos_ID6 INT NOT NULL,

	PRIMARY KEY (ID, Jogador_Nickname),
	FOREIGN KEY (Jogador_Nickname) REFERENCES PokeCup_Jogador(Nickname),
	FOREIGN KEY (Pokemons_escolhidos_ID1) REFERENCES PokeCup_PokemonEscolhido(ID),
	FOREIGN KEY (Pokemons_escolhidos_ID2) REFERENCES PokeCup_PokemonEscolhido(ID),
	FOREIGN KEY (Pokemons_escolhidos_ID3) REFERENCES PokeCup_PokemonEscolhido(ID),
	FOREIGN KEY (Pokemons_escolhidos_ID4) REFERENCES PokeCup_PokemonEscolhido(ID),
	FOREIGN KEY (Pokemons_escolhidos_ID5) REFERENCES PokeCup_PokemonEscolhido(ID),
	FOREIGN KEY (Pokemons_escolhidos_ID6) REFERENCES PokeCup_PokemonEscolhido(ID),
	--CONSTRAINT CHK_Tier CHECK (Tier IN ('Uber', 'OU', 'UU', 'PU', 'NU', 'RU')),
);

CREATE TABLE [PokeCup_Torneio](
	ID INT IDENTITY(1,1),
	Nome VARCHAR(32) NOT NULL,
	Tier Tiers NOT NULL,
	Data DATE NOT NULL,
	Localizacao VARCHAR(32) NOT NULL,
	Num_Max_Jogadores INT NOT NULL,
	-- Tem varias partidas e varios jogadores

	--CONSTRAINT CHK_Tier CHECK (Tier IN ('Uber', 'OU', 'UU', 'PU', 'NU', 'RU')), --podemos tirar alguns para limitar a escolha mas estes são todos os que existem

	PRIMARY KEY (ID),
);

CREATE TABLE [PokeCup_Partida](
	Numero INT NOT NULL,
	Torneio_ID INT NOT NULL,
	Jogador_Nickname_1 VARCHAR(32) NOT NULL,
	Jogador_Nickname_2 VARCHAR(32) NOT NULL,

	PRIMARY KEY (Numero, Torneio_ID),
	FOREIGN KEY (Torneio_ID) REFERENCES PokeCup_Torneio(ID),
	FOREIGN KEY (Jogador_Nickname_1) REFERENCES PokeCup_Jogador(Nickname),
	FOREIGN KEY (Jogador_Nickname_2) REFERENCES PokeCup_Jogador(Nickname)
);

CREATE TABLE [PokeCup_ResultadoFinal](
    Partida_Numero INT NOT NULL,
    Torneio_ID INT NOT NULL,
    Jogador_Nickname_Vencedor VARCHAR(32) NOT NULL,
    Num_Rondas_Ganhas_J1 INT NOT NULL,
    Num_Rondas_Ganhas_J2 INT NOT NULL,
    
    PRIMARY KEY (Partida_Numero, Torneio_ID),
    FOREIGN KEY (Jogador_Nickname_Vencedor) REFERENCES PokeCup_Jogador(Nickname),
    FOREIGN KEY (Partida_Numero, Torneio_ID) REFERENCES PokeCup_Partida(Numero, Torneio_ID)
);


CREATE TABLE [PokeCup_Ronda](
	Numero INT NOT NULL,
	Num_Pokemons_Vivos_J1 INT NOT NULL,
	Num_Pokemons_Vivos_J2 INT NOT NULL,
	Partida_Numero INT NOT NULL,
	Torneio_ID INT NOT NULL,
	Jogador_Nickname_Vencedor VARCHAR(32) NOT NULL,

	FOREIGN KEY (Partida_Numero, Torneio_ID) REFERENCES PokeCup_Partida(Numero, Torneio_ID),
	FOREIGN KEY (Jogador_Nickname_Vencedor) REFERENCES PokeCup_Jogador(Nickname)
);

CREATE TABLE [PokeCup_TorneioJogador](
	Torneio_ID INT NOT NULL,
	Jogador_Nickname VARCHAR(32) NOT NULL,

	PRIMARY KEY (Torneio_ID, Jogador_Nickname),
	FOREIGN KEY (Torneio_ID) REFERENCES PokeCup_Torneio(ID),
	FOREIGN KEY (Jogador_Nickname) REFERENCES PokeCup_Jogador(Nickname)
);