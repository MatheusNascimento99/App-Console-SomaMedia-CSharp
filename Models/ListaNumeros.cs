using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomaMedia.Models
{
    public class ListaNumeros


    {
        public (decimal soma, decimal media) SomaMedia(List<decimal> listaNumeros)
        {
            decimal soma = 0;
            foreach (var item in listaNumeros)
            {
                soma = soma + item;
            }

            decimal media = listaNumeros.Average();
            return (soma, media);
        }


    }
}