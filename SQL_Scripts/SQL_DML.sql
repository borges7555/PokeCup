USE PokeCup;
GO

INSERT INTO Item VALUES
    ('Air Balloon','When held by a Pokémon, the Pokémon will float into the air. When the holder is attacked, this item will burst.'),
    ('Choice Band','Raises Attack, but only one move can be used.'),
    ('Choice Scarf','Raises Speed, but only one move can be used.'),
    ('Choice Specs','Raises Special Attack, but only one move can be used.'),
    ('Expert Belt','Increases the power of super-effective moves.'),
    ('Flame Orb','An item to be held by a Pokémon. It is a bizarre orb that inflicts a burn on the holder in battle.'),
    ('Focus Sash','An item to be held by a Pokémon. If it has full HP, the holder will endure one potential KO attack, leaving 1 HP.'),
    ('Leftovers','An item to be held by a Pokémon. The HP of the holder is gradually restored during battle.'),
    ('Life Orb','Increases the power of moves, but loses HP each turn.'),
    ('Muscle Band','Increases the power of Physical-category moves.'),
    ('Rocky Helmet','If the holder of this item takes damage, the attacker will also be damaged upon contact.'),
    ('Toxic Orb','An item to be held by a Pokémon. It is a bizarre orb that badly poisons the holder in battle.'),
    ('Wise Glasses','Increases the power of Special-category moves.');

INSERT INTO Ataque VALUES
    ('Bug Buzz','Bug',90,100,'Special'),
    ('X-Scissor','Bug',80,100,'Physical'),
    ('U-turn','Bug',70,100,'Physical'),
    ('Quiver Dance','Bug',NULL,NULL,'Status'),
    ('Crunch','Dark',80,100,'Physical'),
    ('Night Daze','Dark',85,85,'Special'),
    ('Nasty Plot','Dark',NULL,NULL,'Status'),
    ('Outrage','Dragon',120,100,'Physical'),
    ('Draco Meteor','Dragon',140,90,'Special'),
    ('Dragon Claw','Dragon',80,100,'Physical'),
    ('Dragon Pulse','Dragon',90,100,'Special'),
    ('Dragon Dance','Dragon',NULL,NULL,'Status'),
    ('Thunder','Electric',120,70,'Special'),
    ('Volt Tackle','Electric',120,100,'Physical'),
    ('Thunderbolt','Electric',95,100,'Special'),
    ('Wild Charge','Electric',90,100,'Physical'),
    ('Close Combat','Fighting',120,100,'Physical'),
    ('Focus Blast','Fighting',120,70,'Special'),
    ('Brick Break','Fighting',75,100,'Physical'),
    ('Detect','Fighting',NULL,NULL,'Status'),
    ('Flare Blitz','Fire',120,100,'Physical'),
    ('Overheat','Fire',140,90,'Special'),
    ('Flamethrower','Fire',95,100,'Special'),
    ('Fire Punch','Fire',75,100,'Physical'),
    ('Brave Bird','Flying',120,100,'Physical'),
    ('Hurricane','Flying',120,70,'Special'),
    ('Acrobatics','Flying',55,100,'Physical'),
    ('Shadow Ball','Ghost',80,100,'Special'),
    ('Shadow Claw','Ghost',70,100,'Physical'),
    ('Leaf Storm','Grass',140,90,'Special'),
    ('Power Whip','Grass',120,85,'Physical'),
    ('Energy Ball','Grass',80,100,'Special'),
    ('Earthquake','Ground',100,100,'Physical'),
    ('Earth Power','Ground',90,100,'Special'),
    ('Blizzard','Ice',120,70,'Special'),
    ('Ice Punch','Ice',75,100,'Physical'),
    ('Ice Beam','Ice',95,100,'Special'),
    ('Double-Edge','Normal',120,100,'Physical'),
    ('Hyper Voice','Normal',90,100,'Special'),
    ('Swords Dance','Normal',NULL,NULL,'Status'),
    ('Shell Smash','Normal',NULL,NULL,'Status'),
    ('Protect','Normal',NULL,NULL,'Status'),
    ('Recover','Normal',NULL,NULL,'Status'),
    ('Gunk Shot','Poison',120,70,'Physical'),
    ('Sludge Wave','Poison',95,100,'Special'),
    ('Poison Jab','Poison',80,100,'Physical'),
    ('Zen Headbutt','Psychic',80,90,'Physical'),
    ('Psystrike','Psychic',100,100,'Special'),
    ('Psychic','Psychic',90,100,'Special'),
    ('Calm Mind','Psychic',NULL,NULL,'Status'),
    ('Stone Edge','Rock',100,80,'Physical'),
    ('Power Gem','Rock',80,100,'Special'),
    ('Rock Slide','Rock',75,90,'Physical'),
    ('Iron Tail','Steel',100,75,'Physical'),
    ('Flash Cannon','Steel',80,100,'Special'),
    ('Aqua Tail','Water',90,90,'Physical'),
    ('Hydro Pump','Water',120,80,'Special');

