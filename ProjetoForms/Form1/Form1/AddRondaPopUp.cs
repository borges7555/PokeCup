using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Form1.CriarPartidasPopUp;

namespace Form1
{
    public partial class AddRondaPopUp : Form
    {
        public AddRondaPopUp()
        {
            InitializeComponent();
            LoadTorneios();
        }

        private string connectionString = "Server=mednat.ieeta.pt\\\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";

        private void comboBoxTorneios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadTorneios()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PokeCup_Torneio";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable playersTable = new DataTable();
                adapter.Fill(playersTable);

                comboBoxTorneios.DataSource = playersTable;
                comboBoxTorneios.DisplayMember = "Nome";
                comboBoxTorneios.ValueMember = "Nome";
            }
        }

        private void buttonSimular_Click(object sender, EventArgs e)
        {
            // Obter o torneio selecionado
            string selectedTorneio = comboBoxTorneios.SelectedValue?.ToString() ?? "DefaultTorneio";

            // Obter o ID do torneio a partir do nome
            int torneioId = GetTorneioId(selectedTorneio);

            // Verificar se o torneio já tem rondas
            if (TorneioTemRondas(torneioId))
            {
                MessageBox.Show("A simulação das rondas já foi feita.");
                return;
            }

            // Passo 1: Buscar as partidas iniciais
            var partidas = GetInitialPartidas(torneioId);
                     

            if (partidas != null)
            {
                SimulateTournament(torneioId, partidas);
            }


        }


        private void SimulateTournament(int torneioId, DataTable partidas)
        {
            // Inicializar o número da próxima partida como 1
            int novoPartidaNumero = 1;

            while (partidas.Rows.Count > 0)
            {
                var vencedores = new DataTable();
                vencedores.Columns.Add("Jogador_Nickname");

                foreach (DataRow partida in partidas.Rows)
                {
                    int numVitoriasJ1 = 0;
                    int numVitoriasJ2 = 0;
                    int partidaNumero = Convert.ToInt32(partida["Numero"]);

                    for (int i = 1; i <= 3; i++)
                    {
                        var (numPokeVivosJ1, numPokeVivosJ2) = SimulateRonda();
                        string vencedorRonda = numPokeVivosJ1 > numPokeVivosJ2 ?
                                               partida["Jogador_Nickname_1"].ToString() :
                                               partida["Jogador_Nickname_2"].ToString();

                        if (vencedorRonda == partida["Jogador_Nickname_1"].ToString())
                        {
                            numVitoriasJ1++;
                        }
                        else
                        {
                            numVitoriasJ2++;
                        }

                        MessageBox.Show($"Partida {partidaNumero}, Ronda {i}: {partida["Jogador_Nickname_1"]} (Pokémons Vivos: {numPokeVivosJ1}) vs {partida["Jogador_Nickname_2"]} (Pokémons Vivos: {numPokeVivosJ2}) - Vencedor: {vencedorRonda}");

                        ExecuteCreateRonda(i, numPokeVivosJ1, numPokeVivosJ2, partidaNumero, torneioId, vencedorRonda);
                    }

                    string vencedorPartida = numVitoriasJ1 > numVitoriasJ2 ?
                                             partida["Jogador_Nickname_1"].ToString() :
                                             partida["Jogador_Nickname_2"].ToString();

                    MessageBox.Show($"Partida {partidaNumero}: Vencedor - {vencedorPartida}");

                    DataRow vencedorRow = vencedores.NewRow();
                    vencedorRow["Jogador_Nickname"] = vencedorPartida;
                    vencedores.Rows.Add(vencedorRow);

                    // Registrar resultado final da partida usando o número da partida atual
                    ExecuteCreateResultadoFinal(partidaNumero, torneioId, vencedorPartida, numVitoriasJ1, numVitoriasJ2);
                }

                // Se restar apenas um vencedor, ele é o campeão do torneio
                if (vencedores.Rows.Count == 1)
                {
                    var vencedorFinal = vencedores.Rows[0]["Jogador_Nickname"].ToString();
                    MessageBox.Show($"O vencedor do torneio é: {vencedorFinal}");
                    break;
                }

                // Atualizar o número da próxima partida apenas quando necessário criar novas partidas
                novoPartidaNumero = GetNextPartidaNumero(torneioId);
                partidas = CreateNewPartidas(vencedores, torneioId, ref novoPartidaNumero);
            }
        }





        // Função para gerar rondas com valores aleatórios
        private (int, int) SimulateRonda()
        {
            Random rand = new Random();
            int numPokeVivosJ1, numPokeVivosJ2;

            // Decidir aleatoriamente qual jogador terá 0 pokémons vivos
            if (rand.Next(0, 2) == 0)
            {
                numPokeVivosJ1 = 0;
                numPokeVivosJ2 = rand.Next(1, 7); // Aleatório entre 1 e 6
            }
            else
            {
                numPokeVivosJ1 = rand.Next(1, 7); // Aleatório entre 1 e 6
                numPokeVivosJ2 = 0;
            }

            return (numPokeVivosJ1, numPokeVivosJ2);
        }


        // Função para criar uma nova ronda
        private void ExecuteCreateRonda(int num, int numPokeVivos1, int numPokeVivos2, int partidaNumero, int torneioId, string vencedor)
        {
            string query = "EXEC CreateRonda @num, @num_poke_vivos1, @num_poke_vivos2, @partidanumero, @torneioid, @jogador_vencedor";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@num", num);
                    command.Parameters.AddWithValue("@num_poke_vivos1", numPokeVivos1);
                    command.Parameters.AddWithValue("@num_poke_vivos2", numPokeVivos2);
                    command.Parameters.AddWithValue("@partidanumero", partidaNumero);
                    command.Parameters.AddWithValue("@torneioid", torneioId);
                    command.Parameters.AddWithValue("@jogador_vencedor", vencedor);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Função para criar o resultado final de uma partida
        private void ExecuteCreateResultadoFinal(int partidaNumero, int torneioId, string vencedor, int rondasGanhasJ1, int rondasGanhasJ2)
        {
            // Mensagem de debug para verificar valores
            //MessageBox.Show($"Debug: Tentando inserir resultado final\n" +
            //                $"Partida_Numero: {partidaNumero}\n" +
            //                $"Torneio_ID: {torneioId}\n" +
            //                $"Jogador_Vencedor: {vencedor}\n" +
            //                $"Rondas_Ganhas_J1: {rondasGanhasJ1}\n" +
            //                $"Rondas_Ganhas_J2: {rondasGanhasJ2}");

            string query = "EXEC CreateResultadoFinal @partidanumero, @torneioid, @jogadorvencedor, @rondas_ganhas1, @rondas_ganhas2";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@partidanumero", partidaNumero);
                    command.Parameters.AddWithValue("@torneioid", torneioId);
                    command.Parameters.AddWithValue("@jogadorvencedor", vencedor);
                    command.Parameters.AddWithValue("@rondas_ganhas1", rondasGanhasJ1);
                    command.Parameters.AddWithValue("@rondas_ganhas2", rondasGanhasJ2);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }



        // Função para obter o próximo número de partida disponível para garantir unicidade dentro do torneioId
        private int GetNextPartidaNumero(int torneioId)
        {
            string query = "SELECT ISNULL(MAX(Numero), 0) + 1 FROM PokeCup_Partida WHERE Torneio_ID = @torneioid";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@torneioid", torneioId);
                    connection.Open();
                    int nextPartidaNum = (int)command.ExecuteScalar();
                    //MessageBox.Show($"Debug: Próximo número de partida para Torneio_ID {torneioId} é {nextPartidaNum}");
                    return nextPartidaNum;
                }
            }
        }


        private DataTable CreateNewPartidas(DataTable vencedores, int torneioId, ref int partidaNum)
        {
            DataTable novasPartidas = new DataTable();
            novasPartidas.Columns.Add("Numero");
            novasPartidas.Columns.Add("Torneio_ID");
            novasPartidas.Columns.Add("Jogador_Nickname_1");
            novasPartidas.Columns.Add("Jogador_Nickname_2");

            Random rand = new Random();
            List<string> jogadores = vencedores.AsEnumerable().Select(row => row["Jogador_Nickname"].ToString()).ToList();

            while (jogadores.Count > 1)
            {
                int index1 = rand.Next(jogadores.Count);
                string jogador1 = jogadores[index1];
                jogadores.RemoveAt(index1);

                int index2 = rand.Next(jogadores.Count);
                string jogador2 = jogadores[index2];
                jogadores.RemoveAt(index2);

                DataRow novaPartida = novasPartidas.NewRow();
                novaPartida["Numero"] = partidaNum;
                novaPartida["Torneio_ID"] = torneioId;
                novaPartida["Jogador_Nickname_1"] = jogador1;
                novaPartida["Jogador_Nickname_2"] = jogador2;
                novasPartidas.Rows.Add(novaPartida);

                // Inserir nova partida na tabela PokeCup_Partida
                InserirPartida(partidaNum, torneioId, jogador1, jogador2);

                // Debug: Mostrar nova partida criada
                MessageBox.Show($"Nova Partida {partidaNum}: {jogador1} vs {jogador2}");

                partidaNum++;
            }

            // Caso haja um jogador restante sem adversário, ele avança automaticamente para a próxima rodada
            if (jogadores.Count == 1)
            {
                DataRow novaPartida = novasPartidas.NewRow();
                novaPartida["Numero"] = partidaNum;
                novaPartida["Torneio_ID"] = torneioId;
                novaPartida["Jogador_Nickname_1"] = jogadores[0];
                novaPartida["Jogador_Nickname_2"] = DBNull.Value;
                novasPartidas.Rows.Add(novaPartida);

                // Inserir nova partida na tabela PokeCup_Partida
                InserirPartida(partidaNum, torneioId, jogadores[0], null);

                partidaNum++;
            }

            return novasPartidas;
        }



        private void InserirPartida(int partidaNum, int torneioId, string jogador1, string jogador2)
        {
            // Mensagem de debug para verificar valores
            //MessageBox.Show($"Debug: Tentando inserir nova partida\n" +
            //                $"Partida_Numero: {partidaNum}\n" +
            //                $"Torneio_ID: {torneioId}\n" +
            //                $"Jogador_Nickname_1: {jogador1}\n" +
            //                $"Jogador_Nickname_2: {jogador2}");

            string query = "INSERT INTO PokeCup_Partida (Numero, Torneio_ID, Jogador_Nickname_1, Jogador_Nickname_2) " +
                           "VALUES (@partidaNum, @torneioId, @jogador1, @jogador2)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@partidaNum", partidaNum);
                    command.Parameters.AddWithValue("@torneioId", torneioId);
                    command.Parameters.AddWithValue("@jogador1", jogador1);
                    command.Parameters.AddWithValue("@jogador2", jogador2 ?? (object)DBNull.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }





        private bool PartidaExiste(int partidaNumero, int torneioId)
        {
            string query = "SELECT COUNT(*) FROM PokeCup_Partida WHERE Numero = @partidaNumero AND Torneio_ID = @torneioId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@partidaNumero", partidaNumero);
                    command.Parameters.AddWithValue("@torneioId", torneioId);
                    connection.Open();
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }



        public string GetVencedorRonda(int torneioId, int partidaNumero)
        {
            string query = @"
            SELECT Jogador_Nickname_Vencedor, COUNT(*) AS Vitórias
            FROM PokeCup_Ronda
            WHERE Torneio_ID = @Torneio_ID AND Partida_Numero = @Partida_Numero
            GROUP BY Jogador_Nickname_Vencedor
            ORDER BY Vitórias DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Torneio_ID", torneioId);
                    command.Parameters.AddWithValue("@Partida_Numero", partidaNumero);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["Jogador_Nickname_Vencedor"].ToString();
                        }
                    }
                }
            }
            return null;
        }

        private DataTable GetInitialPartidas(int torneioId)
        {
            string query = "SELECT * FROM PokeCup_Partida WHERE Torneio_ID = @Torneio_ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Torneio_ID", torneioId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable partidas = new DataTable();
                        adapter.Fill(partidas);

                        // Construir a string com as informações de todas as partidas
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"Partidas Iniciais: {partidas.Rows.Count}");
                        foreach (DataRow row in partidas.Rows)
                        {
                            sb.AppendLine($"Número: {row["Numero"]}, Torneio_ID: {row["Torneio_ID"]}, Jogador_Nickname_1: {row["Jogador_Nickname_1"]}, Jogador_Nickname_2: {row["Jogador_Nickname_2"]}");
                        }

                        // Exibir a string em uma MessageBox
                        MessageBox.Show(sb.ToString());

                        return partidas;
                    }
                }
            }
        }


        private int GetTorneioId(string selectedTorneio)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID FROM PokeCup_Torneio WHERE Nome = @Nome";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", selectedTorneio);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return -1; // Indica que o torneio não foi encontrado
        }

        private bool TorneioTemRondas(int torneioId)
        {
            // Verificar no banco de dados se o torneio já tem jogadores
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM PokeCup_Ronda WHERE Torneio_ID = @TorneioId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TorneioId", torneioId);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

    }
}
