using Netflix_Clone.NetflixContext;
using System;
using System.Collections.Generic;

namespace Netflix_Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalogs = new List<Catalog>();
            catalogs.Add(new Catalog("Filmes", "www.netflix.com/filmes"));
            catalogs.Add(new Catalog("Series", "www.netflix.com/series"));


            var catalogsItems = new List<CatalogItem>();
            var ozark = new CatalogItem("Ozark", "Um consultor financeiro leva a família para um lago remoto para lavar quinhentos milhões de dólares e acalmar um traficante.", DateTime.Now);
            var umbrela = new CatalogItem("The Umbrella Academy", "Com a morte do pai, irmãos com poderes extraordinários se reencontram e descobrem surpreendentes segredos de família – além de uma ameaça iminente à humanidade.", DateTime.Now);
            var voce = new CatalogItem(null, "Obsessivo e perigosamente charmoso, ele vai ao extremo para entrar na vida de quem o fascina. Você pode acabar fisgada sem nem perceber. Aí, pode ser tarde demais.", DateTime.Now);

            catalogsItems.Add(ozark);
            catalogsItems.Add(umbrela);
            catalogsItems.Add(voce);

            foreach (var catalogItem in catalogsItems)
            {
                Console.WriteLine($" Nome: {catalogItem.Name}");
                Console.WriteLine();

                Console.WriteLine($" Descrição: {catalogItem.Description}");
                Console.WriteLine();

                Console.WriteLine($" Duração: {catalogItem.Duration}");
                Console.WriteLine();
            }


        }
    }
}
