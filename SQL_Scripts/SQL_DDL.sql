CREATE TYPE Typing FROM VARCHAR(10);
CREATE TYPE Category FROM VARCHAR(10);

CREATE TABLE [Item](
	Nome VARCHAR(32) NOT NULL,
	Descricao VARCHAR(128) NOT NULL,

	PRIMARY KEY (Nome)
);

CREATE TABLE [Ataque](
	Nome VARCHAR(32) NOT NULL,
	Tipo Typing NOT NULL,
	Poder INT,
	Accuracy INT NOT NULL,
	Categoria Category NOT NULL,

	CONSTRAINT CHK_Tipo CHECK (Tipo IN ('Normal','Fire','Water','Electric','Grass','Ice','Fighting','Poison','Ground','Flying','Psychic','Bug','Rock','Ghost','Dragon','Dark','Steel')),
	CONSTRAINT CHK_Categoria CHECK (Categoria IN ('Physical', 'Special', 'Status')),

	PRIMARY KEY (Nome)
);

CREATE TABLE [Pokemons](
	ID INT NOT NULL,
	Nome VARCHAR(32) NOT NULL,
	Imagem VARCHAR(256) NOT NULL, --como é um ficheiro, não sei se é um tipo VARCHAR
	Tier VARCHAR(32) NOT NULL,
	Tipo1 Typing NOT NULL,
	Tipo2 Typing,

	CONSTRAINT CHK_Tipo1 CHECK (Tipo1 IN ('Normal','Fire','Water','Electric','Grass','Ice','Fighting','Poison','Ground','Flying','Psychic','Bug','Rock','Ghost','Dragon','Dark','Steel')),
	CONSTRAINT CHK_Tipo2 CHECK (Tipo2 IN ('Normal','Fire','Water','Electric','Grass','Ice','Fighting','Poison','Ground','Flying','Psychic','Bug','Rock','Ghost','Dragon','Dark','Steel')),
	
	PRIMARY KEY (ID)
);

CREATE TABLE [Pokemons_escolhidos](
	ID INT NOT NULL,
	Pokemons_ID INT NOT NULL,
	Ataque_Nome VARCHAR(32) NOT NULL, --como cada pokemon tem 4 ataques, se calhar vamos precisar de 4 destas
	Item_Nome VARCHAR(32),

	PRIMARY KEY (ID),
	FOREIGN KEY (Pokemons_ID) REFERENCES Pokemons(ID),
	FOREIGN KEY (Ataque_Nome) REFERENCES Ataque(Nome),
	FOREIGN KEY (Item_Nome) REFERENCES Item(Nome)
);

CREATE TABLE [Equipa_Pokemons](
	ID INT NOT NULL,
	Jogador_Nickname VARCHAR(32) NOT NULL,
	Tier VARCHAR(32) NOT NULL,
	Pokemons_escolhidos_ID INT NOT NULL, --como cada equipa tem 6 pokemons, se calhar vamos precisar de 6 destas

	PRIMARY KEY (ID, Jogador_Nickname),
	FOREIGN KEY (Jogador_Nickname) REFERENCES Jogador(Nickname),
	FOREIGN KEY (Pokemons_escolhidos_ID) REFERENCES Pokemons_escolhidos(ID)
);

CREATE TABLE [Jogador](
	Nickname VARCHAR(32) NOT NULL,
	W/L FLOAT NOT NULL,
	Equipa_Pokemons_ID INT NOT NULL, --como cada jogador vai ter talvez uma equipa para cada tier, se calhar vamos precisar de 3 (depende do nº de tiers que tivermos) destas 

	PRIMARY KEY (Nickname),
	FOREIGN KEY (Equipa_Pokemons_ID) REFERENCES Equipa_Pokemons(ID)
);

CREATE TABLE [Ronda](
	ID INT NOT NULL,
	Numero INT NOT NULL,
	Num_Pokemons_Vivos_J1 INT NOT NULL,
	Num_Pokemons_Vivos_J2 INT NOT NULL,
	Partida_Numero INT NOT NULL,
	Jogador_Nickname_Vencedor VARCHAR(32) NOT NULL,

	PRIMARY KEY (ID),
	FOREIGN KEY (Partida_Numero) REFERENCES Partida(Numero),
	FOREIGN KEY (Jogador_Nickname_Vencedor) REFERENCES Jogador(Nickname)
);

CREATE TABLE [Resultado_Final](
	Partida_Numero INT NOT NULL,
	Jogador_Nickname_Vencedor VARCHAR(32) NOT NULL,
	Num_Rondas_Ganhas_J1 INT NOT NULL,
	Num_Rondas_Ganhas_J2 INT NOT NULL,

	PRIMARY KEY (Partida_Numero),
	FOREIGN KEY (Jogador_Nickname_Vencedor) REFERENCES Jogador(Nickname)
);

CREATE TABLE [Partida](
	Numero INT NOT NULL,
	Torneio_ID INT NOT NULL,
	Ronda_ID_Ronda_1 INT NOT NULL,
	Ronda_ID_Ronda_2 INT NOT NULL,
	Ronda_ID_Ronda_3 INT NOT NULL,
	Resultado_Final_Partida_Numero INT NOT NULL,
	Jogador_Nickname_1 VARCHAR(32) NOT NULL,
	Jogador_Nickname_2 VARCHAR(32) NOT NULL,

	PRIMARY KEY (Numero, Torneio_ID),
	FOREIGN KEY (Torneio_ID) REFERENCES Torneio(ID),
	FOREIGN KEY (Ronda_ID_Ronda_1) REFERENCES Ronda(ID),
	FOREIGN KEY (Ronda_ID_Ronda_2) REFERENCES Ronda(ID),
	FOREIGN KEY (Ronda_ID_Ronda_3) REFERENCES Ronda(ID),
	FOREIGN KEY (Resultado_Final_Partida_Numero) REFERENCES Resultado_Final(Partida_Numero),
	FOREIGN KEY (Jogador_Nickname_1) REFERENCES Jogador(Nickname),
	FOREIGN KEY (Jogador_Nickname_2) REFERENCES Jogador(Nickname)
);

CREATE TABLE [Torneio](
	ID INT NOT NULL,
	Nome VARCHAR(32) NOT NULL,
	Tier VARCHAR(32) NOT NULL,
	Data DATE NOT NULL,
	Localizacao VARCHAR(32) NOT NULL,
	Num_Max_Jogadores INT NOT NULL,
	-- Tem varias partidas e varios jogadores

	PRIMARY KEY (ID),
);

CREATE TABLE [Torneio_Partida](
	Torneio_ID INT NOT NULL,
	Partida_Numero INT NOT NULL,

	PRIMARY KEY (Torneio_ID, Partida_Numero),
	FOREIGN KEY (Torneio_ID) REFERENCES Torneio(ID),
	FOREIGN KEY (Partida_Numero) REFERENCES Partida(Numero)
);

CREATE TABLE [Torneio_Jogador](
	Torneio_ID INT NOT NULL,
	Jogador_Nickname VARCHAR(32) NOT NULL,

	PRIMARY KEY (Torneio_ID, Jogador_Nickname),
	FOREIGN KEY (Torneio_ID) REFERENCES Torneio(ID),
	FOREIGN KEY (Jogador_Nickname) REFERENCES Jogador(Nickname)
);