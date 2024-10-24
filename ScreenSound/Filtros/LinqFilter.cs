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
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

            foreach (var generos in todosOsGenerosMusicais)
            {
                Console.WriteLine($" - {generos}");
            }
        }


    }
}
