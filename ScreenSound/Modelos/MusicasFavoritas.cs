using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class MusicasFavoritas
    {
        public string? Nome { get; set; }

        public List<Musica> Musicas { get; }

        public MusicasFavoritas(string nome) {

            Nome = nome;
            
            Musicas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            Musicas.Add(musica);
        }

        public void ExibirMusicasAdicionadas()
        {
            Console.WriteLine($"Musicas favoritas da lista {Nome}:");

            foreach (var musica in Musicas)
            {

                Console.WriteLine($"Musica: {musica.Nome} do artista: {musica.Artista}");

            }
        }

        public void GerarArquivoJson()
        {

            string json = JsonSerializer.Serialize(new {
            
                nome = Nome,
                musicas = Musicas
            
            });
            string nomeDoArquivo = $"{Nome}.json";
            File.WriteAllText(nomeDoArquivo, json);

            Console.WriteLine($"JSON CRIADO COM SUCESSO!!! {Path.GetFullPath(nomeDoArquivo)}");

        }

    }
}

