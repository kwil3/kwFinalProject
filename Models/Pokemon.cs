using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace kwFinalProject.models
{
    public class User
    {
        public int pokeID {get; set;} //primary key
        public String pokeName {get; set;}
        public int attack {get; set;}
        public int defense {get; set;}
        public int spAttack {get; set;}
        public int spDefense {get; set;}
        public int speed {get; set;}

    }
}