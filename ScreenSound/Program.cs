using ScreenSound.Modelos;
using System.Text.Json;
using ScreenSound.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        MusicasFavoritas musicasFav = new MusicasFavoritas("Musicas de Treino");

        MusicasFavoritas musicasFav2 = new MusicasFavoritas("Musicas de Relaxar");

        Console.WriteLine(musicas.Count);

        musicas[0].ExibirDetalhesDaMusica();

        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);

        LinqOrder.OrdenarArtistasPorNome(musicas);

        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");

        LinqFilter.FiltrarMusicasDeArtista(musicas, "Post Malone");

        

        for (int i = 0; i < 5; i++)
        {
            musicasFav.AdicionarMusicasFavoritas(musicas[i]);
            musicasFav2.AdicionarMusicasFavoritas(musicas[i*10]);
        }

        musicasFav.ExibirMusicasAdicionadas();
        Console.WriteLine(" ");
        musicasFav2.ExibirMusicasAdicionadas();

        musicasFav.GerarArquivoJson();

    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}

