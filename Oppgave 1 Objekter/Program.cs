// See https://aka.ms/new-console-template for more information
using Oppgave_1_Objekter;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;

var Pikachu = new Pokemon("Pikachu", 55, 23);
var Bulbusaur = new Pokemon("Bulbasaur", 20, 19);
var Charmander = new Pokemon("Charmander", 60, 33);

Console.WriteLine($"Denne pokemonen heter: {Charmander.Name} og den har {Charmander.Health}hp. Level: {Charmander.Level}");
Console.WriteLine($"Denne pokemonen heter: {Bulbusaur.Name} og den har {Bulbusaur.Health}hp. Level: {Bulbusaur.Level}");
Console.WriteLine($"Denne pokemonen heter: {Pikachu.Name} og den har {Pikachu.Health}hp. Level: {Pikachu.Level}");