INSERT INTO Pokemons VALUES
    (494,'Victini','../pokemon_images/494.png','Psychic','Fire','UU'),
    (497,'Serperior','../pokemon_images/497.png','Grass',NULL,'NU'),
    (500,'Emboar','../pokemon_images/500.png','Fire','Fighting','RU'),
    (503,'Samurott','../pokemon_images/503.png','Water',NULL,'NU'),
    (508,'Stoutland','../pokemon_images/508.png','Normal',NULL,'PU'),
    (523,'Zebstrika','../pokemon_images/523.png','Electric',NULL,'PU'),
    (530,'Excadrill','../pokemon_images/530.png','Ground','Steel','OU'),
    (534,'Conkeldurr','../pokemon_images/534.png','Fighting',NULL,'OU'),
    (537,'Seismitoad','../pokemon_images/537.png','Water','Ground','NU'),
    (553,'Krookodile','../pokemon_images/553.png','Ground','Dark','UU'),
    (555,'Darmanitan','../pokemon_images/555.png','Fire',NULL,'UU'),
    (560,'Scrafty','../pokemon_images/560.png','Dark','Fighting','UU'),
    (563,'Cofagrigus','../pokemon_images/563.png','Ghost',NULL,'UU'),
    (565,'Carracosta','../pokemon_images/565.png','Water','Rock','NU'),
    (567,'Archeops','../pokemon_images/567.png','Rock','Flying','RU'),
    (571,'Zoroark','../pokemon_images/571.png','Dark',NULL,'UU'),
    (576,'Gothitelle','../pokemon_images/576.png','Psychic',NULL,'OU'),
    (579,'Reuniclus','../pokemon_images/579.png','Psychic',NULL,'OU'),
    (584,'Vanilluxe','../pokemon_images/584.png','Ice',NULL,'PU'),
    (589,'Escavalier','../pokemon_images/589.png','Bug','Steel','RU'),
    (593,'Jellicent','../pokemon_images/593.png','Water','Ghost','OU'),
    (596,'Galvantula','../pokemon_images/596.png','Bug','Electric','RU'),
    (598,'Ferrothorn','../pokemon_images/598.png','Grass','Steel','OU'),
    (604,'Eelektross','../pokemon_images/604.png','Electric',NULL,'NU'),
    (609,'Chandelure','../pokemon_images/609.png','Ghost','Fire','OU'),
    (612,'Haxorus','../pokemon_images/612.png','Dragon',NULL,'OU'),
    (614,'Beartic','../pokemon_images/614.png','Ice',NULL,'PU'),
    (617,'Accelgor','../pokemon_images/617.png','Bug',NULL,'RU'),
    (620,'Mienshao','../pokemon_images/620.png','Fighting',NULL,'UU'),
    (621,'Druddigon','../pokemon_images/621.png','Dragon',NULL,'RU'),
    (623,'Golurk','../pokemon_images/623.png','Ground','Ghost','NU'),
    (625,'Bisharp','../pokemon_images/625.png','Dark','Steel','UU'),
    (628,'Braviary','../pokemon_images/628.png','Normal','Flying','NU'),
    (630,'Mandibuzz','../pokemon_images/630.png','Dark','Flying','NU'),
    (635,'Hydreigon','../pokemon_images/635.png','Dark','Dragon','OU'),
    (637,'Volcarona','../pokemon_images/637.png','Bug','Fire','OU'),
    (638,'Cobalion','../pokemon_images/638.png','Steel','Fighting','UU'),
    (639,'Terrakion','../pokemon_images/639.png','Rock','Fighting','OU'),
    (640,'Virizion','../pokemon_images/640.png','Grass','Fighting','UU'),
    (641,'Tornadus','../pokemon_images/641.png','Flying',NULL,'UU'),
    (642,'Thundurus','../pokemon_images/642.png','Electric','Flying','Uber'),
    (643,'Reshiram','../pokemon_images/643.png','Dragon','Fire','Uber'),
    (644,'Zekrom','../pokemon_images/644.png','Dragon','Electric','Uber'),
    (645,'Landorus','../pokemon_images/645.png','Ground','Flying','Uber'),
    (646,'Kyurem','../pokemon_images/646.png','Dragon','Ice','OU'),
    (647,'Keldeo','../pokemon_images/647.png','Water','Fighting','OU'),
    (648,'Meloetta','../pokemon_images/648.png','Normal','Psychic','UU'),
    (649,'Genesect','../pokemon_images/649.png','Bug','Steel','Uber');

INSERT INTO Jogador VALUES
    ('Borges', 0);

INSERT INTO Pokemon_escolhido VALUES
    (571,'Night Daze','Focus Blast','Hyper Voice','Nasty Plot','Focus Sash'),
    (612,'Outrage','Earthquake','Brick Break','X-Scissor','Choice Band'),
    (647,'Focus Blast','Hydro Pump','Calm Mind','Protect','Expert Belt'),
    (555,'Flare Blitz','Earthquake','Stone Edge','Zen Headbutt','Life Orb'),
    (596,'Thunder','Bug Buzz','Energy Ball','Thunderbolt','Choice Specs'),
    (530,'Earthquake','X-Scissor','Rock Slide','Swords Dance','Air Balloon');

INSERT INTO Equipa_Pokemons VALUES
    ('Borges','OU',2,3,4,5,6,7);


--testes
SELECT * FROM Item;
SELECT * FROM Ataque;
SELECT * FROM Pokemons;
SELECT * FROM Jogador;
SELECT * FROM Pokemon_escolhido;
SELECT * FROM Equipa_Pokemons;
