using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            pokemon pokemon = new pokemon();
            pokemon.Number = "004";
            pokemon.Name = "Charmander";
            pokemon.Height = 2.0f;
            pokemon.Weight = 12.7f;
            pokemon.Category = "Lizard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";
            Console.WriteLine("編號:{0},名字:{1},身高:{2},體重:{3},類別:{4},能力:{5},性別:{6}", pokemon.Number, pokemon.Name, pokemon.Height, pokemon.Weight, pokemon.Category, pokemon.Abilities, pokemon.Gender);
        }
    }
}