CREATE FUNCTION GetPokemonsEscolhidos(@jogador_nickname VARCHAR(32)) RETURNS TABLE AS
RETURN (
	SELECT A.Pokemons_Nome,
		A.Ataque_Nome1,
		A.Ataque_Nome2,
		A.Ataque_Nome3,
		A.Ataque_Nome4,
		A.Item_Nome
	FROM PokeCup_PokemonEscolhido AS A
	WHERE A.Jogador_Nickname = @jogador_nickname
);

SELECT * FROM GetPokemonsEscolhidos('Borges');

CREATE FUNCTION GetPokemonsFromTier(@tier TIERS) RETURNS TABLE AS
RETURN (
	SELECT A.Nome,
		A.Imagem,
		A.Tipo1,
		A.Tipo2
	FROM PokeCup_Pokemons AS A
	WHERE A.Tier = @tier
);

SELECT * FROM GetPokemonsFromTier('Uber');

CREATE FUNCTION GetEquipaFromJogador(@nickname VARCHAR(32)) RETURNS TABLE AS
RETURN (
    SELECT 
		E.ID,
        E.Tier,
        
        -- Detalhes do Pokémon 1
        P1.Pokemons_Nome AS Pokemon1_Nome,
        P1.Ataque_Nome1 AS Pokemon1_Ataque1,
        P1.Ataque_Nome2 AS Pokemon1_Ataque2,
        P1.Ataque_Nome3 AS Pokemon1_Ataque3,
        P1.Ataque_Nome4 AS Pokemon1_Ataque4,
        P1.Item_Nome AS Pokemon1_Item,

        -- Detalhes do Pokémon 2
        P2.Pokemons_Nome AS Pokemon2_Nome,
        P2.Ataque_Nome1 AS Pokemon2_Ataque1,
        P2.Ataque_Nome2 AS Pokemon2_Ataque2,
        P2.Ataque_Nome3 AS Pokemon2_Ataque3,
        P2.Ataque_Nome4 AS Pokemon2_Ataque4,
        P2.Item_Nome AS Pokemon2_Item,

        -- Detalhes do Pokémon 3
        P3.Pokemons_Nome AS Pokemon3_Nome,
        P3.Ataque_Nome1 AS Pokemon3_Ataque1,
        P3.Ataque_Nome2 AS Pokemon3_Ataque2,
        P3.Ataque_Nome3 AS Pokemon3_Ataque3,
        P3.Ataque_Nome4 AS Pokemon3_Ataque4,
        P3.Item_Nome AS Pokemon3_Item,

        -- Detalhes do Pokémon 4
        P4.Pokemons_Nome AS Pokemon4_Nome,
        P4.Ataque_Nome1 AS Pokemon4_Ataque1,
        P4.Ataque_Nome2 AS Pokemon4_Ataque2,
        P4.Ataque_Nome3 AS Pokemon4_Ataque3,
        P4.Ataque_Nome4 AS Pokemon4_Ataque4,
        P4.Item_Nome AS Pokemon4_Item,

        -- Detalhes do Pokémon 5
        P5.Pokemons_Nome AS Pokemon5_Nome,
        P5.Ataque_Nome1 AS Pokemon5_Ataque1,
        P5.Ataque_Nome2 AS Pokemon5_Ataque2,
        P5.Ataque_Nome3 AS Pokemon5_Ataque3,
        P5.Ataque_Nome4 AS Pokemon5_Ataque4,
        P5.Item_Nome AS Pokemon5_Item,

        -- Detalhes do Pokémon 6
        P6.Pokemons_Nome AS Pokemon6_Nome,
        P6.Ataque_Nome1 AS Pokemon6_Ataque1,
        P6.Ataque_Nome2 AS Pokemon6_Ataque2,
        P6.Ataque_Nome3 AS Pokemon6_Ataque3,
        P6.Ataque_Nome4 AS Pokemon6_Ataque4,
        P6.Item_Nome AS Pokemon6_Item

    FROM 
        PokeCup_EquipaPokemons AS E
    LEFT JOIN PokeCup_PokemonEscolhido AS P1 ON E.Pokemons_escolhidos_ID1 = P1.ID
    LEFT JOIN PokeCup_PokemonEscolhido AS P2 ON E.Pokemons_escolhidos_ID2 = P2.ID
    LEFT JOIN PokeCup_PokemonEscolhido AS P3 ON E.Pokemons_escolhidos_ID3 = P3.ID
    LEFT JOIN PokeCup_PokemonEscolhido AS P4 ON E.Pokemons_escolhidos_ID4 = P4.ID
    LEFT JOIN PokeCup_PokemonEscolhido AS P5 ON E.Pokemons_escolhidos_ID5 = P5.ID
    LEFT JOIN PokeCup_PokemonEscolhido AS P6 ON E.Pokemons_escolhidos_ID6 = P6.ID
    WHERE 
        E.Jogador_Nickname = @nickname
);

