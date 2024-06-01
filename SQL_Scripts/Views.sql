CREATE VIEW View_PartidaResultado AS
SELECT
    P.Numero,
    P.Torneio_ID,
    P.Jogador_Nickname_1,
    P.Jogador_Nickname_2,
    R.Jogador_Nickname_Vencedor,
    R.Num_Rondas_Ganhas_J1,
    R.Num_Rondas_Ganhas_J2
FROM
    PokeCup_Partida P
LEFT JOIN
    PokeCup_ResultadoFinal R
ON
    P.Numero = R.Partida_Numero AND P.Torneio_ID = R.Torneio_ID;

SELECT * FROM View_PartidaResultado WHERE Torneio_ID = 4;


-- VIEW 2
CREATE VIEW View_RondaDetalhes AS
SELECT 
    R.Numero, 
    R.Num_Pokemons_Vivos_J1, 
    R.Num_Pokemons_Vivos_J2, 
    R.Jogador_Nickname_Vencedor, 
    P.Jogador_Nickname_1, 
    P.Jogador_Nickname_2,
    R.Torneio_ID,
    R.Partida_Numero
FROM 
    PokeCup_Ronda R
INNER JOIN 
    PokeCup_Partida P 
ON 
    R.Partida_Numero = P.Numero AND R.Torneio_ID = P.Torneio_ID;

SELECT * FROM View_RondaDetalhes WHERE Torneio_ID = 4;
