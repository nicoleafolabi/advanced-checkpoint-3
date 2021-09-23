using System;
using System.Collections.Generic;

namespace AppLibrary
{
    public class Searching
    {
        public static string SearchByName(List<Places> places, string name) => name switch
        {
            places.ElementAt(0) => $"{places[0].name} {places[0].position[0]} {places[0].position[1]}",
            places[1].name => $"{places[1].name} {places[1].position[0]} {places[1].position[1]}",
            places[2].name => $"{places[2].name} {places[2].position[0]} {places[2].position[1]}",


        };
    }

}