SELECT * FROM GetEquipaFromJogador('Borges');

CREATE FUNCTION GetEquipaFromJogadorFromTier(@nickname VARCHAR(32), @tier TIERS) RETURNS TABLE AS
RETURN (
    SELECT 
		E.ID,

		-- Detalhes do Pokémon 1
        P1.Pokemons_Nome AS Pokemon1_Nome,
        P1.Ataque_Nome1 AS Pokemon1_Ataque1,
        P1.Ataque_Nome2 AS Pokemon1_Ataque2,
        P1.Ataque_Nome3 AS Pokemon1_Ataque3,
        P1.Ataque_Nome4 AS Pokemon1_Ataque4,
        P1.Item_Nome AS Pokemon1_Item,

        -- Detalhes do Pokémon 2
        P2.Pokemons_Nome AS Pokemon2_Nome,
        P2.Ataque_Nome1 AS Pokemon2_Ataque1,
        P2.Ataque_Nome2 AS Pokemon2_Ataque2,
        P2.Ataque_Nome3 AS Pokemon2_Ataque3,
        P2.Ataque_Nome4 AS Pokemon2_Ataque4,
        P2.Item_Nome AS Pokemon2_Item,

        -- Detalhes do Pokémon 3
        P3.Pokemons_Nome AS Pokemon3_Nome,
        P3.Ataque_Nome1 AS Pokemon3_Ataque1,
        P3.Ataque_Nome2 AS Pokemon3_Ataque2,
        P3.Ataque_Nome3 AS Pokemon3_Ataque3,
        P3.Ataque_Nome4 AS Pokemon3_Ataque4,
        P3.Item_Nome AS Pokemon3_Item,

        -- Detalhes do Pokémon 4
        P4.Pokemons_Nome AS Pokemon4_Nome,
        P4.Ataque_Nome1 AS Pokemon4_Ataque1,
        P4.Ataque_Nome2 AS Pokemon4_Ataque2,
        P4.Ataque_Nome3 AS Pokemon4_Ataque3,
        P4.Ataque_Nome4 AS Pokemon4_Ataque4,
        P4.Item_Nome AS Pokemon4_Item,

        -- Detalhes do Pokémon 5
        P5.Pokemons_Nome AS Pokemon5_Nome,
        P5.Ataque_Nome1 AS Pokemon5_Ataque1,
        P5.Ataque_Nome2 AS Pokemon5_Ataque2,
        P5.Ataque_Nome3 AS Pokemon5_Ataque3,
        P5.Ataque_Nome4 AS Pokemon5_Ataque4,
        P5.Item_Nome AS Pokemon5_Item,

        -- Detalhes do Pokémon 6
        P6.Pokemons_Nome AS Pokemon6_Nome,
        P6.Ataque_Nome1 AS Pokemon6_Ataque1,
        P6.Ataque_Nome2 AS Pokemon6_Ataque2,
        P6.Ataque_Nome3 AS Pokemon6_Ataque3,
        P6.Ataque_Nome4 AS Pokemon6_Ataque4,
        P6.Item_Nome AS Pokemon6_Item

    FROM 
        PokeCup_EquipaPokemons AS E
    LEFT JOIN PokeCup_PokemonEscolhido AS P1 ON E.Pokemons_escolhidos_ID1 = P1.ID
    LEFT JOIN PokeCup_PokemonEscolhido AS P2 ON E.Pokemons_escolhidos_ID2 = P2.ID
    LEFT JOIN PokeCup_PokemonEscolhido AS P3 ON E.Pokemons_escolhidos_ID3 = P3.ID
    LEFT JOIN PokeCup_PokemonEscolhido AS P4 ON E.Pokemons_escolhidos_ID4 = P4.ID
    LEFT JOIN PokeCup_PokemonEscolhido AS P5 ON E.Pokemons_escolhidos_ID5 = P5.ID
    LEFT JOIN PokeCup_PokemonEscolhido AS P6 ON E.Pokemons_escolhidos_ID6 = P6.ID
    WHERE 
        E.Jogador_Nickname = @nickname AND E.Tier = @tier
);

SELECT * FROM GetEquipaFromJogadorFromTier('Borges', 'OU');