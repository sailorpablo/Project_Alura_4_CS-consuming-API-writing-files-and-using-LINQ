using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Filtros
{
    internal class LinqOrder
    {
        public static void OrdenarArtistasPorNome(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(artista => artista.Artista).Distinct();

            foreach (var artistas in artistasOrdenados)
            {
                Console.WriteLine($" - {artistas}");
            }

        }
    }
}
