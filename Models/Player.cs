using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SummerGames.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}