

using System.ComponentModel;
using SomaMedia.Models;

List<decimal> listNumeros = new List<decimal>();

Console.WriteLine("Quantos números a lista irá possuir?");
int quantidadeNumerosLista = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < quantidadeNumerosLista; i++)
{
    Console.WriteLine("Informe o número:");
    listNumeros.Add(Convert.ToDecimal(Console.ReadLine()));
}


ListaNumeros listaNumeros = new();

Console.WriteLine($"NÚMEROS INFORMADOS:");

foreach (var item in listNumeros)
{
    Console.WriteLine($"{item}");
}

var resultado = listaNumeros.SomaMedia(listNumeros); //para acessar diferentes retornos
Console.WriteLine($"Soma: {resultado.soma}");
Console.WriteLine($"Media: {resultado.media}");