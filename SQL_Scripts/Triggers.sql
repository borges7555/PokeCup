CREATE TRIGGER IncreaseW_L
ON PokeCup_ResultadoFinal
AFTER INSERT
AS
BEGIN
    -- Atualiza o W_L do jogador vencedor
    UPDATE PokeCup_Jogador
    SET W_L = W_L + 1
    FROM PokeCup_Jogador J
    INNER JOIN inserted I
    ON J.Nickname = I.Jogador_Nickname_Vencedor;
END;
