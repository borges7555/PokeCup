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
