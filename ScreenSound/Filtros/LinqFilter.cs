using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(musicas => musicas.Genero).Distinct().ToList();

            foreach (var generos in todosOsGenerosMusicais)
            {
                Console.WriteLine($" - {generos}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.OrderBy(musicas => musicas.Artista).Where(musicas => musicas.Genero.Contains(genero)).Select(musicas => musicas.Artista).Distinct();

            Console.WriteLine($"Artistas do genero {genero}: \n");

            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasDeArtista(List<Musica> musicas, string artista)
        {
            var musicasPorArtista = musicas.OrderBy(musicas => musicas.Nome).Where(musicas => musicas.Artista.Contains(artista)).Select(musicas => musicas.Nome).Distinct();
           
            Console.WriteLine($"Segue lista com as musicas do artista {artista}: ");
            
            foreach (var listamusicas in musicasPorArtista)
            {
                Console.WriteLine($"- {listamusicas}");
            }
            
        }

    }
}
